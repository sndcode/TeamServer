<?php

require ('cfg_database.php');

$connection = mysql_connect(MYSQL_HOST,MYSQL_BENUTZER,MYSQL_KENNWORT);

//Get parameter from URL
if (isset($_GET['user'])) 
{
    //echo "\nWorking with : ".$_GET['user'];
	$usernametouse = $_GET['user'];
}
if (isset($_GET['day'])) 
{
    //echo "\nWorking with : ".$_GET['user'];
	$daytouse = $_GET['day'];
}

mysql_select_db('teamserver');

//$query = "SELECT * FROM termine WHERE user = '$usernametouse' AND day = '$daytouse'"; 
$query = "SELECT day, user, context FROM termine_$usernametouse WHERE day = '$daytouse' ";
$result = mysql_query($query);

//echo "<table>";

while($row = mysql_fetch_array($result)){   
echo 
//"<tr><td>" 
//. $row['id'] 
//. "</td><td>" 
//." ". 
//$row['username'] 
//." ". 
//$row['tag'] 
//." ". 
$row['context'] 
//."</td></tr>";
;
}
//echo "</table>"; 
mysql_close(); 


//Footer
//echo "\nTeamserver v0.1";
?>