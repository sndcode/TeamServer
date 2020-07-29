<?php

require ('cfg_database.php');
$link = new mysqli(MYSQL_HOST,MYSQL_BENUTZER,MYSQL_KENNWORT,MYSQL_DATENBANK);

if (isset($_GET['user'])) 
{
	$usernametouse = $_GET['user'];
}
if (isset($_GET['day'])) 
{
	$daytouse = $_GET['day'];
}

mysqli_select_db($link, MYSQL_DATENBANK);
$query = "SELECT day, user, context, prio FROM termine_$usernametouse WHERE day = '$daytouse' AND  user = '$usernametouse'";
$result = mysqli_query($link,$query);

while($row = mysqli_fetch_array($result,MYSQLI_BOTH))
{   
	echo $row['context'] ;
}

?>