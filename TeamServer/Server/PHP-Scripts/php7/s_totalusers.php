<?php

require ('cfg_database.php');
$link = new mysqli(MYSQL_HOST,MYSQL_BENUTZER,MYSQL_KENNWORT,MYSQL_DATENBANK);

mysqli_select_db($link, MYSQL_DATENBANK);
$query = "SELECT * FROM users WHERE 1";
$result = mysqli_query($link,$query);

while ($row = mysqli_fetch_assoc($result)) {
        echo $row["name"].","; 
    } 
?>