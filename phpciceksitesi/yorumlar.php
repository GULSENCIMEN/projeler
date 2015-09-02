<?php
/**
 * Created by PhpStorm.
 * User: user
 * Date: 26.05.2014
 * Time: 11:04
 */
require_once 'veritabanibaglanti.php';


$sql="SELECT yo.yorumicerik icerik,uy.uyead ad,uy.uyesoyad soyad,yo.tarih tarih FROM yorum yo inner join uye uy on uy.uyeid=yo.uyeid";


$result = mysqli_query($baglantiNo,$sql);

mysqli_set_charset($baglantiNo,"utf-8");
mysqli_query($baglantiNo,"SET COLLATION_CONNECTION = 'utf8_turkish_ci' ");

mysqli_close($baglantiNo);


echo "<table id='mytable'>
		<tr>
			<th>gönderen- tarih</th>
			<th>yorum</th>
		</tr>";

while ($row = mysqli_fetch_array($result)) {
    echo "
		<tr>
			";
    echo "<td>".$row['ad']."&nbsp&nbsp".$row['soyad']."&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp".$row['tarih']."</td>";
    echo "<td>".$row['icerik']."</td>";
    echo "</tr>";
}
mysqli_free_result($result);
echo "</table>";

?>