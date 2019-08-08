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

    collideBall() {
        if(ball.x + ball.radius >= this.x && ball.x - ball.radius <= this.x + this.width &&
            ball.y + ball.radius >= canvas.height - this.height) {
                PADDLE_HIT.play();

                let collidePoint = ball.x - (this.x + this.width/2);
                collidePoint = collidePoint / (this.width/2);

                let angle = collidePoint * Math.PI/3;

                ball.dx = ball.speed * Math.sin(angle);
                ball.dy = - ball.speed * Math.cos(angle);
        }
    }
}

let paddle= new Paddle(90, 12, 0, canvas.height - 12, 7);

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
});
