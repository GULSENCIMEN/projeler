<?php mysql_query("SET NAMES UTF8"); ?>
<?php
require_once("header.php");
require_once("menu.php");
$baglanti=mysql_connect("localhost","root","");
mysql_selectdb("yemeksite");
mysql_query("SET NAMES UTF8");
$aramasorgusu = @mysql_real_escape_string($_GET['aramasorgusu']);
$sonucsorgu = @mysql_query("SELECT * FROM yemekler WHERE yemek_adi LIKE '%".$aramasorgusu."%'" );
if(@mysql_num_rows($sonucsorgu)>0){
 while($sorguoku=@mysql_fetch_array($sonucsorgu)){

  
 echo "<br><table border='2'> 
<tr>
<td>YEMEK ADI</td>
<td>MALZEMELER</td>
<td>TARIF</td>
<td>RESIM</td>
</tr>

<tr>
<td>  ".$sorguoku["yemek_adi"]."</td>
<td>  ".$sorguoku["malzeme"]."</td>
<td>".$sorguoku["tarif"]." </td>
<td><img width='100' height='100'  src='".$sorguoku['resim_adi']."'></td>

</tr></table>";
  
 }
}
else{
 echo 'Aradýðýnýz Ýçerik Bulunamadý';
}
?>