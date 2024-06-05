let items = document.querySelectorAll('.slider .List .item'); // slider .List .item 모두, .thumbnail class 아래에도 item이 있으므로 명확하게 List 아래 item을 가리킨다는 것을 명시하기
        let next = document.getElementById('next');
        let prev = document.getElementById('prev');
        let thumbnails = document.querySelectorAll('.thumbnail .item')

        // config param
        let countItem = items.length;
        let itemActive = 0;

        // event next click
        next.onclick = function(){
            itemActive = itemActive + 1;
            if(itemActive >= countItem){ 
                itemActive = 0;
            }
            showSlider();
        }

        prev.onclick = function(){
            itemActive = itemActive -1;
            if(itemActive <0){
                itemActive = countItem -1; // 첫 슬라이드에서 prev버튼 누를 시, 맨 뒤로 이동
            }
            showSlider();
        }
        
        // 자동 넘겨짐 애니메이션
        let refreshInterval = setInterval(() => {
            next.click();
        }, 3000)
        
        function showSlider(){
            //remove item active old
            let itemActiveOld = document.querySelector('.slider .List .item.active') // class 이름이 .slider .list .item.active인 것을 찾는다
            let thumbnailActiveOld = document.querySelector('.thumbnail .item.active');
            itemActiveOld.classList.remove('active'); // active 해제
            thumbnailActiveOld.classList.remove('active'); // active 해제
            
            // active new item
            items[itemActive].classList.add('active'); // itemActive(= 숫자)에 해당하는 items의 class에 active 추가 ===> active 활성화
            thumbnails[itemActive].classList.add('active'); 
            
            //clearInterval(refreshInterval);
        }

        // click thumbnail
        // 썸네일 클릭 시 해당 인덱스 추출 & 화면전환
        thumbnails.forEach((thumbnails, index) => {
            thumbnails.addEventListener('click', () => {
                itemActive = index;
                showSlider();
            })
        });