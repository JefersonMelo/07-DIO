const cards = document.querySelectorAll('.card');
var hasFlippedCard = false;
var firstCard, secoundCard;
var lockBoard = false;

function flipCard() {
    if (lockBoard) {
        return;
    }
    if (this === firstCard) {
        return;
    }
    this.classList.toggle('flip');
    if (!hasFlippedCard) {
        hasFlippedCard = true;
        firstCard = this;
        return;
    }

    secoundCard = this;
    hasFlippedCard = false;
    checkForMath();
}

function checkForMath() {
    if (firstCard.dataset.card === secoundCard.dataset.card) {
        disableCards();
        return;
    }
    unflipCard();
}

function disableCards() {
    firstCard.removeEventListener('click', firstCard);
    secoundCard.removeEventListener('click', firstCard);
    resetBoard();
}

function unflipCard() {
    lockBoard = true;

    setTimeout(() => {
        firstCard.classList.remove('flip');
        secoundCard.classList.remove('flip');
        lockBoard = false;
        resetBoard();

    }, 1500);
}

function resetBoard() {
    [hasFlippedCard, lockBoard] = [false, false];
    [firstCard, secoundCard] = [null, null];
}

(function shuffle() {
    cards.forEach((card) => {
        var randomPosition = Math.floor(Math.random() * 12);
        card.style.order = randomPosition;
    });
})();

cards.forEach((card) => {
    card.addEventListener('click', flipCard)
});