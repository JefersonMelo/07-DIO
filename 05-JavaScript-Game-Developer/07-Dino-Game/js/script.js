const dino = document.querySelector('.dino');

function handleKeyUp(event) {
    if (event.keyCode === 32) {
        jump();
    }
}

function jump() {
    var position = 0;

    var upInterval = setInterval(() => {
        if (position >= 150) {
            clearInterval(upInterval);

            //Descer
            var downInterval = setInterval(() => {
                if (position <= 0) {
                    clearInterval(downInterval);
                } else {
                    position -= 20;
                    dino.style.bottom = position + 'px';
                }
            }, 20);
        } else {
            //subir
            position += 20;
            dino.style.bottom = position + 'px';
        }
    }, 20);
}

document.addEventListener('keyup', handleKeyUp)