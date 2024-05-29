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
        - div : 그룹화 구분자, 매우 중요(CSS 연계 디자인)
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
    - 시맨틱 태그
- CSS3
    - 웹 디자인 핵심
- Javascript
