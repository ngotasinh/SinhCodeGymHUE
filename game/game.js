
class Ball {
    constructor(x, y, dx, dy, radius) {
        this.x= x;
        this.y= y;
        this.dx= dx;
        this.dy= -dy;
        this.radius= radius;
        this.speed = 5;
    }
    
    draw(context) {
        context.beginPath();
        context.arc(this.x, this.y, this.radius, 0, Math.PI*2);
        context.fillStyle = "red";
        context.fill();
        context.closePath();
    }

    update() {
        this.x = this.x + this.dx;
        this.y = this.y + this.dy;
    }

    collideWall() {
        if(this.x < this.radius || this.x > canvas.width - this.radius) {
            WALL_HIT.play();
            this.dx= -this.dx;
        }
        if(this.y < this.radius) {
            WALL_HIT.play();
            this.dy = - this.dy;
        }
    } 
}

class Paddle {
    constructor(width, height, x, y, speed) {
        this.width= width;
        this.height= height;
        this.x= x;
        this.y= y;
        this.speed= speed;
        this.isMoveLeft = false;
        this.isMoveRight = false
    }

    draw() {
        context.beginPath();
        context.rect(paddle.x, paddle.y, paddle.width, paddle.height);
        context.fillStyle= "red";
        context.fill();
        context.closePath();
    }

    update() {
        if(this.isMoveLeft) {
            this.x -= this.speed ;
        } else if(this.isMoveRight) {
            this.x += this.speed ;
        }
    
        if(this.x < 0) {
            this.x = 0 ;
        } else if(this.x > canvas.width - this.width) {
            this.x = canvas.width - this.width ;
        }
    }

    collidePaddle() {
        if(ball.x + ball.radius >= paddle.x && ball.x - ball.radius <= this.x + this.width &&
            ball.y + ball.radius >= canvas.height - this.height) {
                PADDLE_HIT.play();

                let collidePoint = ball.x - (paddle.x + paddle.width/2);
                collidePoint = collidePoint / (paddle.width/2);

                let angle = collidePoint * Math.PI/3;

                ball.dx = ball.speed * Math.sin(angle);
                ball.dy = - ball.speed * Math.cos(angle);
        }
    }
}

class Brick {
    constructor(marginX, marginY, between, width, height, row, colum) {
        this.marginX= marginX;
        this.marginY= marginY;
        this.between= between;
        this.width= width;
        this.height= height;
        this.row= row;
        this.colum= colum
    }

    draw() {
        brickLayer.forEach(function(b) {
            if(!b.isBroken) {
            context.beginPath();
            context.rect(b.x, b.y, brick.width,brick.height);
            context.fillStyle = "#EE7600"
            context.fill();
            context.strokeStyle = "#2e3548";
            context.stroke();
            context.closePath();
            }
        });
    }
    collideBrick() {
        brickLayer.forEach(function(b) {
            if(!b.isBroken) {
                if(ball.x + ball.radius >= b.x && ball.x - ball.radius <= b.x + brick.width && 
                ball.y + ball.radius >= b.y && ball.y - ball.radius <= b.y + brick.height) {
                    BRICK_HIT.play();
                    b.isBroken = true;
                    ball.dy = - ball.dy;
                    score += 1 ;
                    if(score === maxScore) {
                        isGameWin = true;
                        isGameOver = true;
    
                    }
                }
            }
        });
    }
}


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



let canvas = document.getElementById("game");
let context= canvas.getContext("2d");
let imgplay = document.getElementById("play");
let imgGameover= document.getElementById("gameover");
let imgYouWin= document.getElementById("youwin");
let imgPlayAgain= document.getElementById("playagain");

let ball = new Ball(12, 570, 3, 4, 12);
let paddle= new Paddle(90, 12, 0, canvas.height - 12, 7);
let brick = new Brick(10, 30, 10, 60, 20, 4, 7);


let isGameOver = false;
let isGameWin = false;
let isBroken= false;
let score = 0;
let maxScore = brick.colum * brick.row ;
let brickLayer = [];

for(let r= 0; r < brick.row; r++) {
    for(let c= 0; c < brick.colum; c++) {
        brickLayer.push({
            x : brick.marginX + c*(brick.width + brick.between),
            y : brick.marginY + r*(brick.height + brick.between),
            isBroken: false
        });
    }
}

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

const WALL_HIT = new Audio();
WALL_HIT.src = "sounds/wall.mp3";

const LIFE_LOST = new Audio();
LIFE_LOST.src = "sounds/life_lost.mp3";

const PADDLE_HIT = new Audio();
PADDLE_HIT.src = "sounds/paddle_hit.mp3";

const WIN = new Audio();
WIN.src = "sounds/win.mp3";

const BRICK_HIT = new Audio();
BRICK_HIT.src = "sounds/brick_hit.mp3";







