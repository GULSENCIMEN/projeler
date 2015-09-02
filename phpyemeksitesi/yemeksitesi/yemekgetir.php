<?php
$tur= $_POST['tur'];
$baglanti=mysql_connect("localhost","root","");
mysql_selectdb("yemeksite");
mysql_query("SET NAMES UTF8");
?>
<div style="width:80% ">
    <ul>
<?php

$duzenle = mysql_query("SELECT * FROM yemekler WHERE yemek_turu='$tur'") ;
while($yaz=mysql_fetch_array($duzenle))
{
echo "<br><table> 
<tr>
<td>YEMEK ADI</td>
<td>MALZEMELER</td>
<td>TARIF</td>
<td>RESIM</td>
</tr>

<tr>
<td>  ".$yaz["yemek_adi"]."</td>
<td>  ".$yaz["malzeme"]."</td>
<td>".$yaz["tarif"]." </td>
<td><img width='100' height='100'  src='".$yaz['resim_adi']."'></td>

</tr></table>";

}

?>




</div>