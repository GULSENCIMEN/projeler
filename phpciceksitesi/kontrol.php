
<?php
require_once 'veritabanibaglanti.php';


$sql="SELECT  uyeid,uyead,uyesoyad FROM uye where uyead='".$_POST['uye']."' and sifre='".$_POST['sifre']."'";


$result = mysqli_query($baglantiNo,$sql);
$row = mysqli_fetch_array($result);

mysqli_close($baglantiNo);

if(mysqli_num_rows($result)!=0)
{
    session_start();

    $_SESSION['uyead'] = $_POST['uye'];
    $_SESSION['uyesoyad'] =$row['uyesoyad'];
    $_SESSION['uyeid'] =$row['uyeid'];


    $_SESSION['baglandi'] =TRUE;

    $_SESSION['baslangicZamani']=time();

    $data= array ('sonuc'=>'1');
}
else
{
    $data= array ('sonuc'=>'0');
}

echo json_encode($data);
?>
