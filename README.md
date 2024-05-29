# basic-aspnet-2024
IoT 개발자과정 ASP.NET  리포지토리

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
    - 시맨틱 태그

- CSS3
    - 웹 디자인 핵심

- Javascript