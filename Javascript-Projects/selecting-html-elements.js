// JavaScript source code
<!DOCTYPE html>
<html>
<body>

<p>Type in the first name:</p><br>
<input type="text" value="" id="fname"><br><br>
<p id="showText"></p><br><br>
<input type="submit" value="See Name" onclick="myFunction()">


	<script>
		function myFunction() {
    		var name = document.getElementById("fname").value;
        	var show = document.getElementById("showText")
            show.innerHTML = name;
        }    
	</script>

</body>
</html>