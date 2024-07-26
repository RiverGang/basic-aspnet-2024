# basic-aspnet-2024
IoT 개발자과정 ASP.NET  리포지토리

## 5일차
- HTML + CSS + js(jQuery) 응용
    - 핀터레스트 타입 + 부트스트랩 웹페이지 만들기 (완료)
    
    - https://github.com/RiverGang/basic-aspnet-2024/assets/122778656/16f20d6c-299a-41b8-8ddb-3c6f95ff1d2e


    - Codehal 로그인 웹페이지 튜토리얼

    <img src="https://raw.githubusercontent.com/RiverGang/basic-aspnet-2024/main/images/an0001.png" width="730" alt="Codehal 로그인창 따라하기">
        

    - Codehal 슬라이더 애니메이션 웹페이지 튜토리얼


    https://github.com/RiverGang/basic-aspnet-2024/assets/122778656/ad33d039-47e2-45d5-997d-765a9b3903ff




## 6일차
- 개인 웹페이지 제작 연습

- LunDev Responsive Image Slider WebPage


    https://github.com/RiverGang/basic-aspnet-2024/assets/122778656/e721cabb-f09a-4c60-b194-a5f9749cb164



## 1일차
- 웹기술 개요
    - 웹(Web) -> 요청과 응답 과정
    - World Wide Web != 인터넷, 인터넷의 한 파트
    - Full-Stack
        - Font-end: 웹사이트 화면으로 사람들에게 보이는 영역의 기술
        - Back-end: 웹사이트 뒤에서 동작하는 서버기술
        - Server-Operation: HW, OS, SW등 운영(클라우드)

    - 업무용 웹 사이트 참조
        - https://www.ecount.com/kr/ECK/ECK004M_CN.aspx

    
    - Front-end(클라이언트)
        - HTML
        - CSS
        - Javascript

    - Back-end(서버)
        1. Java - Spring, Spring Boot, JSP ...
        2. C# - ASP.NET
        3. Python -Django, Flask, fastAPI ...
        4. Ruby - Ruby on rails
        5. C - cgi, fasCGI
        6. Javascript - Node.js, Express ...
        7. PHP 

    
- 개발
    - 프론트엔드 전부 + 백엔드 여러개 중 하나 + DB
    - 웹 브라우저에서 F12(개발자도구)
    - VS Code 플러그인
        - Code Snippet
        - Live Server

