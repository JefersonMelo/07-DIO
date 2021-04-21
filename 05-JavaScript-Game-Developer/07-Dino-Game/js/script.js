const dino = document.querySelector('.dino');
const background = document.querySelector('.background');

var isJumping = false;

function handleKeyUp(event) {
    if (event.keyCode === 32) {
        if (!isJumping) {
            jump();
        }
    }
}

function jump() {
    var position = 0;

    isJumping = true;

    var upInterval = setInterval(() => {
        if (position >= 150) {
            clearInterval(upInterval);

            //Descer
            var downInterval = setInterval(() => {
                if (position <= 0) {
                    clearInterval(downInterval);
                    isJumping = false;
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

function createCactus() {
    const cactus = document.createElement('div');
    var cactusPisition = 1000;
    var randomTime = Math.random() * 6000;

    cactus.classList.add('cactus');
    cactus.style.left = 1000 + 'px';
    background.appendChild(cactus);

    var leftInterval = setInterval(() => {
        if (cactusPisition < -60) {
            clearInterval(leftInterval);
            background.removeChild(cactus);
        } else {
            cactusPisition -= 10;
            cactus.style.left = cactusPisition + 'px';
        }
    }, 20);

    setTimeout(createCactus, randomTime);
}

createCactus();
document.addEventListener('keyup', handleKeyUp)