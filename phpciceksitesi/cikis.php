<?php
/**
 * Created by PhpStorm.
 * User: user
 * Date: 24.05.2014
 * Time: 18:34
 */?>
<!DOCTYPE html>

<html>
	<head>

		<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

	</head>

	<body>

		<?php
			session_start();

			session_destroy();

			echo "<p style='text-align: center'>BAŞARILI ŞEKİLDE ÇIKIŞ YAPTINIZ</p>
                  <br/>
                  <br/>
                  <br/>

				<p style='text-align: center' ><a href='index.php'>ANASAYFA</a></p>";
		?>


</body>
</html>

