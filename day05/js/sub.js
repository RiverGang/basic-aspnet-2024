/* 회전버튼 동작 */
const rotateBtn = document.querySelector('.rotate-btn') /*javaScript 사용*/
const slides = document.querySelectorAll('.bg-slide');
const totalSlides = slides.length; // 5
let index = 0;

// $('.rotate-btn').on('click', function()); 과 동일한 형태의 클릭이벤트 생성
rotateBtn.addEventListener('click', function(){
    rotateBtn.classList.add('active');
    setTimeout(() => {
        rotateBtn.classList.remove('active');
    }, 2100);

    slides.forEach(slide => { // slides를 돌면서(forEach)
        if(slide.classList.contains('active')){
            slide.classList.add('after-active');
        }
        else {
            slide.classList.remove('after-active');
        }
    });
    
    slides[index].classList.remove('active'); /* 현재 슬라이드는 active 제거 */
    index += 1;

    if (index == totalSlides) index = 0; 
    
    slides[index].classList.add('active'); /* 새 슬라이드에 active 추가 */
});