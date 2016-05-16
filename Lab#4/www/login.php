<?php
    if(!empty($_POST))
    {    
	header('location: secret.php?key=' . md5($_POST['login'])) ;   
	exit();       
	} 
?> 


<!DOCTYPE html> 
<html>    
	<head>        
		<title>Авторизация</title>  
		<meta charset="cp1251" />    
	</head>   
	<body style="width: 96%; height: 800 px; background : url(img/vf.jpg);">   
		<form method="post"><center/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>
		Введите пароль:<br/>
		<input type="text" name="login" /><br/>
		<input type="submit" value="Войти" />
		</form>
		</body>
 </html>