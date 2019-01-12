// JavaScript source code
var lang = "JavaScript";

function myFunction(lang) {
    this.lang = lang;
    document.write("Hello, welcome to " + this.lang);
};
var Test = new myFunction(lang)