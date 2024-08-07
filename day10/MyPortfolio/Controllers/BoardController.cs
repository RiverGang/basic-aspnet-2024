﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.Data;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
    public class BoardController : Controller
    {
        private readonly AppDbContext _context;

        public BoardController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Boards
        public IActionResult Index(int page = 1, string search = "")
        {
            // AppDbContext (DB핸들링객체)안의 Board DBset객체에 들어있는 데이터를 리스트(ToList)로 가져와서
            // 화면으로 보내어 출력하라
            // Views/Board/Index.cshtml을 화면에 뿌려라
            //return View(await _context.Board.ToListAsync());

            var totalCount = _context.Board.FromSqlRaw<Board>($"SELECT * FROM Board WHERE Title LIKE '%{search}%'").Count(); // 총 글갯수
            var countList = 10; // 페이지별 게시글 수
            var totalPage = totalCount / countList; // 총 페이지 수
            if (totalCount % countList > 0) totalPage++; // ex) 12 % 10 = 2 > 0  -------> 한페이지가 더 필요하기에 totalPage를 하나 더 늘려준다
            if (totalPage < page) page = totalPage; // 현재 페이지번호가 전체 페이지수보다 크면 축소시켜준다


            var countPage = 10; // 하단부 페이지 이동 번호의 갯수
            var startPage = ((page - 1) / countPage) * countPage + 1; // 1~10페이지, 11~20페이지
            var endPage = startPage + countPage - 1; // 1페이지부터 시작 시, 10페이지가 마지막
            if (totalPage < endPage) endPage = totalPage; // 2페이지까지 밖에 없으면 endPage 10 -> 2로 변경


            // 쿼리로 넘길 값
            var startCount = ((page - 1) * countPage) + 1; // 1, 11, 21 ... 순으로
            var endCount = startCount + (countPage - 1); // 10, 20, 30 ... 순으로

            // ViewData(Dictionary), ViewBag(Prop) 변수 --> 뷰cshtml에서 사용할 변수
            ViewBag.StartPage = startPage; ViewBag.EndPage = endPage;
            ViewBag.Page = page; ViewBag.TotalPage = totalPage;
            ViewBag.TotalCount = totalCount; // 전체 글 갯수
            ViewBag.Search = search;


            // 쿼리 나중에 수정 필요 TODO
            var list = _context.Board.FromSqlRaw<Board>(@$"
            SELECT *
              FROM (
                    SELECT ROW_NUMBER() OVER (ORDER BY b.Id DESC) AS rowNum
                         , b.Id
                         , b.UserId
                         , b.UserName AS UserName1
                         , b.Title   
                         , b.Contents
                         , b.Hit
                         , b.RegDate
                         , b.ModDate
                         , u.UserName
                      FROM Board AS b
                      LEFT JOIN [User] AS u
                        ON b.UserId = u.Id
                     WHERE b.Title LIKE '%{search}%'
                   ) AS base
             WHERE base.rowNum BETWEEN {startCount} AND {endCount}
            ").ToList();

            return View(list);
        }

        // 게시글 상세 읽기
        // GET: Boards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var board = await _context.Board
                .FirstOrDefaultAsync(m => m.Id == id); // SELECT * FROM board WHERE
            if (board == null)
            {
                return NotFound();
            }

            // 게시글 조회수 1 증가 시키기
            board.Hit = board.Hit == null ? 1 : board.Hit + 1;

            // 사용자 객체 가져옴
            User currUser = await _context.User.FirstOrDefaultAsync(u => u.UserEmail == HttpContext.Session.GetString("USER_EMAIL"));
            board.User = currUser;

            _context.Update(board); // 객체에 내용을 반영
            await _context.SaveChangesAsync(); // 실제 DB 변경
            return View(board); // 게시글 하나를 뷰로 던져준다
        }

        // GET: Boards/Create
        // GET => 링크를 클릭해서 화면이 전환
        [HttpGet]
        public IActionResult Create() // 아무 것도 안적혀 있으면 GET메서드
        {   
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인을 안했으니 로그인 창으로 가라
                return RedirectToAction("Login");
            }

            ViewData["USER_NMAE"] = HttpContext.Session.GetString("USER_NAME");

            // View/Board/Create.cshtml 화면을 출력하라
            return View();
        }

        // POST: Boards/Create
        [HttpPost] // HttpPost 태그가 있으면 POST메서드
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Contents,Hit,RegDate,ModDate")] Board board)
        {
            // 아무 값도 입력하지 않으면 ModelState.IsValid는 false
            if (ModelState.IsValid) 
            {
                // 사용자 객체 가져옴
                User currUser = await _context.User.FirstOrDefaultAsync(u => u.UserEmail == HttpContext.Session.GetString("USER_EMAIL"));

                if(currUser == null)
                {
                    return RedirectToAction("Index");
                }

                board.User = currUser; // 현재 로그인한 사용자를 할당

                board.RegDate = DateTime.Now;
                _context.Add(board); // DB 객체에 저장
                // insert 후, Commit => DB에 값을 넣고 저장
                await _context.SaveChangesAsync();

                // 게시판 목록화면으로 돌아감
                return RedirectToAction(nameof(Index));
            }
            return View(board);
        }

        // GET: Boards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인을 안했으니 로그인 창으로 가라
                return RedirectToAction("Login");
            }

            ViewData["USER_NMAE"] = HttpContext.Session.GetString("USER_NAME");

            if (id == null)
            {
                return NotFound();
            }

            var board = await _context.Board.FindAsync(id); // SELECT * FROM WHERE  -> id를 조건으로 찾아감
            if (board == null)
            {
                return NotFound();
            }
            return View(board);
        }

        // POST: Boards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Contents,Hit,RegDate,ModDate")] Board board)
        {
            if (id != board.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // 수정날짜 추가
                    board.ModDate = DateTime.Now; // 현재 수정하는 날짜시간을 입력
                    _context.Update(board); // 수정
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoardExists(board.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(board);
        }

        // GET: Boards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var board = await _context.Board
                .FirstOrDefaultAsync(m => m.Id == id);
            if (board == null)
            {
                return NotFound();
            }

            return View(board);
        }

        // POST: Boards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var board = await _context.Board.FindAsync(id);
            if (board != null)
            {
                _context.Board.Remove(board); // 객체 삭제
            }

            // DB Delete 후에 Commit
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoardExists(int id)
        {
            return _context.Board.Any(e => e.Id == id);
        }
    }
}
