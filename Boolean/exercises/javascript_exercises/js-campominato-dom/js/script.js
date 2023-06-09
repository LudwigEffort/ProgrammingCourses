/*
Consegna
Copiamo la griglia fatta ieri nella nuova repo e aggiungiamo la logica del gioco (attenzione: non bisogna copiare tutta la cartella dell'esercizio ma solo l'index.html, e le cartelle js/ css/ con i relativi script e fogli di stile, per evitare problemi con l'inizializzazione di git).
Il computer deve generare 16 numeri casuali nello stesso range della difficoltà prescelta: le bombe. Attenzione: nella stessa cella può essere posizionata al massimo una bomba, perciò nell’array delle bombe non potranno esserci due numeri uguali.
In seguito l'utente clicca su una cella: se il numero è presente nella lista dei numeri generati - abbiamo calpestato una bomba - la cella si colora di rosso e la partita termina. Altrimenti la cella cliccata si colora di azzurro e l'utente può continuare a cliccare sulle altre celle.
La partita termina quando il giocatore clicca su una bomba o quando raggiunge il numero massimo possibile di numeri consentiti (ovvero quando ha rivelato tutte le celle che non sono bombe).
Al termine della partita il software deve comunicare il punteggio, cioè il numero di volte che l’utente ha cliccato su una cella che non era una bomba.
*/

const elePlayButton = document.querySelector('#btn-play');
const eleLevelSelect = document.querySelector('#level'); 
const eleWelcome = document.querySelector('.welcome');
const eleGrid = document.querySelector('.grid');

const eleGuideButton = document.querySelector('#btn-guide')

elePlayButton.addEventListener('click', function(){
    eleGrid.innerHTML = ''; // this is for reset of the form output

    eleGrid.classList.remove('hidden');
    eleWelcome.classList.add('hidden');
     
    const nCell = parseInt(eleLevelSelect.value);
    const sideSquare = Math.sqrt(nCell);
    eleGrid.style.setProperty('--sideSquare', sideSquare);

    const arrBombNumbers = [1, 5, 10, 15, 20];

    const arrBomRandomsNumbers = [];

    for (let i = 1; i <= nCell; i++) {

        let randomNumber;
        do {
            randomNumber = getRandomInteger(i, nCell);
        }
        while (arrBomRandomsNumbers.includes(randomNumber))
        arrBomRandomsNumbers.push(randomNumber);

        //add for to generate 16 random numbers

        const eleCell = document.createElement('div');
        eleCell.classList.add('cell');
        eleCell.innerHTML = i;
        eleGrid.append(eleCell);

        eleCell.addEventListener('click', function addToggle() {

            const eleBanner = document.createElement('div');
            eleBanner.classList.add('banner');
            eleGrid.append(eleBanner);
            

            if (arrBombNumbers.includes(i)) { //closures
                //console.log('Yes');
                this.classList.add('bomb');
                const listCells = eleGrid.querySelectorAll('.cell');

                for (let i = 0; i < listCells.length; i++) {
                    listCells[i].removeEventListener('click', addToggle);
                    console.log('listener removed');
                }

            }

            else {
                this.classList.add('no-bomb');
            }

        });

    }
});

eleGuideButton.addEventListener('click', function () {

    if (eleGuideButton.dataset.state == 'show-guide') {
        eleGuideButton.innerHTML = 'Resume';
        eleGuideButton.dataset.state = 'show-game';
        eleGrid.classList.add('hidden');
        eleWelcome.classList.remove('hidden');
    }

    else {
        eleGuideButton.innerHTML = 'Guide';
        eleGuideButton.dataset.state = 'show-guide';
        eleGrid.classList.remove('hidden');
        eleWelcome.classList.add('hidden');
    }

});

function getRandomInteger(min, max) {
    return Math.floor(Math.random() * (min - max +1 )) + min;
}
