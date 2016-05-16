<?php
     mysql_connect('localhost', 'root', '');
	 mysql_select_db('lab4');
	 
	 $result = mysql_query("SELECT * FROM rates WHERE name='USD'");
	 $row = mysql_fetch_assoc($result);
	 
	 $rate = $row['value'];
	 if(isset($_POST['bucks']))
		$bucks = $_POST['bucks'];
	 else
		$bucks = 0;
		
	 $result1 = mysql_query("SELECT * FROM rates WHERE name='EUR'");
	 $row1 = mysql_fetch_assoc($result1);
	 $ratee = $row1['value'];
	 if(isset($_POST['buckss']))
		$buckss = $_POST['buckss'];
	 else
		$buckss = 0;
?> 

<!DOCTYPE html> 
<html>     
<head>    
<title>Главная</title> 

<meta charset="cp1251" />     
</head> <body style="width: 97%; height: 800 px; background : url(img/df.jpg);">     
		<form method="post"> <center/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>
			Конвертер валют:
			<br/>   
			Текущий курс:<br/>
			$ = <?php echo $rate ;?> MDL<br/>
			€ = <?php echo $ratee ;?> MDL <br/>
			<a href="/secret.php">Изменить курс (admin only)</a><br/>
			<input type="text" name="bucks" value="<?php echo $bucks;?>" size="5"/>
			$ <input type="submit" value="Перевод" /> <?php echo $rate * $bucks;?> MDL
			<br/>
			<input type="text" name="buckss" value="<?php echo $buckss;?>" size="5"/> 
			€ <input type="submit" value="Перевод" /> <?php echo $ratee * $buckss;?> MDL 
			
 </form> 
 </body> 
 </html> 