- HTML5
    - XML: 웹페이지를 구성하기 위한 선행기술
    - 이를 간략화 시킨 것이 HTML(Hyper Text Markup Language)
    - 기본 확장자: .html

    - Tip!
        - lorem + Tab: 길이가 긴 텍스트 출력
    
    - 기본 태그(body)
        - h1~h6: 제목(마크다운 #, ##와 동일)
        - p: 일반문장
        - div: **그룹화 구분자**, CSS 연계 디자인에서 중요한 역할
        - img: 이미지 표현
        - br: 한줄 내리기(= 엔터)
        - hr: 가로선
        - 특수문자: & ;
        - strong or b: 굵게 (Bold)
        - em: 이탤릭체
        - mark: 형광펜 효과
        - u, strike: 밑줄, 취소선
        - small, sub, sup: 글자 작게, 아래첨자, 윗첨자
        - **a**: 웹페이지 링크
        - ul, ol > li : 순서없는 목록, 순번있는 목록
        - table, tr, th, td : 테이블 생성 태그
        - audio, video: 오디오, 비디오
        - object, embed: 객체 추가

    
    - HTML + CSS + Javascript
        - 내부 스타일, 외부 스타일, 인라인 스타일
        - 내부 스크립트, 외부 스크립트, 인라인 스크립트
    
    - 오류, 디버그
        - F12 개발자도구 활용

    - 양식 태그(body > form안에 사용 필수)
        - Front-end에서 입력한 내용을 Back-end로 보내기 위한 관문
        - form 을 반드시 사용
        - input
            - text: 텍스트 박스
            - password: 비밀번호 박스
            - button: 일반 버튼
            - submit: 제출(!)
            - checkboyx: 체크박스
            - raid: 라디오 버튼
            - file: 파일 업로드
            - image: 이미지(img와 유사)
            - reset: 폼내의 입력 양식태그 값 초기화
            - hidden: 숨김 값(유용하게 사용)
        - textarea: 여러행 텍스트 입력
        - select, option: 콤보박스
        - fieldset: 그룹박스
        - submit 클릭 -> loopback(값 전달) 발생
            - 값 전당 방법 
                - GET: URL뒤 ?다음에 ke=value&key ... 데이터 전달
                - POST: 화면 뒤로 숨겨서 데이터를 전달하는 방식

    - 공간구분 태그
        - div: 행간으로(=블록형식으로) 공간분할
        - span: 한줄로 공간구성인라인형식으로 공간분할

## 2일차
- HTML5
    - 시맨틱 웹: 시맨틱 태그로 화면 구조를 잡는 웹구성 방식
        - header, nav, footer, aside, section, article... 태그 사용

- CSS3
    - 웹 디자인 핵심, Cascading Style Sheets
        - 상단(<body>에서 부터)부터 하위 택들에 계속해서 적용되는 스타일이라는 뜻
        - 선택자에게 주어지는 디자인 속성
        - 선택자(selector)

    - 반응형 웹(Resopnsive Web)
        - 메타태그 viewport를 사용하면 그때부터 반응형 웹이 됨
        ```html
        <meta name='viewport' content='width=device-width, initial-scale=1'>
        ```
        - @media 태그: 디바이스 종류별로 CSS 따로 디자인가능
    
    - CSS 디자인 도움 웹사이트
        - (http://css3generator.com/)
        - (https://cssgenerator.org/)


## 3일차
- Javascript
    - 스크립트 언어, EMSScript
    - 웹 브라우저 주로 사용
    - 바닐라스크립트: 완벽하게 기본에 충실한 자바스크립트
    - 기본적으로 클라이언트(웹 브라우저에서 프론트엔드에 표시) 베이스
    - Node.js: 자바스크립트로 백엔드를 구현(파이썬과 유사)
    
    - 특징
        - 인터프리터 언어(not Compile Lang)
        - 속도가 컴파일 언어에 비해서 느림.
        - [중요!] HTML 태그와 연계(DOM)
        - 확장자 .js
            - VS Code도 자바스크립트로 만든 앱
        
        - 자료형 선언이 없음. var 변수 선언
        - let(일반/전역변수), var(지역변수), const(상수) 
        - 정수와 실수 구분 x
            - 0으로 나눠도 예외가 발생하지 않음
        - '(홑따옴표)와 "(쌍따옴표) 모두 사용
        - 문장 끝 ; (세미콜론) 생략가능, but 최대한 쓸 것
        - === : 완전히 동일함을 비교하는 연산자

        - [!기본키워드](https://raw.githubusercontent.com/RiverGang/basic-aspnet-2024/main/images/js001.png)

    - **DOM**(Document Object Model)
        - 실행 순서
        - HTML에 있는 모든 요소를 제어할 수 있음
        - html 애니메이션, 게임, 통신 모두 가능
        - 이벤트 on- 으로 시작
        - onload : 화면이 다 렌더링되면 그 다음 발생
        - onfocus : 객체에 마우스를 클릭해서 포커스가 가면 발생
        - onclick : 객체를 마우스로 클릭하면 발생
        - ondbclick : 더블클릭
        - onmousemove : 마우스를 이동하면 발생
        - onmouseover : 객체 위에 마우스가 올라가면 발생
        - onkeydown, onkeypress : 객체에서 키보드를 타이핑하면 발생
    
    - jQuery
        - 자바스크립트 라이브러리
        - js를 매우 편리하게 사용할 수 있도록 도와주는 서포트 라이브러리
        - 순식간에 웹개발 업계를 장악
        - 사용빈도가 줄고는 있지만 아직도 80% 웹사이트가 사용 중
        - js 파일 다운로드 후 사용하거나
        - CDN 링크를 사용하는방법(추천)

## 4일차
- HTML + CSS + js(jQuery) 응용
    - jQuery 응용
        - javascrpit와 jQuery를 혼용해도 상관없음
        - jQuery로 코딩이 편할 때와 javascript가 편한 상황이 다름

    - Bootstrap
        - 오픈소스 CSS 프레임워크
        - 트위터 블루프린트 -> 부트스트랩
        - 전세계에서 가장 각광받는 프레임워크 중 하나
        - CSS를 동작시키기 위해 Javascript도 포함
        
        - 사용법
            - (1) 소스 다운로드 받아 사용 -> 제한된 네트워크 환경 (금융, 방산 등)
            - (2) CDN 링크만 사용 -> 인터넷이 항상 연결된 네트워크 환경
            - [!다운로드](https://getbootstrap.com/)

        - 핵심
            - **Bootstrap은 화면 사이즈를 12등분**
                - 12를 넘어서면 디자인 깨짐 (bs02 참고)
            -  containter 및에 마치 table처럼 div를 구별해서사용
            - container > row > col div 태그 클래스 정의
        - 부트스트랩 학습에 시간을 들이는게 아니라 찾아쓰는 것. Copyleft가 정석
            - https://getbootstrap.com/docs/5.3/getting-started/introduction/ 참조
            - https://getbootstrap.com/docs/5.3/examples/ 스니펫 활용 추천
        - 무료 테마(템플릿)사이트 활용
            - Start Bootstrap (https://startbootstrap.com/?showPro=false)

        
    - 웹페이지 클로닝
        - 핀터레스트 타입 웹페이즈 만들기


## 8일차
- ASP.NET
    - 1990년대 MS가 웹 서버기술로 ASP(Active Server Page) 배포 (Like Jav aServer Page)
    - ASP는 .NET으로 된 언어가 아닌, VBScript를 사용
    - 확장자 .asp
    - 개발 난이도가 쉬워 많이 사용
    - 스파게티 코드
        - HTML + CSS + VBsript
        - 유지보수가 어렵고 성능이 나쁨

    - 웹퍼블리셔: HTML, CSS, Javascript만 가지고 웹페이지 개발
    - 프론트엔드 개발자: 웹퍼블리셔가 만든 웹페이지에 백엔드와 연계를 해서 실제 동작하는 페이지 개발

    - 2000년대 MS에서 .NET Framework 발표
    - C#, VB.NET C++.NET 등의 새로운 언어를 배포하며 여기에 맞춘 웹 서버 기술을 다시 만듦 => ASP.NET
    - 장점: 윈폼 개발하는 것 처럼 웹개발 가능
    - 초창기: 스파게티 코드 거의 그대로 사용. 좋지 않은 성능
    - 2009년 ASP.NET MVC(Model View Controller 디자인패턴)공표 -> 성능 상승
    - But, 윈도우에서만 동작

    - 2016년 .NET Core 출시
        - 모든 플랫폼 동작
        - 여기에 웹 서버기술을 또 다시 제작 -> ASP.NET Core
        - ASP.NET은 C#이 아닌 다른 .NET 언어로도 개발 가능. 그 중에서 C#을 사용
    - .NET Core(현재는 .NET 9.0, Core라는 이름은 사용안함)의 장점
        - 빠름, 오픈소스
        - **크로스 플랫폼**, OS 종속 X
        - 성능

    - ASP.NET 종류
        - Js(Vue, Angular, React) 프론트엔드 +  ASP.NET Core 백엔드
        - **ASP.NET Core 웹앱(MVC): 가장 기본적인 프론트엔드(HTML,CSS,JS .html) + 백엔드(C# .aspx.cs) 웹개발**
        - **ASP. NET Core 웹 API: 데이터포털, 네이버, 카카오, 영화API 사이트를 만드는 백엔드**
        - ASP.NET Core gRPC 서비스: 고성능 원격프로시저호출(스트리밍 호출) 서비스
        - Blazor: JS 프론트엔드를 따라서 C# 컴포넌트 기반으로 개발하는 웹개발 방식 웹사이트 개발
        - Razor: 프론트엔드 개발에 C# 코드가 특화되서 사용되는 웹사이트 개발방식
        - .NET Aspire: Blazor

    - 참조사이트
        -
        -
        -
        -

    - ASP.NET Core 웹앱(Model-View-Controller)
        - 현재 웹개발의 가장 표준
        - Java 계열도 Spring (Boot) MVC로 개발
        - MVC 개념도


        - 프론트엔드가 과거엔 스파게티 코드가 심했음
        - 현재는 스파게티코드 최소화 (SpringBoot, Python flask 등 모두 동일)
        - IIS Experss Server: VS에서 ASP.NET 웹사이트를 운영하는 개발용 웹서버
        - index.*: 웹사이트에서 가장 대표되는 페이지 이름
        - 파일 저장시 핫다시로드(HotReload) 체크
        - @로 시작하는 C#ㄱ문. Tag heler, HTML helper로 HTML구문 내에

    
    - 데이터베이스 연동방법
        - DB first: 가장 전통적인 DB 연동방식. DB설계, DB구축, C#과 연동
        - Code first: 최근 트렌드. C# 엔티티 클래스 작성, DB 연결 설정 후 실행하면 DB에 테이블 생성
        - EntityFramwork를 사용 시 손쉽게 구축가능

    - EntityFramework(Core) 설치
        - Microsoft.EntityFramewrokCore
        - Microsoft.EntityFramewrokCore.Tools
        - Microsoft.EntityFramewrokCore. 

    - Code first 구현순서
        - ASP.NET 프로젝트 생성
        - EF 패키지 설치
        - 엔티티 클래스 작성
        - appsettings.json에 DB연결문자열 추가
        - Data/ApplicationDBContext.cs 중간연결 클래스 생성

    - 브라우저 실행 시 NET::ERR_CERT_INVALID 연결 비공개 설정이 안되 화면이 안나타는 경우
        - 브라우저 화면 클릭, thisisunsafe 입력

## 9일차 (07.16)
- ASP.NET Core MVC
    -  MVC
        - Model은 개발자가 따로 만듦
        - View, Controller 폴더는 미리 만들어짐
        - 웹브라우저에서 접근할 페이지를 만들려면
            1. 해당 컨트롤러를 생성
            2. 뷰를 같이 생성할지 나중에 따라 만들지 선택
            3. 컨트롤러 이름과 동일한 뷰 폴더, 메서드 이름과 동일한 cshtml 페이지가 생성
            4. 컨트롤에 모델에 DB와 연결될 내용을 작성
            5. 모델 내용을 뷰로 리턴

- ASP.NET Core 포트폴리오 웹사이트, Myfortfolio
    1. Visual Studio에서 ASP.NET Core 웹앱(MVC) 프로젝트 생성
    2. 부트스트랩 템플릿 사이트에서 알맞은 템플릿을 다운로드
    3. wwwroot 폴더 아래 템플릿 html,css,js 이미지 등 위치
    4. 템플릿 페이지에 공통적인 부분(Header, Bottom)은 __layout.cshtml 에 위치
    5. 중간에 페이지마다 변경되는 부분은 각 Views 밑에 포함
    6. _layout.cshtml에 (View 아래 Shard 폴더 속) 공통부분 옮기기
    7. index.cshtml에 index.html에서 공통부분 외 영역 옮기기
    8. index.cshtml 내용 수정

    9. ResumeControlloer.cs 생성, 뷰를 같이 생성 (페이지 만들기)
        - DB 관련된 설정이 없으면, 모델과 뷰를 만들기 어려움 -> 직접 작업해야함('MVC 컨트롤러 비어있음'을 추가)
        - Controllers 폴더에 ResumeController.cs 생성 -> 이후 Views 폴더 아래 Resume 폴더 추가 -> Resume 폴더에 index.cshtml (= 뷰) 추가
        - resume.html (템플리소스)에서 네비게이션 아래 변경부분만 복사해 Resume의 index.cshtml에 내용 붙여넣기

    10. Code First 방식으로 Board테이블(DB) 생성
        - NuGet 패키지 검색 및 설치(필수)
            - Microsoft.EntityFrameworkCore
            - Microsoft.EntityFrameworkCore.Tools
            - Microsoft.EntityFrameworkCore.SqlServer

        - model/Boadr.cs로 엔티티 클래스 생성
        - appsettings.json에 DB 연결문자열 추가
        - Data 폴더 생성, AppDbcontext.cs 클래스 추가, DbContext 상속받기
        - Program.cs 위치에 DbContext 종속성 주입
            ```csharp
            // DbContext 종속성 주입
            builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(
            builder.Configuration.GetConnectionString("MyConnection") // appsettings.json에서 정의한 이름
            )); 
            ```

        - NuGet패키지 관리자 콘솔 > Add-Migration, Update-Database진행 (이 과정을 해줘야 mssql 데이터서버에 테이블이 생성됨)
        - _layout.cshtml Board 링크 수정
        - /Controller/BoardController.cs를 생성(모델, 뷰 연결)
            - Entity Framework를 사용하며 뷰가 포함된 MVC 컨트롤러

            <img src="https://raw.githubusercontent.com/RiverGang/basic-aspnet-2024/main/images/an0004.png" width="500">


## 10일차
- ASP.NET Core 포트폴리오 웹사이트, MyPortfoilo
    1. Board.cs 멤버속성 ModDate로 이름 변경
        - BoardController.cs에서 ModeDate -> ModData로 변경
        - View/Board/*.cshtml ModeData -> ModData로 변경
    2. ASP.NET Core 템플릿으로 만들어주는 CRUD(Insert, Select, Update, Delete)    
    3. 테이블 삭제, 재생성
    4. 게시판 관련된 화면 수정작업
        - Views/board/index.cshtml 게시판 리스트화면 수정
        - Index.cshtml 테이블 틀 변경, 삭제, 수정, 삭제버튼 삭제
        - Models/Board.cs에 테이블 한글이름 추가 DisplayName() 이용

        - Views/Board/Details.cshtml 부트스트랩 적용
        - 수정/ 삭제 등 버큰 디자인 적용
        - Views/board/Create.cshtml 부트스트랩 적용
    
    5. SSMS에서 Board테이블 Hit, RegDate, ModDate Null허용으로 변경

    6. 웹사이트 동작 순서
        1. https://localhost:7154/Board/Create 링크 오픈
        2. BoardControlloer -> Create 액션메서드
        3. Submit -> BoardControoler -> Create 액션메서드 발동
        4. Create 액션 메서드 내 로직처리 DB에 데이터 입력
        5. Models/Board.cs ModeDate를 DateTime -> DateTime? 변경 (널 입력 가능하도록)
        6. Edit 동일, Create.cshtml 내용을 그대로 복사/붙여넣기 단, asp-action="Edit"로 변경
    
## 11일차
- Postman 설치 APi 테스트 Tool
- ASP.NET Core 포트폴리오 웹사이트, MyPortfolio
    1. EntityFramework로 SQL 사용없이 DB 핸들링
        - DbContext.Add(삽입), Update(수정), Remove(삭제), 기능 존재
        - 위의 명령을 실행 후 DbContext.SaveChangesAsync() 실행해서 실제 DB에 반영
        - ToListAsync(), FirstOrDefaultAsync()는 SELECT로 트랜잭션이 발생하지 않음. 따라서 SaveChangesAsync()를 실행 X
    2. [x]글 조회수 올리기 
    3. [x]게시글 삭제
        - _layout.cshtml의 @await RenderSectionAsync("Scripts", required: false) => 각 페이지에 필요시(=비동기) 스크립트영역을 만들어써라는 의미
- ASP.NET Core 포트폴리오 웹사이트, MyPortfolio
        - []AJAX 삭제는 나중에 다시 구현
    4. **페이징**
        - 웹사이트에서 가장 중요한 기능 중 하나
        - 한 페이지에 표시할 수 있는 글의 수를 제한
        - 스크롤 페이징/번호 페이징
        
        - 번호 페이징 구현
            1. BoardControoler.cs Index() 액션메서드 내 FromSql()로 변경 (비동기 적용은 페이징이 어려움, 비동기 제거)
            2. 페이징용 쿼리 작성
            
                ```sql
                SELECT *
                    FROM (
                            SELECT ROW_NUMBER() OVER (ORDER BY Id DESC) AS rowNum
                                , Id
                                , Name
                                , UserId
                                , Title
                                , Contents
                                , Hit
                                , RegDate
                                , ModDate
                            FROM Board
                            ) AS base
                    WHERE base.rowNum BETWEEN 1 AND 10 -- 1과 10에 각각 10을 더하면 다음 페이지를 조회하게 됨
                ```
            3. Index() 내 로직 수정
            4. Views/Board/Index.cshtml 화면코드 수정
            
    5. 검색
        - FromSQlRaw() 메서드 변경
        - html 링크에 ?page=1&search 검색어 추가
    
    6. HTML에디터
        -  Markdwon 에디터
        - simplemde(https://simplemde.com)
        - _layout.chstml에 js, css 링크만 추가

            ```html
            <!-- SimpleMDE css -->
            <link rel="stylesheet" href="https://cdn.jsdelivr.net/simplemde/latest/simplemde.min.css">

            <!-- SimpleMDE js CDN -->
            <script src="https://cdn.jsdelivr.net/simplemde/latest/simplemde.min.js"></script>
            ```
        - 실제 사용페이지에서 특정 js만 실행
        - Create.cshtml, Edit.cshtml은 동일하게 작업
        - NuGet패키지 Westwind.AspNetCore.Markdown 검색

        

## 12일차
- ASP.NET Core 포트폴리오 웹사이트, MyPortfolio
    1. 삭제로직 수정
    2. 회원가입, 로그인, 권한 ...
        1. /Models/User.cs 클래스 생성
        2. User클래스와 Board 클래스 간 관계형성 (virtual)
        3. AppDbContext.cs에 User DBset 추가
        4. Add-Migration, Update-Database 실행 -> DB 생성
        5. Program.cs에 로그인 세션 설정
        6. _layout.cshtml 로그인/로그아웃 메뉴 추가
        7. HomeController.cs Login/Logout 액션메서드 작성
        8. bootstrap 사이트에서 예제 파일 다운로드
        9. sing-in 폴더 내 index.html, sign-in.css Static 경로(wwwroot) 복사
        10. Login.cshtml을 위의 파일 참조해서 수정
        11. HomeController.cs에 Register()액션메서드 작성
        13. Register.cshtml 회원가입 페이지 생성

## 13일차
- ASP.NET Core 포트폴리오 웹사이트, MyPortfolio
    1. 회원가입 이어서 ...
        1. Register.cshtml에 asp-for등 C# Razor tag로 변경
        2. HomeController.cs Register Post 메서드 작성
        3. Login.cshtml에 C# Razor tag로 변경
        4. HomeController.cs Login Post 메서드 작성
        5. Logout Get메서드 추가
    2. 게시판 글 오류 수정
        1. Board.cs에 있는 Name, UserID를 삭제
        2. BoardController.cs 있는 Board 클래스와 관련된 변수도 삭제
        3. View/Board/*.cshtml Name, UserID를 삭제/변경
        4. BoardController.
    3. 프로젝트 파일 업로드
        1. Project.cs 모델 생성
        2. AppDbContext.cs에 DbSet<Project> 추가
        3. Add-Migration, Update-Database
        4. ProjectController, View 생성
        5. Views/Project/Create.cshtml 수정
        6. ProjectController, Create Post 메서드 수정

## 14일차
- ASP.NET Core 포트폴리오 웹사이트, MyPortfolio
    1. AWS LightSail로 윈도우서버 인스턴스 만들기
        1. 구글 ASW 라이트세일 검색
        2. AWS 프리티어 회원가입
        3. AWS 라이트세일 / 루트 사용자 로그인
        4. 인스턴스 생성 (인스터스 위치(Region) 확인), ap-northeast-2a
            - Linux/Unix는 라즈비안과 거의 동일
            - MS Windows OS 전용 -> Windows Server 2016 선택
            - Size -> 무료 중 가장 좋은 성능 선택
            - 인스턴스 확인 이름(Identify your instance) 변경
            - 인스턴스 생성 클릭
        5. 인스턴스 관리
            - 관리로 진입
            - 네트워킹 탭 > 고정 IP 연결 클릭
            - Connect 탭 > 자신의 고정 IP, Administrator, 비밀번호(Retrieve default password) 확인
        6. 원격 데스크톱 연결
            - Windows 검색창 -> 원격 데스크톱
                - 주소: 고정 IP
                - 사용자: Administrator
                - 비밀번호: 비밀번호 입력 (기억 체크박스 True)
            - 원격 데스크톱 연결 후 NetWork2 항목 Yes 클릭
            - 원격 데스크톱에서 Server Manager 프로그램 열기
                - Local Server 탭 > IE Enhanced Security Configuration > OFF로 변경
                - 인터넷 익스플로러에서 크롬 브라우저 설치
                - FileZilla 검색 및 Server 설치

        7. 파일질라 서버 설정
            - 메뉴 > Configure 클릭
            - FTP and FTP over TLS(FTPS)의 Connection Security 탭 하단 Distinguished name 복사
                - Generate New 클릭 >  Distinguished nmae에 붙여넣기 + Hostnames에도 입력
                - Passive mode 탭 (Port 변경 기능)
                    - 사용
                    - From : 55000
                    - To : 55999
            - Users > 새로운 유저 생성
                - Authentication > Require a password to log in
                    - 비밀번호 입력 후 Apply
                - Mount points
                    - Virtual path : /
                    - Native path : 본인 지정 (폴더 경로 넣기)
        
        8. 윈도우 방화벽 설정
            - Control Panel(제어판) > Windows Firewall > Adanced Security

        9. AWS 방화벽 설정
        
        11. 사용 PC에서 파일질라 클라이언트 설치
            - 기본 설치
            - 사이트 관리자
                - 새 사이트 생성
                - 호스트: AWS public ip 
                - 사용자, 비번: Filezilla server 설정한 사용자 계정

        12. Visual Studio ASP.NET Core 게시
            - 프로젝트 > 마우스 우클릭 > 게시
            - FTP/FTPS 서버 선택 > 다음
                - 서버: aws public ip
                - 사이트 경로: /
                - 수동모드 True
                - 사용자 이름 및 패스워드 입력, 암호저장 True
                - 연결 유효성 검사 클릭 > 녹색체크가 뜨면 성공
                - 게시
        
        13. SQL Server Developer 다운로드
            - 윈도우 서버 패스워드 정책 변경
                - 기본: 8문자 이상, 특수문자 1자 이상, 영어대소문자 ...
                - 윈도우 + R키 -> secpol.msc
                - Account Policies > Password Policy > Password must meet com~ > Disabled 


            - Media 선택 > Default 값으로 다운로드 
            - SQLServer2022-x64-ENU-Dev 마우스 우클릭 > Mount > setup
            - Installation - New SQL Server standalon installation ... 클릭
            - 윈도우 방화벽, AWS 방화벽 1433포트 오픈
            - SSMS 접속 확인

        14. IIS(Internet )
            - 기본 선택
            - Select server roles > Roles > Web Server (IIS) 선택 > 기본 설정들도 설치
        
        15. SQL Server 복제
            - SSMS 로컬 DB 접속
            - 서버 종료
            - EMS.mdf, EMS_log.ldf 복사
            - FTP로 서버에 전송
            - 서버 컴퓨터에서 전송받은 파일 확인
                - C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA 에 복제할 테이블파일 추가

        16. IIS 서버에서 ASP.NET 실행
            - 제어판 열기 > Administration Tools > Internet Information Services (IIS) Manager 열기
                - Default Web > Basic Setting 사이트 경로 변경
                - C:\Websitex\MyPorfolio
                    - MyPortfolio 폴더 마우스 우클릭 > Propeties Security 탭 > Advanced > Add > Select a principal > Advanced > Find Now > IIS_IUSRS 추가

            - 구글에서 ASP.NET 코어 Runtime 검색 후
                - aspnetcore-runtime-8.0.7-win-x64 다운로드
                - dotnet-hosting-8.0.7-win 다운로드
            
            - IIS > Application Pool
                - ASPNETCore 애플리케이션 풀 생성
                - .NET CLR version: No Managed Code 선택
                - IIS 재시작

        17. 다음부터는
            - Visual Studio 개발
            - Visual Studio 게시
            - DB가 변경 되었으면, mdf, ldf를 FTP로 업로드
            - SQL 서버 중지, 파일 이동, SQL 서버 재시작
             