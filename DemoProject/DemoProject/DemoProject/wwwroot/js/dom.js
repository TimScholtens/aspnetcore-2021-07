

// DOM: Document Object Model (alle HTML-elementen op je webpagina = DOM tree)



function addPenalty() {
    console.log('addPenalty');

    let template = document.querySelector('#template-penalty').content;
    let clone = template.cloneNode(true);

    clone.querySelector('.id').innerText = '5858';
    clone.querySelector('.name').innerText = 'Henk';
    clone.querySelector('.scored').innerText = 'Jazeker';
    clone.querySelector('.speed').innerText = '593.93km/h';
    clone.querySelector('.photoFace').setAttribute('src', 'https://mk0denuklv1c43u9ykp.kinstacdn.com/app/uploads/2019/05/Henk-is-blij.png');

    document.querySelector('#penalties tbody').appendChild(clone);
}
