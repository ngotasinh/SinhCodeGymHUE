const MOVE_LEFT = 37;
const MOVE_RIGHT = 39;
document.addEventListener("keyup", function(event) {
    if(event.keyCode === MOVE_LEFT) {
        paddle.isMoveLeft = false ;
    } else if(event.keyCode === MOVE_RIGHT) {
        paddle.isMoveRight = false ;
    }
});
document.addEventListener("keydown", function(event) {
    if(event.keyCode === MOVE_LEFT) {
        paddle.isMoveLeft = true ;
    } else if(event.keyCode === MOVE_RIGHT) {
        paddle.isMoveRight = true ;
    }
});

document.addEventListener("mousemove", function(b) {
    let relativeX = b.clientX - canvas.offsetLeft;
    if(relativeX > 0 && relativeX < canvas.width) {
        paddle.x = relativeX - paddle.width/2;
    }
})
