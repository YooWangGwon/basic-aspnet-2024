// 회전 버튼 동작
let rotateBtn = document.querySelector('.rotate-btn');
let slides = document.querySelectorAll('.bg-slide');
let totalSlides = slides.length;    // 5 -> 자동으로 증감
let index = 0;

// jQuery : $('.rotate-btn').on('click', function()); 와 동일
rotateBtn.addEventListener('click', () => {
    rotateBtn.classList.add('active');
    setTimeout(()=> {
        rotateBtn.classList.remove('active');
    }, 2100); // 

    slides.forEach(slide => {
        if (slide.classList.contains('active')){
            slide.classList.add('after-active');
        }
        else {
            slide.classList.remove('after-active');
        }
    })

    slides[index].classList.remove('active'); // 현재 슬라이드는 active 제거

    index++;

    if(index == totalSlides){
        index = 0;
    }

    slides[index].classList.add('active');  // 새 슬라이드에 active 추가
})