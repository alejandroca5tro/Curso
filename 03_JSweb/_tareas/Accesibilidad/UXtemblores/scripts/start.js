var mousePointer = document.querySelector('div#mousePointer');

(function() {
    var mousePos;

    document.onmousemove = handleMouseMove;
    setInterval(getMousePosition, 100);

    function handleMouseMove(event) {

        var dot, eventDoc, doc, body, pageX, pageY;

        event = event || window.event;

        if (event.pageX == null && event.clientX != null) {
            eventDoc = (event.target && event.target.ownerDocument) || document;
            doc = eventDoc.documentElement;
            body = eventDoc.body;

            event.pageX = event.clientX +
                (doc && doc.scrollLeft || body && body.scrollLeft || 0) -
                (doc && doc.clientLeft || body && body.clientLeft || 0);
            event.pageY = event.clientY +
                (doc && doc.scrollTop || body && body.scrollTop || 0) -
                (doc && doc.clientTop || body && body.clientTop || 0);
        }

        mousePos = {
            x: event.pageX,
            y: event.pageY
        };
    }

    let xVariability = 30;
    let yVariability = 10;

    let mousePointerXPosition;
    let mousePointerYPosition;

    function getMousePosition() {

        var pos = mousePos;

        if (!pos) {} else {

            mousePointerXPosition = pos.x - (xVariability / 2) + (xVariability * Math.random());
            mousePointerYPosition = pos.y - (yVariability / 2) + (yVariability * Math.random());

            mousePointer.innerHTML = '<img src="images/aero_arrow.cur" alt="cursor" style="position:absolute; left:' + mousePointerXPosition + 'px; top:' + mousePointerYPosition + 'px; height: 34px;">'
        }

    }
})();

document.querySelector('#radio1').addEventListener('click', check1);
document.querySelector('#radio2').addEventListener('click', check2);
document.querySelector('#radio3').addEventListener('click', check3);

function check1() {
    document.getElementById('prueba1').checked = true;
}

function check2() {
    document.getElementById('prueba2').checked = true;
}

function check3() {
    document.getElementById('prueba3').checked = true;
}