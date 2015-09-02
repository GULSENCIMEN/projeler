

		<?php
			
			session_start();

			if(!isset($_SESSION['name'])  || $_SESSION['name']!='ygmr' )
			{

				echo "Yetkili kullanıcı değilsiniz....Giriş yapmanız gerekiyor
				<a href=\"index.php\" >Giriş</a>";
				
				exit();
			
			}



			
			$oturumOmru = 5;
			
			if (isset($_SESSION['baslangicZamani']))
			{
				$oturumSuresi = time() - $_SESSION['baslangicZamani'];
				if ($oturumSuresi > $oturumOmru)
				{
					echo "Oturum süreniz dolmuştur...";	
					header("Location: Guvenlik/Cikis.php");
				}
			}
			$_SESSION['baslangicZamani'] = time();
			
						
		?>
	
