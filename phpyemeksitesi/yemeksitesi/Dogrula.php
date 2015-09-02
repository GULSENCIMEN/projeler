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
    $usr=mysql_real_escape_string(htmlspecialchars($_POST['userName1']));
    $sfr=mysql_real_escape_string(htmlspecialchars($_POST['sifre1']));
    $kosul="kullanici_adi = '$usr' and kullanici_sifre='$sfr'";
    $_SESSION['name'] = $_POST['userName1'];
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

if(mysqli_num_rows($result)!=0 &&  ($_SESSION['name']=='ygmr' ||$_SESSION['name']=='glsn' ))
{
    $data= array ('sonuc'=>'1');
    
}
elseif(mysqli_num_rows($result)!=0 )
{
    $data= array ('sonuc'=>'2');
    }
else
{
    $data= array ('sonuc'=>'0');

}
echo json_encode($data);




?>

