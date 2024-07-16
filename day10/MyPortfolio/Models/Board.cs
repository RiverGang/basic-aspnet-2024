using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class Board
    {
        [Key] // PK
        public int Id { get; set; } 

        [Required] // Not Null 속성
        [MaxLength(20)] // NVARCHAR(20) 사이즈 지정
        public string UserName { get; set; } // 작성자명
        [MaxLength(20)]
        public string UserId { get; set; } //작성자아이디

        [Required]
        [MaxLength(50)]
        public string Title { get; set; } //게시글 제목
        public string Contents { get; set; } //게시글 내용
        public int  Hit {  get; set; } //게시글 조회수
        public DateTime RegDate { get; set; } = DateTime.Now;// 게시글 작성일자
        public DateTime ModeDate { get; set; } // 게시글 최종 수정일자
    }
}
