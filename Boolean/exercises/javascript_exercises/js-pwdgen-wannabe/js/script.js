// Chiedi all’utente il suo nome,
// poi chiedi il suo cognome,
// poi chiedi il suo colore preferito
// Infine scrivi sulla pagina nomecognomecolorepreferito22

let nameUser = prompt('What is your name?');
let lastNameUser = prompt('What is your last name?');
let favoriteColor = prompt('What is your favorite color?');

let passwd = nameUser + lastNameUser + favoriteColor + '22';

document.getElementById('password').innerHTML = passwd;
