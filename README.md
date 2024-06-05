# basic-aspnet-2024
부경대학교 2024 IoT 개발자 과정 ASP.NET 리포지토리

## 1일차(24.05.29)
- 웹 기술 개요
    - World Wide Web 은 인터넷이 아닌 인터넷의 한 파트(부분 집합)이다.
    - Full-Stack : Front-end, Back-end, Server-Operation 이 세가지를 한번에 하는 것
        - Front-end : 웹사이트 화면으로 사람들에게 가시적으로 보이는 부분
        - Back-end : 웹사이트 뒤에서 동작하는 서버기술
        - Server-Operation : HW, OS, SW 등 운영기술(클라우드 활용)

- 업무용 웹 사이트 참조
    - https://www.ecount.com/kr/ECK/ECK004M_CN.aspx

- Front-end(Client:요청하는 쪽) 프로그램
    - HTML
    - CSS3
    - Javascript

- Back-end(Server) 프로그램
    1. Java - Spring, Spring Boot, JSP, EJB ...
    2. Javascript - Node.js, Express ...
    3. Python - Django, Flask, fastAPI, ...
    4. C# - ASP.NET MVC, Boilerplate
    5. Ruby - Ruby on rails
    6. C- Cgi, fastCGI ...
    7. PHP

- 개발
    - 프론트엔드 전부 + 백엔드 여러개 중 하나 + DB
    - 웹 브라우저에서 F12 (개발자도구)
    - Visual Studio Code에 플러그인 설치
        - HTML Code Snippet : Angular 8 and TypeScript/HTML VS Code Snippets
        - Live Server
    - Tip! lorem + Tab => 긴 샘플 텍스트 생성

