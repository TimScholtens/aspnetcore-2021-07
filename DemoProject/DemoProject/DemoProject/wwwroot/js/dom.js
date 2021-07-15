

// DOM: Document Object Model (alle HTML-elementen op je webpagina = DOM tree)



function addPenalty() {
    addPenaltyToTable({
        id: '5858',
        name: 'Henk',
        scored: 'Jazeker',
        speed: 593.93,
        photoFace: 'https://mk0denuklv1c43u9ykp.kinstacdn.com/app/uploads/2019/05/Henk-is-blij.png'
    });
}

function addPenaltyToTable(penalty) {
    let template = document.querySelector('#template-penalty').content;
    let clone = template.cloneNode(true);

    clone.querySelector('.id').innerText = penalty.id;
    clone.querySelector('.name').innerText = penalty.player.name;
    clone.querySelector('.scored').innerText = penalty.scored;
    clone.querySelector('.speed').innerText = penalty.speed + 'km/h';
    clone.querySelector('.photoFace').setAttribute('src', penalty.photoFace);

    document.querySelector('#penalties tbody').appendChild(clone);
}

function getPenalties() {
    // Asynchronous JavaScript And JSON
    fetch('/api/penalty').then(x => x.json()).then(penalties => {
        penalties.forEach(p => addPenaltyToTable(p));
    });

    // interceptors: request interceptor voor een authenticatietoken
}