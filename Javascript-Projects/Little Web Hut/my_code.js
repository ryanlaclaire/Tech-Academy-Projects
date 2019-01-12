// JavaScript source code
$(document).ready(function() {
    //hide the <p>aragraph tags
    $("p").hide();
    //toggle hide and show
    $("h1").click(function() {
        $(this).next().slideToggle(300);
    });

});