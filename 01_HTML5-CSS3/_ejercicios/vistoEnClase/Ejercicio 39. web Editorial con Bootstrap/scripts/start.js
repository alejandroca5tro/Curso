var navButton = document.querySelector('#navButton');

var unfoldedNav = document.querySelector('#unfoldedNav');

navButton.addEventListener('click', showUnfoldedMenu);

function showUnfoldedMenu() {
    unfoldedNav.className = 'goToTop';
    navButton.addEventListener('click', hideUnfoldedMenu);
}

function hideUnfoldedMenu() {
    unfoldedNav.className = 'hide';
    navButton.addEventListener('click', showUnfoldedMenu);
}