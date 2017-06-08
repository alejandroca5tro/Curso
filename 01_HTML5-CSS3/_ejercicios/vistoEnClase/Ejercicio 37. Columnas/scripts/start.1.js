var progressBar = document.querySelector('div.progress progress');
var progressBarText = document.getElementById('progressIndicator');
var startButton = document.querySelector('input#startProgress');

startButton.addEventListener('click', startProgressBar);

function startProgressBar() {
    progressBar['value'] = 0;
    progressBar.className = 'onscreen';
    moveProgressBar()
}

function moveProgressBar() {
    setInterval(increaseProgresBar, 1000);
}

function increaseProgresBar() {
    progressBar['value']++;
    progressBarText.innerHTML = 'Progreso: ' + progressBar['value'] + '%';
}