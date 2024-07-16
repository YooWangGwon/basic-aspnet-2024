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

- 웹 개발
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
      
            https://github.com/YooWangGwon/basic-aspnet-2024/assets/158007390/580e6ea7-7701-4b09-b3fa-3050af1799c8

    - 개인 웹페이지 클로닝
        - Codehal Login&Register Page 듀토리얼 따라하기(완료)
            - 배경화면 : Image by pikisuperstar on Freepik
            - css, javascript 분할
            - 실행화면
      
            https://github.com/YooWangGwon/basic-aspnet-2024/assets/158007390/54509945-1e31-4528-92a5-15fac9454df4

        - Parallax Webpage 듀토리얼 따라하기(완료)
            - 실행화면
              
              https://github.com/YooWangGwon/basic-aspnet-2024/assets/158007390/a05bc8c6-013e-4966-af97-fa92f649b654

        - ContactForm 듀토리얼 따라하기(진행중)

## 7일차(24.06.07)
- HTML + CSS + js(jQuery) 응용
    - 개인 웹페이지 클로닝
        - True Coder ContactForm 듀토리얼 따라하기(완료)
            - 실행화면
         
            https://github.com/YooWangGwon/basic-aspnet-2024/assets/158007390/eca2fe84-1108-4d6c-ae4d-c0699d73c2dd

        - True Coder 3d Parallax Website 
            - GSAP : https://gsap.com/docs/v3/Installation?tab=cdn&module=esm&method=private+registry&tier=free&club=false&require=false&trial=true
            - 실행화면
        

