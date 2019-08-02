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
