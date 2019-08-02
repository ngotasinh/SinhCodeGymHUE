let canvas = document.getElementById("game");
let context= canvas.getContext("2d");

let ball = new Ball(12, 570, 3, 4, 12);
let paddle= new Paddle(90, 12, 0, canvas.height - 12, 7);
let brick = new Brick(10, 30, 10, 60, 20, 4, 7);


let isGameOver = false;
let isGameWin = false;
let isBroken= false;
let score = 0;
let maxScore = brick.colum * brick.row ;
let brickLayer = [];


let imgplay = document.getElementById("play");
let imgGameover= document.getElementById("gameover");
let imgYouWin= document.getElementById("youwin");
let imgPlayAgain= document.getElementById("playagain");


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

for(let r= 0; r < brick.row; r++) {
    for(let c= 0; c < brick.colum; c++) {
        brickLayer.push({
            x : brick.marginX + c*(brick.width + brick.between),
            y : brick.marginY + r*(brick.height + brick.between),
            isBroken: false
        });
    }
}