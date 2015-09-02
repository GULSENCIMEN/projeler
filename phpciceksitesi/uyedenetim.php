<?php

     		session_start();

			if(!isset($_SESSION['baglandi']))
            {

                echo "
                <br/>
                <br/>
                <br/>
                <br/><p style='text-align: center'>Lütfen Anasayfadan giriş yapınız!!</p>
                </br>
				<p style='text-align: center'><a href='index.php' >Giriş</a></p>";

                exit();

            }

			$oturumOmru =120;

			if (isset($_SESSION['baslangicZamani']))
            {
                $cikis = 'cikis.php';

                $oturumSuresi = time() - $_SESSION['baslangicZamani'];

                if ($oturumSuresi > $oturumOmru)
                {
                    echo "<script language='Javascript'>window.location='".$cikis."'</script>";
                }
            }
			$_SESSION['baslangicZamani'] = time();




		?>

