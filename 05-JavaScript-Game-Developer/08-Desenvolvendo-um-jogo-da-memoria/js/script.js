const cards = document.querySelectorAll('.card');
var hasFlippedCard = false;
var firstCard, secoundCard;
var lockBoard = false;

function flipCard() {
    if (lockBoard) {
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

}

function unflipCard() {
    setTimeout(() => {
        firstCard.classList.remove('flip');
        secoundCard.classList.remove('flip');
    }, 1500);
}

cards.forEach((card) => {
    card.addEventListener('click', flipCard)
});