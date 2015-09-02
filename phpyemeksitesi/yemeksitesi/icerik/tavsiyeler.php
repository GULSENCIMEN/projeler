
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<?php
mysql_connect("localhost","root","");
mysql_selectdb("yemeksite");


?>
<div style="width:80% ">
    <ul>

<h1>Cesitli Konularda Guzel Tavsiyeler</h1>

  <?php 
   $cek=mysql_query("SELECT * FROM tavsiyeler ");
while($yaz=mysql_fetch_array($cek))
{
   echo "<br><textarea rows='3' cols='100' >  ".$yaz["tavsiye"]."</textarea>";

}




?>
</textarea>
    </ul>
</div>



</body>
</html>

