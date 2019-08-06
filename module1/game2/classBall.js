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
        if(this.x <= this.radius || this.x >= canvas.width - this.radius) {
            WALL_HIT.play();
            this.dx= -this.dx;
        }
        if(this.y < this.radius) {
            WALL_HIT.play();
            this.dy = - this.dy;
        }
    } 
}