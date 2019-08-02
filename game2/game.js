
function drawScore() {
    context.font = "16px Arial Bold";
    context.fillStyle = "black";
    context.fillText("Score: "+score, 8, 20);
}

function checkGameOver() {
    if( ball.y > canvas.height - ball.radius){
        isGameOver = true ;
    }
}

function disPlay() {
    play.style.display= "none"
}

function winAndLose() {
    if(isGameWin) {
        WIN.play();
        imgYouWin.style.display= "block";
    } else {
        LIFE_LOST.play();
        imgGameover.style.display= "block";
        imgPlayAgain.style.display= "block";
    }
}

function loop() {
    if(!isGameOver) {
    context.clearRect(0,0, canvas.width , canvas.height);
    ball.draw(context);
    ball.update();
    ball.collideWall();

    paddle.draw();
    paddle.update();
    paddle.collidePaddle();

    brick.draw();
    brick.collideBrick();

    drawScore()
    checkGameOver()
    disPlay();
    requestAnimationFrame(loop);
    } else {
        winAndLose()
    }
}
function playAgain() {
    location.reload();
}














