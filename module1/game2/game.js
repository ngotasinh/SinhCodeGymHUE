function drawScore() {
    context.font = "16px Arial Bold";
    context.fillStyle = "black";
    context.fillText("Score: "+ score, 8, 20);
}

function checkGameOver() {
    if(ball.y + ball.radius> canvas.height){
        isGameOver = true ;
    }
}

function disPlay() {
    imgplay.style.display= "none"
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

let isGameOver = false;
let isGameWin = false;
let score = 0;
let maxScore = brick.colum * brick.row ;

function loop() {
    if(!isGameOver) {
    context.clearRect(0,0, canvas.width , canvas.height);
    ball.draw(context);
    ball.update();
    ball.collideWall();

    paddle.draw();
    paddle.update();
    paddle.collideBall();

    brick.draw();
    brick.collideBall();

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














