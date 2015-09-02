<?php mysql_query("SET NAMES UTF8"); ?>
<?php require_once 'header.php'; ?>
<form action="" method="post" >
<center><img src="img/gonder.jpg" alt="" width="300" height="100" /><br /></center>
<center>
    <b>YEMEK EKLEME</b>
    <hr width="120" align="center">
    <table border="1" >
        <tr><td>
           AD

        </td>
        <td>
            <input type="text" name="ad" >
        </td></tr>

        <tr><td>
              TARÝF

            </td>
            <td>
                <input type="text" name="tarif">
            </td></tr>
			     <tr><td>
          MALZEME

        </td>
        <td>
            <input type="text" name="malzeme">
        </td></tr>

        <tr><td>
              TÜR

            </td>
            <td>
                <input type="text" name="tur">
            </td></tr>

    </table>
    <input type="submit" name="gonder" value="gönder">
	
</center>
</form>




<?php
/**
 * Created by PhpStorm.
 * User: GULSEN
 * Date: 11.05.2014
 * Time: 13:14
 */

 


if(isset($_POST["gonder"]))

{
    mysql_connect("localhost","root","");
    mysql_selectdb("yemeksite");
	mysql_query("SET NAMES UTF8");
    $ad=$_POST["ad"];
    $tarif=$_POST["tarif"];
	$malzeme=$_POST["malzeme"];
    $tur=$_POST["tur"];
    mysql_query("INSERT INTO yemekler (yemek_adi,yemek_turu,malzeme,tarif) values ('$ad','$tarif','$malzeme','$tur')");

        echo "ADI: ".$ad; 
        echo "<br>TARÝFÝ".$tarif;
		 echo "<br>MALZEME: ".$malzeme;
        echo "<br>TÜR".$tur;
         echo "<br>Yeni bir yemek eklediniz TEÞEKKÜR EDERÝZ!!!!";


}



?>









