function Circle(x,y, radius) {
    this.x= x ;
    this.y= y ;
    this.radius = radius ;
}
function createCricle() {
    let ctx= document.getElementById("Mycanvas").getContext("2d") ;
    let cricle= new Circle(200,200,100);
    ctx.beginPath() ;
    ctx.arc(cricle.x, cricle.y, cricle.radius, 0 , 2 *Math.PI) ;
    ctx.fill() ;
}
createCricle() ;


