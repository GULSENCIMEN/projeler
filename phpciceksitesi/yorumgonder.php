<?php
/**
 * Created by PhpStorm.
 * User: user
 * Date: 24.05.2014
 * Time: 20:00
 */


require_once 'veritabanibaglanti.php';
require_once 'uyedenetim.php';

$sql="insert  into yorum (uyeid,yorumicerik) values ('".$_SESSION['uyeid']."','".$_POST['yorum']."')";


$result = mysqli_query($baglantiNo,$sql);

mysqli_set_charset($baglantiNo,"utf-8");
mysqli_query($baglantiNo,"SET COLLATION_CONNECTION = 'utf8_turkish_ci' ");

mysqli_close($baglantiNo);
?>
