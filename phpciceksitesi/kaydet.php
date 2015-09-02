<?php
/**
 * Created by PhpStorm.
 * User: user
 * Date: 26.05.2014
 * Time: 15:53
 */
require_once 'veritabanibaglanti.php';

$sql="insert into uye (uyead,uyesoyad,sifre) values ('".$_POST['ad']."','".$_POST['soyad']."','".$_POST['sifre']."')";

$result = mysqli_query($baglantiNo,$sql);

mysqli_set_charset($baglantiNo,"utf-8");
mysqli_query($baglantiNo,"SET COLLATION_CONNECTION = 'utf8_turkish_ci' ");

mysqli_close($baglantiNo);
?>