## 8일차(24.06.10)
- ASP.NET
    - 웹퍼블리시 : HTML, CSS, JavaScript만 가지고 웹페이지만 개발(디자인)
    - 프론트엔드 개발자 - 웹 퍼블리시가 만든 웹 페이지에 백엔드와 연계를 해서 실제 동작하는 페이지 개발(개발자)
        - json, 백엔드, DB에 대한 전반적인 지식 필요
        
    - ASP.NET의 역사
        - 1990년대 MS가 웹 서버기술로 ASP(Active Server Page)를 배포. like JSP(Java Server Page)
        - ASP는 .NET으로 된 언어가 아닌, VSB(Visual Basic)Script를 사용(파일 확장자명:.asp)
        - 스파게티 코드 -> HTML + CSS + JavaScript + VBScript를 섞어 만든 웹 페이지 
            - 프론트엔드 + 백엔드 소스가 한군데에 같이 있음
            - 다만, 현재 프론트엔드도 백엔드 소스가 일부는 포함디ㅓ
        - 많이 사용되었지만 유지보수가 어렵고, 성능이 좋지 않음

        - 2000년대 MS가 .NET Framework 발표.
        - C#, VB.NET, C++.NET 등의 새로운 언어를 배포, 여기에 맞춰서 웹 서버기술을 다시 만듬 -> ASP.NET
        - 초창기에 스파게티 코드를 거의 그대로 사용, 성능이 나쁨
        - winform을 개발하는 것 처럼 웹 개발 가능(ASP.NET Webforms, 가장 큰 장점!!)
        - 2009년 ASP.NET MVC(Model View Controller 디자인패턴) 공표, 성능은 좋아짐.
        - 하지만, 위도우에서만 동작
        - 2016년 모든 OS 플랫폼에서 동작할 수 있는 .NET Core를 재출시 
        - 웹서버 기술을 또 다시 만듦(ASP.NET Core)
        - ASP.NET은 C#이 아닌 다른 .NET 언어로도 개발 가능

    - .NET Core(현재는 .NET 9.0, Core라는 이름은 사용안함)의 장점
        - 빠르고 오픈소스
        - **크로스 플랫폼**, OS에 종속받지 않음
        - 성능!

    - ASP.NET Core 종류
        - ASP.NET Webforms - 2000년도 초반에 나오다가 사장된 웹사이트 개발 기술
        - JS(Vue, Angular, React) 프론트엔드 + ASP.NET Core로 서버를 백엔드
        - **ASP.NET Core 웹앱(MVC) - 가장 기본적인 프론트엔드(HTML,CSS,JS .html) + 백엔드(C#, .aspx.cs) 웹사이트 개발**
        - **ASP.NET Core 웹 API - 데이터포털, 네이버, 카카오, 영화 API 사이트를 만드는 백엔드(프론트엔드가 없어서 화면이 없음)**
        - ~~Edge용 웹 드라이버 테스트 - Edge 브라우저에 종속된 테스트용~~
        - ASP.NET Core gRPC 서비스 - 고성능 원격프로시져 호출(스트리밍 호출) 서비스
        - Blazor - Js 프론트엔드를 따라서 C# 컴포넌트 기반으로 개발하는 웹개발 방식 웹사이트 개발
        - Razor - 프론트엔드 개발에 C# 코드가 특화되서 사용되는 웹사이트 개발 방식
        - .NET Aspire - Blazor 프론트엔드 + Redis + 웹 API 백엔드

    - 참조 사이트
        - https://github.com/dotnet
        - https://mixedcode.com/
        - https://learn.microsoft.com/ko-kr/aspnet/core/?view=aspnetcore-3.1

    - ASP.NET Core 웹앱(MVC)
        - 현재 기본적인 웹개발에 가장 표준
        - Java계열도 Spring (Boot) MVC로 개발
        - MVB개념도

        <img src="https://raw.githubusercontent.com/YooWangGwon/basic-aspnet-2024/main/images/asp005.png" width="730">

        - 프론트엔드가 예전에는 스파게티 코드가 무지 심했다면, 현재는 스파게티 코드가 최소화 되어있음.(SpringBoot, Python flask든 모두 동일)
        - IIS Express Server - VS에서 ASP.NET 웹사이트를 운영하는 개발용 웹서버
        - index.* : 웹사이트에서 가장 대문이 되는 페이지이름(Home)
        - 파일 저장시 핫 다시 로드(HotReload) 체크
        - @로 시작하는 C# 구문. Tag Helper, HTML Helper 로 html구문 내에 c# 코드를 적어서 활용 = Razor 구문
        - Action == HTML 에서 form 태그 내 submit 버튼 클릭! / 링크를 클릭하는 것, 윈앱에서 이벤트와 동일
        - 액션이 발생한 이후 처리하는 메서드의 결과를 ActionResult
        - 콘솔 서버로그 잘 확인할 것, 프로세스가 종료되면 웹사이트가 실행안됨

    - 데이터베이스 연동방법
        - DB first : 가장 전통적인 DB 연동방식. DB 설계, DB 구축, C#과 연동
        - Code first : 가장 트랜드가 되는 DB 연동방식. C# 클래스 작성. DB 연결 설정 후 실행하면 DB에 테이블이 생성....
        - EntityFramework를 사용하면 아주 손쉽게 구축가능. DB를 잘 모르고 C#, ASP.NET만 알아도 DB 핸들링 가능

    - EntityFramework(Core)
        - Microsoft.EntityFrameworkCore
        - Microsoft.EntityFrameworkCore.Tools
        - Microsoft.EntityFrameworkCore.SqlServer

    - Code first 구현순서
        - ASP.NET 프로젝트 생성
        - EF 패키지 3개 설치
        - 엔티티 클래스 작성
        - appsettings.json에 DB 연결 문자열 추가
        - Data/ApplicationDbContext.cs 중간연결 클래스 생성
        - Program.cs Services 내에 DbContext 종석성을 주입
        - Nuget 패키지 관리자 > 패키지 관리자 콘솔 실행
            ```shell
            PM> add-migration '마이그레이션 명'
            Build started...
            Build succeeded.
            ...
            PM> update-database
            ...
            Done
            ```
        - Controllers 폴더에 컨트롤러 추가
           
        <img src="https://raw.githubusercontent.com/YooWangGwon/basic-aspnet-2024/main/images/asp008.png" width="600">
        
        - 실행(Ctrl+F5)

        - 브라우저 실행 시 NET::ERR_CERT_INVALID 연결 비공개 설정이 안되 화면이 나타나지 않는 경우
            - 브라우저 화면 클릭, thisisunsafe를 입력하고 클릭

## 9일차(24.07.16)
- ASP.NET Core MVC
    - MVC 복습
        - Model은 개발자가 따로 만듦
        - View, Controller 폴더는 미리 만들어짐
        - 웹 브라우저에서 접근할 페이지를 만들려면(작업 순서)
            1. 해당 컨트롤러 생성
            2. 뷰를 같이 생성할지 나중에 따로 만들지 선택
            3. 컨트롤러 이름과 동일한 뷰 폴더, 메서드 이름과 동일한 cshtml 페이지가 생성
            3. 컨트롤러에 모델에 DB와 연결될 내용을 작성
            4. 모델 내용을 뷰로 리턴

- ASP.NET Core 웹사이트 만들기, MyPortfolio
    1. Visual Studio에서 ASP.NET Core 웹앱(MVC)
    2. BootStrap 탬플릿 사이트에서 알맞은 템플릿을 다운로드
        - 사이트
            <a href="https://startbootstrap.com/themes#google_vignette"><b>Start Bootstrap</b></a>
            <a href="https://themewagon.com/"><b>Theme Wagon</b></a>
        - <a href="https://startbootstrap.com/theme/personal"><b>사용한 템플릿</b></a>
    3. wwwroot 폴더 밑에 템플릿 html, css, js, 이미지 등 위치하기
    4. 템플릿 페이지에 공통적인 부분(Header, Bottom)은 _layout.cshtml에 위치
    5. 중간에 페이지마다 변경되는 부분은 각 Views 밑에 포함
    6. _layout.html에 공통부분 영역 옮기기
    7. index.cshtml에 index.html에서 공통부분 외 영역 옮기기
    8. index.cshtml 내용 수정
    9. ResumeController.cs 생성, DB 관련된 설정이 없으면 모델, 뷰를 만들기 어려움
    10. Resume 란 폴더가 Views 아래에 만듦. Index.cshtml
    11. Resume.html에 있는 Navigation 아래 Footer 위의 변경 부분만 복사해서 Index.cshtml에 붙여넣기
    12. 9번~11번의 내용을 Project, Contact도 동일하게 적용
    13. Code First 방식으로 Board 테이블 생성
    14. Nuget 패키지에서 Microsoft.EntityFrameworkCore 패키지 검색, 설치
    15. Microsoft.EntityFrameworkCore.Tools 패키지 검색, 설치
    16. Microsoft.EntityFrameworkCore.SqlServer 패키지 검색, 설치
    17. model/Board.cs 로 엔티티 클래스 생성
    18. appsettings.json에 DB 연결 문자열 추가
    19. Data/AppDbContext.cs 생성
    20. Program.cs에 DbContext 종속성을 주입
    21. Nuget 패키지 관리자 콘솔 > Add-Migration > UpdateDatabase 진행
    22. _layout.cshtml Board 링크 수정
    23. /Controller/BoardController.cs를 생성(모델, 뷰 연결)
        - Entity Framework가 사용하며 뷰가 포함된 MVC 컨트롤러

        <img src="https://raw.githubusercontent.com/YooWangGwon/basic-aspnet-2024/main/images/asp008.png" width="500">


## 10일차
- ASP.NET Core 웹사이트 만들기, MyPortfolio
    1. board.cs의 멤버 속성 Mode -> ModDate
    2. 테이블 삭제, 재생성
    3. 게시판 관련된 화면 수정작업
    4. 페이징!!
    5. 회원가입, 로그인...
    6. 관리자 모드/페이지