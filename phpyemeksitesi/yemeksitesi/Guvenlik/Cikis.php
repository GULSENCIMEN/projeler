<!DOCTYPE html>

<html>
	<head>
		<title>cikis</title>

		<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

	</head>

	<body>

		<?php
		
			session_start();
			
			session_destroy(); // Oturum sonlandırılıyor. Tüm oturum bilgileri yok edilir.
		   
			 $_SESSION['name']="";
			echo "ANASAYFAYA DON ::::>
				<a href=\"./index.php\" >Giriş</a>";
		?>

		
	</body>
</html>

