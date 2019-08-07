let canvas = document.getElementById("game");
let context= canvas.getContext("2d");

let imgplay = document.getElementById("play");
let imgGameover= document.getElementById("gameover");
let imgYouWin= document.getElementById("youwin");
let imgPlayAgain= document.getElementById("playagain");


let WALL_HIT = new Audio();
WALL_HIT.src = "sounds/wall.mp3";

let LIFE_LOST = new Audio();
LIFE_LOST.src = "sounds/life_lost.mp3";

let PADDLE_HIT = new Audio();
PADDLE_HIT.src = "sounds/paddle_hit.mp3";

let WIN = new Audio();
WIN.src = "sounds/win.mp3";

let BRICK_HIT = new Audio();
BRICK_HIT.src = "sounds/brick_hit.mp3";
