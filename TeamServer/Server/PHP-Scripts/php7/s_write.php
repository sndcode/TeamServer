<?php 

require ('cfg_database.php');

$link = mysqli_connect(MYSQL_HOST,MYSQL_BENUTZER,MYSQL_KENNWORT,MYSQL_DATENBANK);

//Get parameter from URL
if (isset($_GET['user'])) 
{
	$usernametouse = $_GET['user'];
}
if (isset($_GET['day'])) 
{
	$daytouse = $_GET['day'];
}
if (isset($_GET['text'])) 
{
	$texttouse = $_GET['text'];
}
mysqli_select_db($link, MYSQL_DATENBANK);

$query_write = "UPDATE termine_$usernametouse SET context = '$texttouse'  WHERE day = '$daytouse'";
$result = mysqli_query($link,$query_write);

mysqli_close($link);

?>