<?php 
mysql_connect("localhost","root","");
mysql_selectdb("bs");
$calistir = mysql_query("select * from dersler where dersKodu='MAT 113'") or die("Hata Olustu!");
$oku = mysql_fetch_assoc($calistir);
mysql_query("SET NAMES UTF8");
mysql_query("SET character_set_connection='UTF8'");
mysql_query("SET character_set_client='UTF8'");
mysql_query("SET character_set_results='UTF8'");
?>

<!DOCTYPE html>
<html lang="tr">
<head>
    <meta http-equiv="Content-Type" content="text/HTML; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="bicim.css"/>
    <script src="JS/jquery-1.9.1.js"></script>
    <script>
	 $(document).ready(function(){
	 $('#icerkc').keyup(function() {
               var form_data =
               {
                  dersadi:$('#adc').val(),
				   derskodu:$('#kodc').val(),                  
                   dersinicerik:$('#icerkc').val()
               };
               $.ajax({
                   url: "adicerik_guncelle.php",
                   type: 'POST',
                   data: form_data,
                   success: function(msg)
                   {
                       
                   },
                   error: function()
                   {
                       alert("HATA VAR!!!");
                   }
               });
               return false;
           });
		   
		   
		   $('#adc').keyup(function() {
               var form_data =
               {
                   dersadi:$('#adc').val(),
				   derskodu:$('#kodc').val(),  
				dersinicerik:$('#icerkc').val()				   
                  
               };
               $.ajax({
                   url: "adicerik_guncelle.php",
                   type: 'POST',
                   data: form_data,
                   success: function(msg)
                   {
                      
                   },
                   error: function()
                   {
                       alert("HATA VAR !!!");
                   }
               });
               return false;
           });
		   
		   
		   
		   $('#listec').change(function() {
               var form_data =
               {
                   derskodu:$('#kodc').val(),                  
                   koordinator:$('#listec').val()
               };
               $.ajax({
                   url: "koordinatlariguncelle.php",
                   type: 'POST',
                   data: form_data,
                   success: function(msg)
                   {
                       
                   },
                   error: function()
                   {
                       alert("HATA VAR !!!");
                   }
               });
               return false;
           });
	  
	});
        </script>
    </head>
<body>
 <form action="" method="post">
<table>
<tbody style="background-color: #afeeee; width:800px" >
<tr>
    <td>
        DERSIN KODU
    </td>
	<td><input type='text' disabled="disabled" id="kodc" value="
<?PHP echo $oku['dersKodu']; ?>"/>
</td>
<tr>
    <td>
        DERSIN ADI
    </td>
    <td colspan="6"><input  id="adc" type="text" value=" <?PHP echo $oku['dersAdi']; ?>" /></td>
</tr>
<tr>
    <td>
      KOORDINATOR
    </td>
    <td colspan="6"><select id="listec">
        <option value="1">
		<?php
 
mysql_connect("localhost","root","");
mysql_selectdb("bs");
$calistir1=mysql_query("SELECT * FROM dersler inner join koordinator on koordinator.sicilNo=dersler.sicilNo WHERE dersKodu='MAT 113'");
while($oku1=mysql_fetch_array($calistir1))
{
   echo $oku1["Adi"];
}
?>
</option>
<?php
$calistir1=mysql_query("SELECT * FROM koordinator");
while($oku1=mysql_fetch_array($calistir1))
{
 echo "<option value='.$oku1[sicilNo].'>";
 echo $oku1["Adi"];
 echo'</option>';
}
?>  </select></td>
</tr>
<tr>
    <td>
        ICERIK
    </td>
    <td><textarea cols="60" rows='3' name="icerik" id="icerkc"> 
<?PHP echo $oku['icerik']; ?>
	</textarea></td>
</tr>
</tbody>
</table>
</form>
</body>
</html>