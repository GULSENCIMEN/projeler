<?php
require_once 'Genel/ClassVeritabaniMysqli.php';
require_once 'Genel/ClassIstisnaVeritabani.php';
try
{
    $veritabani = new Veritabani();
}
catch (DBException $e)
{
    echo $e -> hataGoruntule();
    exit(1);
}

try
{
    $alanlarDegerler = array("kullanici_adi" => "'$_POST[username]'", "kullanici_sifre" => "'$_POST[sifre]'", "email" => "'$_POST[mail]'");
    $veritabani -> insert("kisiler",$alanlarDegerler);

}
catch (Exception $e)
{
    echo $e -> getMessage();
}

catch (DBException $e)
{
    echo $e -> hataGoruntule();
}
if($result)
{
    $data= array ('sonuc'=>'1');
}
else
{
    $data= array ('sonuc'=>'0');

}

?>