- HTML5
    - XML(eXtensible Markup Lang)이 웨페이지를 구성하기 위한 선행기술, 너무 복잡해서 간략화 시킨 것
    - Hyper Text MArkup Lanuage
    - 기본적인 확장자 .html

    - 주요 기능
        - 통신 기능
        - 장치 접근
        - 오프라인 및 저장소
        - 시맨틱
        - CSS3 스타일시트
        - 웹의 성능 극대화 및 통합

    - 기본 용어
        - 요소 : HTML 페이지를 구성하는 각 부품(제목, 본문, 이미지 등)
            - 내용을 가질 수 있는 요소 : <요소 이름>내용 </요소 이름>
            - 내용을 가질 수 없는 요소 : <요소 이름>
        - 태그 : 요소를 만들 때 사용하는 작성방법

    - 기본 태그 : body에 사용
        - h1 ~ h6 : 제목(마크다운 #, ##와 동일)
        - p : 일반 문장
        - div, span : 그룹화 구분자, 매우 중요(CSS 연계 디자인)
        - img : 이미지 표현
        - br : 한줄내리기(엔터)
        - hr : 가로선
        - small, sub, sup : 글자 작게, 아래첨자, 위첨자
        - 특수문자는 : &와 ;사이에 영문자로 표시(종류가 많음)
        - strong 또는 b : bold체
        - em : 이탤릭체
        - mark : 형광펜 효과
        - u : 밑줄
        - strike : 취소선
        - a : 웹페이지 링크(중요!!)
        - ul, ol > li: 순서 없는 목록, 순번 있는 목록
        - table, tr, th, td : 테이블을 만드는 태그
        - audio, video : 오디오, 비디오를 추가하는 태그
        - object, embed : 객체 추가

    - HTML + CSS + Javascripy
        - 내부 스타일, 외부 스타일추가, 인라인 스크립트
        - 내부 스크립트, 외부 스크립트, 인라인 스크립트
    
    - 오류, 디버그
        - F12 개발자 도구

    - 양식 태그 : body 내의 form 안에 사용 필수
        - front-end에서 입력한 내용이 back-end로 보내기 위해 반드시 필요한 관문
        - form : 영역 생성(반드시 사용)
        - input
            - type="text" : 텍스트 박스
            - type="password" : 비밀번호 박스
            - type='button' : 일반 버튼
            - type='submit' : 제출(!)
            - checkbox : 체크박스
            - radio : 라디오버튼
            - file : 파일 업로드
            - image : img태그와 유사
            - reset : 폼내의 입력양식 태그들이 초기화 됨
            - hidden : 숨김값. 값을 숨겨서 쓰는 것(유용하게 사용!)
        - textarea : 여러행 글자를 입력하는 창
        - select : 콤보박스
        - fieldset : 그룹박스
        - submit을 클릭하면 loopback이 발생(일반적인 새로고침이 아닌 입력된 값을 전달하는 역할)
            - GET 방식 : URL뒤 ?다음에 **key=value** 형식으로 데이터를 전달
            - POST 방식 : 화면 뒤로 숨겨서 데이터 전달하는 방식

    - 공간 구분 태그
        - span : 인라인 형식으로 공간 분할(화면 전체의 너비를 다 차지함)
        - div : 블록 형식으로 공간 분할


## 2일차(24.05.30)
- HTML5
    - 시맨틱 웹 : 시멘틱 태그로 화면 구조를 잡는 웹구성방식
        - header, nav, footer, aside, section, article... 구조태그(화면에 안나타남) 사용
        - 시맨틱 태그를 div로 바꿔도 똑같이 동작하기 떄문에 요새는 많이 사용하지 않음. 걷어내고 있는 추세

- CSS3
    - 웹 디자인 핵심, Cascading Style Sheets
    - 상단에서부터 <body>부터 하위에 태그들에 계속해서 적용되는 스타일
    - 선택자에게 주어지는 디자인 속성
    - 배경, 폰트 ...
    - 레이아웃
        - html만으로는 화면 레이아웃이 만들어지지 않음 css 사용 필수!
        - 중앙정렬, 원트루, 고정바

    - 선택자(Selector) : CSS에서 특정  HTML을 선택할 때 사용
        - id 선택자 : 한번에 한개의 태그에만 사용가능
        ```html
        <style>
            #header {
                width: 600px;
                /* auto : 정중앙에 위치함*/
                margin: 0 auto;
                background-color: chocolate;
            }
        </style>
        ```

        - 클래스 선택자 : 한번에 여러 태그에 사용가능 
        ```html
        <style>
            .favorite{
            color: coral;
            }
            .options{
                background-color: black;
            }
        </style>
        ```

        - 속성 선택자 : input 같은 태그의 type에 따라 지정 가능
        ```html
        <style>
            input[type="text"]{ background-color: yellow;}
            input[type="password"]{ background-color: yellowgreen;}
            input[type="submit"]{ background-color: darkblue; color:white;}
        </style>
        ```

        - 후손 선택자 : 모든 아래 단계의 태그
        ```html
        <style>
             #header #nav {color: darksalmon;}
        </style>
        ```

        - 자손 선택자 : 바로 아래 단계의 태그만
        ```html
        <style>
            #section > div { font-style: italic;}
        </style>
        ```

        - 반응 선택자 
        ```html
        <style>
            h1:hover {color:yellow;} /* 마우스를 올릴 경우 */
            h1:active { color:black;} /* 클릭할 경우 */
        </style>
        ```

        - 상태 선택자
        ```html
        <style>
            input:disabled { background-color: gray;}
        </style>
        ```

        - 구조선택자
        ```html
        <style>
        .second-nav li:first-child{     // 첫번째 자식만
            border-radius: 10px 0 0 10px;
        }
        .second-nav li:last-child{      // 마지막 자식만
            border-radius: 0 10px 10px 0;
        }
        .second-nav li:nth-child(2n+1){ // 홀수번째 자식만
            background-color: #e9e784;
        }        
        .second-nav li:nth-child(2n){   // 짝수번째 자식만
            background-color: #d86262;
        }
        </style>
        ```

    - 반응형 웹(Responsive Web)
        - 웹 페이지 하나로도 데스크톱, 태블릿PC, 스마트폰에 맞게 디자인이 자동으로 반응해서 변경되는 웹 페이지
        - 장점 : 개발 효율성, 유지 보수 용이
        - 미디어 쿼리(medai query)를 사용해 개발
        - 메타태그 viewport를 사용하면 그때부터 반응형 웹이 됨!!
        ```html
        <meta name='viewport' content='width=device-width, initial-scale=1'>
        ```

    - 속성(Property)
        - 박스 속성
            - margin 속성 : 테두리와 다른 태그 사이의 테두리 바깥쪽 여백
            - border 속성 : 테두리
            - padding 속성 : 테두리와 글자 사이의 테두리 안쪽 여백 
            - width 속성 : 글자를 감싸는 영역의 가로 크기
            - height 속성 : 글자를 감싸는 영역의 세로 크기

## 3일차(24.05.31)
- Javascript
    - 스크립트 언어, ECMA 스크립트
    - 웹 브라우저에서 주로 사용
    - 바닐라 스크립트 : 완벽하게 기본에 충실한 자바스크립트
    - 기본적으로 클라이언트(웹 브라우저에서 프론트엔드에 표시) 베이스
    - Node.js : 자바스크립트로 백엔드를 구현(파이썬과 유사)
    - 특징
        - 자유형 선언이 없음(var를 쓰면 변수선언, C/C++,C#의 int, float, char같은 자료형이 없음)
        - 인터프리터 언어(not Complie Lang)
        - 확장자가 .js
        - 속도가 컴파일 언어에 비해서 느림.
        - VS Code도 자바스크립트로 만든 앱
        - HTML 태그와 연계(DOM) 중요!

    - 기본용어
        - 표현식 : 값을 만들어내는 간단한 코드
        - 문장 : 프로그래밍 언어에 실행할 수 있는 코드의 최소 단위
        - 종결 : 문장 마지막에 세미콜론(;) 혹은 줄 바꿈
        - 키워드 : 자바스크립트를 처음 만들 때 정해진 특별한 의미가 부여된 단어
        - 식별자 : 자바스크립트에서 변수나 함수 등에 이름을 붙일 때 사용하는 단어
            - 키워드 사용 불가
            - 특수문자는 _와 $만 허용
            - 숫자로 시작하면 안됨
            - 공백 입력 불가

    - 자료형 
        - 숫자 : 가장 기본적인 자료형, 정수와 실수 구분하지 않음, 0으로 나누어도 예외가 발생하지 않음 
        - 문자열 : 파이썬과 동일하게 '와 " 모두 사용
        - 불(bool) : 참과 거짓
        - 비교연산자 : === -> 완전히 동일함을 비교
        - 논리연산자
        - 변수선언시 let(일반), var(지역변수), const(상수)

    - 함수
        - 코드 집합을 나타내는 자료형
        - 익명 함수 생성 : 함수 이름을 입력하지 않고 만들기
        ```js
        let fn1 = function() {
            console.log('함수 fn1을 실행!');
            console.log('함수 종료!!')
        }
        ```

        - 선언적 함수 생성 : 함수 이름을 입력해서 만들기
        ```js
        function fn2() {
            console.log('함수 fn2을 실행!');
            console.log('함수 종료!!')
        }
        ```

        - **익명함수가 선언적 함수보다 우선순위가 높음**

    - DOM(Document Object Model : 문서객체)
        - 특징
            - 문서객체 : 태그를 자바스크립트에서 사용할 수 있는 객체로 만든 것
            - 문서 객체를 조작한다 == 태그를 조작한다
            - HTML 모든 요소를 제어 가능 (애니메이션, 게임, 통신...)

        - 기본 용어
            - 요소 노드 : "<h1> 처럼 요소를 생성하는 노드
            - 텍스트 노드 : 화면에 출력되는 문자열
            - 정적 생성 : 웹 페이지를 처음 실행할 때 HTML 태그로 적힌 문서 객체를 생성하는 것
            - 동적 생성 : 웹 페이지를 실행중에 자바스크립트를 사용해 문서 객체를 사용하는 것
            - 문서 객체 모델 : 웹 브라우저가 HTML 파일을 분석하고 출력하는 방식

        - 문서 객체 선택
            - 1개 선택
                - document.getElementById(아이디)
                - document.getElementBySelector(선택자)
            - 여러 개 선택
                - document.getElementsByName(이름) : name 속성으로 여러 개 선택
                - document.getElementsByClassName(클래스) : class 속성으로 여러 개 선택
                - document.querySelectorAll(선택자) : 선택자로 여러개 선택

        - 이벤트 : on-으로 시작
            - onload : 화면이 다 랜더링되면 그 다음 발생
            - onfocus : 객체에 마우스를 클릭해서 포커스가 가면 발생
            - onclick : 객체를 마우스로 클릭하면 발생
            - ondbclick : 더블클릭
            - onmousemove : 마우스를 이동하면 발생
            - onmouseover : 객체 위에 마우스가 올라가면 발생'
            - onkeydown, onkeypress : 객체에서 키보드를 타이핑하면 발생
            - etc...

        - JQuery
            - 자바스크립트 라이브러리
            - js를 매우 편리하게 사용할 수 있도록 도와주는 서포트 라이브러리
            - 순식간에 웹 개발 업계를 장악했던 라이브러리
            - 사용빈도가 줄고는 있지만 아직도 80%의 웹사이트가 사용중
            - js 파일 다운로드 후 사용하거나
            - CDN 링크를 사용하는 방법(추천)

## 4일차(24.06.03)
- HTML + CSS + js(Query) 응용
    - jQuery 응용
        - javascript와 jQuery를 혼용해도 상관없음
        - jQuery로 코딩이 편할 때와 javascript가 편할 때도 있음

    - Bootstrap
        - https://getbootstrap.com/
        - https://inpa.tistory.com/entry/BOOTSTRAP-%F0%9F%93%9A-%EB%B6%80%ED%8A%B8%EC%8A%A4%ED%8A%B8%EB%9E%A9-v5-%EB%93%80%ED%86%A0%EB%A6%AC%EC%96%BC
        - 오픈소스 CSS 프레임워크
        - 트위터 블루프린트 -> 부트스트랩
        - 현재 전세계에서 가장 각광받는 프레임워크 중 하나
        - CSS를 동작시키기 위해서는 Javascript도 포함
        - 소스 다운받아서 사용 or CDN으로 링크만 사용(2) => 2번이 훨씬 편리
            - 제한된 네트워크 환경에서는 1번
            - 인터넷에 항상 연결된 환경에서는 2번이 편리

        ```html
        <!-- <head>에 붙여넣기 -->
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" 
        integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
        <!-- <body>에 붙여넣기 -->
        <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" 
        integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" 
        integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
        ```

        - 핵심!
            - BootStrap은 화면 사이즈를 12등분함(그 이상은 불가능!)
            - container 및에 마치 table처럼 div를 구분해서 사용
            - container > row > col div 태그 클래스 정의
            
        ```html
            <div class="container text-center">
                <div class="row">
                    <div class="col cgrid">
                        Grid1
                    </div>
                    <div class="col cgrid">
                        Grid2
                    </div>
                    <div class="col cgrid">
                        Grid3
                    </div>
                </div>
            </div>
        ```

        - 부트스트랩 학습에 시간을 들이는게 아님. Copyleft가 정석!
            - https://getbootstrap.com/docs/5.3/getting-started/introduction/ 참조
            - https://getbootstrap.com/docs/5.3/examples/ Snippets 활용을 추천

        - 무료 테마(템플릿)가 아주 잘되어 있음
            - https://startbootstrap.com/

    - 웹페이지 클로닝
        - Pinterest 타입 웬페이지 만들기(현재 진행중)
            - Masonry layout
                - Pinterest 타입의 이미지 정렬 레이아웃
                - https://unpkg.com/masonry-layout@4.2.2/dist/masonry.pkgd.min.js
            - imageLoaded
                - Masonry Layout을 적용하기 위해 필요한 라이브러리
                - https://unpkg.com/imagesloaded@5/imagesloaded.pkgd.min.js

## 5일차(24.06.04)
- HTML + CSS + js(jQuery) 응용
    - 웹페이지 클로닝
        - 핀터레스트 타입 + 부트스트랩 웹페이지 만들기
            - 부트스트랩 아이콘 적용을 위해 필요한 CDN

            ```html
            <head>
                <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
            </head>
            ```

        https://github.com/YooWangGwon/basic-aspnet-2024/assets/158007390/089eda4a-10d4-49ce-bd72-110546cb484a

        - Codehel 유튜버 로그인 웹페이지 듀토리얼 따라하기
            - Google Fonts 중 Ubuntu 폰트 활용

            ```html
            <style>
                @import url("https://fonts.googleapis.com/css2?family=Ubuntu:ital,wght@0,300;0,400;0,500;0,700;1,300;1,400;1,500;1,700&display=swap"); 
            </style>
            ```

            - Boxicons 사용
            ```html
            <head>
                <link href='https://unpkg.com/boxicons@2.1.4/css/boxicons.min.css' rel='stylesheet'>
            </head>
            ```


        <img src="https://raw.githubusercontent.com/YooWangGwon/basic-aspnet-2024/main/images/asp002.png" width="730" alt="Codehal 로그인창 따라하기">

        - Codehal 유튜버 슬라이더 애니메이션 웹페이지 듀토리얼 따라하기(진행중)

## 6일차(24.06.05)
- HTML + CSS + js(jQuery) 응용
    - 웹페이지 클로닝
        - Codehal 유튜버 슬라이더 애니메이션 웹페이지 듀토리얼 따라하기(완료)

            - 작동화면
