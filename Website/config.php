<?php

$servername = "studmysql01.fhict.local";
$username = "dbi387149";
$password = "PROP";
$dbname = "dbi387149";

$link = mysqli_connect($servername, $username, $password, $dbname);

// Check connection
if($link === false){
    die("ERROR: Could not connect. " . mysqli_connect_error());
}
