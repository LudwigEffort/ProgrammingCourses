/*
Utilizzando i dati forniti, creare un array di oggetti per rappresentare i membri del team.
Ogni membro è caratterizzato dalle seguenti informazioni: nome, ruolo e foto.
MILESTONE 0:
Creare l’array di oggetti con le informazioni fornite.
MILESTONE 1:
Stampare su console, per ogni membro del team, le informazioni di nome, ruolo e la stringa della foto
MILESTONE 2:
Stampare le stesse informazioni su DOM sottoforma di stringhe
BONUS 1:
Trasformare la stringa foto in una immagine effettiva
BONUS 2:
Organizzare i singoli membri in card/schede
Consigli del giorno:
Ragioniamo come sempre a step.
Prima la logica in italiano e poi traduciamo in codice.
*/

const eleCardsContainer = document.querySelector('.cards-container');

/*
const person1 = {
    'name': 'Wayne Barnett',
    'job': 'Founder & CEO',
    'img': 'wayne-barnett-founder-ceo.jpg'
};

const person2 = {
    'name': 'Angela Caroll',
    'job': 'Chief Editor',
    'img': 'angela-caroll-chief-editor.jpg'
};

const person3 = {
    'name': 'Walter Gordon',
    'job': 'Office Manager',
    'img': 'walter-gordon-office-manager.jpg',
};

const person4 = {
    'name': 'Angela Lopez',
    'job': 'Social Media Manager',
    'img': 'angela-lopez-social-media-manager.jpg'
};

const person5 = {
    'name': 'Scott Estrada',
    'job': 'Developer',
    'img': 'scott-estrada-developer.jpg',
};

const person6 = {
    'name': 'Barbara Ramos',
    'job': 'Graphic Designer',
    'img': 'barbara-ramos-graphic-designer.jpg'
};

const arrEmployes = [person1, person2, person3, person4, person5, person6];
*/

//change array in json like

const arrEmployes = [
    {
        "name": "Wayne Barnett",
        "role": "Founder & CEO",
        "img":  "wayne-barnett-founder-ceo.jpg"
    },
    {
        "name": "Angela Caroll",
        "role": "Chief Editor",
        "img":  "angela-caroll-chief-editor.jpg"
    },
    {
        "name": "Walter Gordon",
        "role": "Office Manager",
        "img":  "walter-gordon-office-manager.jpg"
    },
    {
        "name": "Angela Lopez",
        "role": "Social Media Manager",
        "img":  "angela-lopez-social-media-manager.jpg"
    },
    {
        "name": "Scott Estrada",
        "role": "Developer",
        "img":  "scott-estrada-developer.jpg"
    },
    {
        "name": "Barbara Ramos",
        "role": "Graphic Designer",
        "img":  "barbara-ramos-graphic-designer.jpg"
    }

];

// for (let key in person1) {
//     console.log(person1[key]);
// }

//console.log(arrEmployes);

printCards();

function printCards(){
    for(i = 0; i < arrEmployes.length; i++){
        //make div
        const eleDiv = document.createElement('div');
        eleDiv.classList.add('card');
        eleCardsContainer.append(eleDiv);
        //make img
        const eleImg = document.createElement('img');
        eleImg.src = `img/${arrEmployes[i].img}`;
        eleDiv.appendChild(eleImg);
        //make h4
        const eleH3 = document.createElement('h3');
        eleH3.innerHTML = arrEmployes[i].name;
        eleDiv.append(eleH3);
        //make p
        const eleP = document.createElement('p');
        eleP.innerHTML = arrEmployes[i].job;
        eleDiv.append(eleP);
        //console.log(arrEmployes[i].name);  
    }
}