<?php 
$guncellenecek_veri = $_POST['derskodu'];
$koordinator = $_POST['koordinator'];
$baglan=mysql_connect("localhost","root","");
mysql_selectdb("bs");
mysql_query("SET NAMES UTF8");
$sorgu = mysql_query("update dersler set sicilNo='$koordinator' where dersKodu='$guncellenecek_veri '") or die("Hata Olustu!");
mysqli_query($baglan,$sorgu);
mysqli_close($baglan);
?>