<?php

$sunucu="localhost";
$veritabani="cicek";
$kullaniciAdi="root";
$sifre="";

$baglantiNo= mysqli_connect($sunucu, $kullaniciAdi, $sifre, $veritabani);

if (mysqli_connect_errno())
{
    echo "bağlantı başarısız... " . mysqli_connect_error();
}
mysqli_set_charset($baglantiNo,"utf8");
?>