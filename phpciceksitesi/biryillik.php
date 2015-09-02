<?php

 /* Created by PhpStorm.
 * User: user
 * Date: 26.05.2014
 * Time: 20:31*/

require_once 'veritabanibaglanti.php';

$sql="SELECT c.adi cicekadi,c.ozellikler cicekozellik,c.resimyolu cicekresim,t.turadi tur,t.turozellik turozellik FROM cicekler c inner join cicekturu t on c.turid=t.turid where c.turid='1'";
$sql1="SELECT *FROM cicekturu WHERE turid='1'";
$result = mysqli_query($baglantiNo,$sql);
$result1 = mysqli_query($baglantiNo,$sql1);

mysqli_set_charset($baglantiNo,"utf-8");

mysqli_query($baglantiNo,"SET COLLATION_CONNECTION = 'utf8_turkish_ci' ");

mysqli_close($baglantiNo);
$row1 = mysqli_fetch_array($result1);
echo "<table id='mytable'>";
echo "<tr>";
  echo "<td>".$row1['turadi']."</td>";
  echo "<td>".$row1['turozellik']."</td>";
echo "</tr>";

echo "<table id='mytable'>
        <tr colspan='3'>ÇİÇEK ÖRNEKLERİ</tr>";
while ($row = mysqli_fetch_array($result))
{
    echo "<tr>";
    echo "<td>".$row['cicekadi']."</td>";
    echo "<td>".$row['cicekozellik']."</td>";
    echo "<td><img width='100' height='100'  src='".$row['cicekresim']."'></td>";
    echo "</tr>";
}

mysqli_free_result($result);

echo "</table>";

?>