// JavaScript source code


function myFunction() {
    var num1 = 2;
    var num2 = 12;
    var equality = (num1 == "2");
    var strict = (num1 === "2");
    document.write("Equality: "+equality+"<br>");
    document.write("Strict: "+strict+"<br><br>");
    
    document.write("Data type: "+typeof num1);
    document.write("<br>Data type: "+typeof "2");
                                
    var test = isNaN(num2);
    console.log("isNaN(num2): "+test);
    var words = "words";
        
    var array = [1,2,3,4,5]
    document.write("<br>Data Type: "+typeof array);
            
    var test2 = isNaN(words);
    console.log("isNaN(test2): "+test2);
    var results = num1 + num2;
    document.write("<br>Data Type: "+typeof results)

    console.log(num1+" + "+num2+" = "+results);
};
myFunction()