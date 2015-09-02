<?php
/**
 * Created by PhpStorm.
 * User: user
 * Date: 26.05.2014
 * Time: 17:26
 */
require_once 'veritabanibaglanti.php';
require_once 'bakimsinifi.php';

$sql="SELECT *FROM bakim WHERE bakimid='".$_POST['bakimid']."'";
$result = mysqli_query($baglantiNo,$sql);
$row = mysqli_fetch_array($result);

$ad=$row['bakimadi'];
$icerik=$row['bakimicerik'];

$bakim=new bakimsinifi($ad,$icerik);

mysqli_set_charset($baglantiNo,"utf-8");

mysqli_query($baglantiNo,"SET COLLATION_CONNECTION = 'utf8_turkish_ci' ");

mysqli_close($baglantiNo);

echo "<table id='mytable'>";

echo "<tr>";
echo "<td>".$bakim->getbakimadi()."</td>";
echo "<td>".$bakim->getbakimicerik()."</td>";
echo "</tr>";

?>