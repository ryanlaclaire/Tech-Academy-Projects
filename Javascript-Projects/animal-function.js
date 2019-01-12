// JavaScript source code
function animal(name, eyes, ears, nose, legs, fur) {
    this.name = name;
    this.eyes = eyes;
    this.ears = ears;
    this.nose = nose;
    this.legs = legs;
    this.fur = fur;
    document.write("<br><br>Species: " + this.name);
    document.write("<br>Eyes: " + this.eyes);
    document.write("<br>Ears: " + this.ears);
    document.write("<br>Nose: " + this.nose);
    document.write("<br>Legs: " + this.legs);
    document.write("<br>Fur: " + this.fur);
};
var zebra = new animal("Zebra", 2, 2, 1, 4, "yes");
var snake = new animal("Snake", 2, 0, 1, 0, "no");
var giraffe = new animal("Giraffe", 2, 2, 1, 4, "yes");