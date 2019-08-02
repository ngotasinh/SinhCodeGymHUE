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