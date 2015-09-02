<?php
require_once 'Genel/ClassVeritabaniMysqli.php';
require_once 'Genel/ClassIstisnaVeritabani.php';
session_start();

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
    $alanlar="kisi_id";
    $tabloAdi="kisiler";
    $kosul="kullanici_adi = '$_POST[userName]' ";

       $result= $veritabani -> select($alanlar,$tabloAdi,$kosul);


}
catch (Exception $e)
{
     echo $e -> getMessage();
}

catch (DBException $e)
{
    echo $e -> hataGoruntule();
}

if(mysqli_num_rows($result)!=0 )
{

    $data= array ('sonuc'=>'1');

}

else
{
    $data= array ('sonuc'=>'0');

}
echo json_encode($data);




?>

