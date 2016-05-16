<?php
    if($_GET['key'] != md5('1111'))
    {    
	header('location: login.php') ;   
	exit();       
	} 
	
	if(!empty($_POST))
    {    
		mysql_connect('localhost', 'root', '');
		mysql_select_db('lab4');
	
		$new_rate = $_POST['rate'];
		mysql_query("UPDATE rates SET value='$new_rate' WHERE name='USD'");
		
		$new_ratee = $_POST['ratee'];
		mysql_query("UPDATE rates SET value='$new_ratee' WHERE name='EUR'");
	      
	} 
?> 

<!DOCTYPE html> 
<html>    
	<head>        
		<title>freebitcoinreklam</title>  
		<meta charset="cp1251" />    
	</head>   
	<body style="width: 96%; height: 800 px; background : url(img/gf.jpg);"><center/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>
		Изменить курс валют:
		<form method="post">
			Для $:
			<input type="text" name="rate" /><br/>
			Для €:
			<input type="text" name="ratee" /><br/>
			<input type="submit" value="Сохранить" /><br/>
			<a href="/index.php">На главную</a>
		</form>
	</body>
 </html>