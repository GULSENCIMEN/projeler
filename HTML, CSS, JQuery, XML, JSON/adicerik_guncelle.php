<?php 
$guncellenecek_veri = $_POST['derskodu'];
$dersadi = $_POST['dersadi'];
$dersinicerik = $_POST['dersinicerik'];
$baglan=mysql_connect("localhost","root","");
mysql_selectdb("bs");
mysql_query("SET NAMES UTF8");
$sql = mysql_query("update dersler set dersAdi='$dersadi', icerik='$dersinicerik' where dersKodu='$guncellenecek_veri '") or die("Hata Olustu!");
mysqli_query($baglan,$sql);
mysqli_close($baglan);
?>