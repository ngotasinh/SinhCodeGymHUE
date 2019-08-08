class Brick {
    constructor(offsetX, offsetY, between, width, height, row, colum) {
        this.offsetX= offsetX;
        this.offsetY= offsetY;
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
    collideBall() {
        brickLayer.forEach(function(b) {
            if(!b.isBroken) {
                if(ball.x + ball.radius > b.x && ball.x - ball.radius < b.x + brick.width && 
                    ball.y + ball.radius > b.y && ball.y - ball.radius < b.y + brick.height) {
                        
                    BRICK_HIT.play();
                    b.isBroken = true;
                    ball.dy = -ball.dy;
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


let brick = new Brick(10, 30, 10, 60, 20, 4, 7);
let isBroken= false;
let brickLayer = [];

for(let r= 0; r < brick.row; r++) {
    for(let c= 0; c < brick.colum; c++) {
        brickLayer.push({
            x : brick.offsetX + c*(brick.width + brick.between),
            y : brick.offsetY + r*(brick.height + brick.between),
            isBroken: false
        });
    }
}
