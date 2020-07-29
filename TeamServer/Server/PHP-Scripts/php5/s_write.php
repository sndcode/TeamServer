<?php

require ('cfg_database.php');

$connection = mysql_connect(MYSQL_HOST,MYSQL_BENUTZER,MYSQL_KENNWORT);

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
mysql_select_db('teamserver');

$query_write = "UPDATE termine_$usernametouse SET context = '$texttouse'  WHERE day = '$daytouse'";
//UPDATE termine SET context = 'an den briefkasten gehen'  WHERE user = 'maurice' AND day = 'freitag';
$result = mysql_query($query_write);

mysql_close(); 

?>