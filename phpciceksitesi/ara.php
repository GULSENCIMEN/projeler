<?php

require_once 'veritabanibaglanti.php';

$sql="SELECT *FROM cicekler where adi Like '".$_POST['ad']."%'";


$result = mysqli_query($baglantiNo,$sql);

mysqli_set_charset($baglantiNo,"utf-8");
mysqli_query($baglantiNo,"SET COLLATION_CONNECTION = 'utf8_turkish_ci' ");

mysqli_close($baglantiNo);


echo "<table id='mytable'>";
while ($row = mysqli_fetch_array($result)) {
    echo "
		<tr>
			";
    echo "<td>".$row['adi']."</td>";
    echo "<td>".$row['ozellikler']."</td>";
    echo "<td><img width='100' height='100'  src='".$row['resimyolu']."'></td>";
        echo "</tr>";
}
mysqli_free_result($result);
echo "</table>";

?>

