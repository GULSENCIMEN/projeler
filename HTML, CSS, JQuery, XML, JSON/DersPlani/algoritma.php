<?php 
 mysql_connect("localhost","root","");
mysql_selectdb("bs");
$calistir = mysql_query("select * from dersler where dersKodu='BSM 103'") or die("Hata Olustu!");
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
	 $('#icerka').keyup(function() {
               var form_data =
               {
                  dersadi:$('#ada').val(),
				   derskodu:$('#koda').val(),                  
                   dersinicerik:$('#icerka').val()
               };
               $.ajax({
                   url: "adicerik_guncelle.php",
                   type: 'POST',
                   data: form_data,
                   success: function(msg)
                   {
                       // alert("heyyyyyyy");
                   },
                   error: function()
                   {
                       alert("HATA VAR  !!!");
                   }
               });
               return false;
           });
		   
		   
		   $('#ada').keyup(function() {
               var form_data =
               {
                   dersadi:$('#ada').val(),
				   derskodu:$('#koda').val(),  
				dersinicerik:$('#icerka').val()				   
                  
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
                       alert("HATA VAR  !!!");
                   }
               });
               return false;
           });
		   
		   
		   
		   $('#listea').change(function() {
               var form_data =
               {
                   derskodu:$('#koda').val(),                  
                   koordinator:$('#listea').val()
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
                       alert("HATA VAR  !!!");
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
    <td name="kod">
        DERSIN KODU
    </td>
	<td><input type='text'disabled="disabled"  id="koda" value="
<?PHP echo $oku['dersKodu']; ?>"/>
</td>
<tr>
    <td>
       DERSIN ADI
    </td>
    <td colspan="6"><input name="metin" id="ada" type="text" value=" <?PHP echo $oku['dersAdi']; ?>" /></td>
</tr>

<tr>
    <td>
       KOORDINATOR
    </td>
    <td colspan="6"><select name="liste" id="listea">
        <option value="1">
		<?php
  
  
mysql_connect("localhost","root","");
mysql_selectdb("bs");


  $cek=mysql_query("SELECT * FROM dersler inner join koordinator on koordinator.sicilNo=dersler.sicilNo WHERE dersKodu='BSM 103'");
while($yaz=mysql_fetch_array($cek))
{
   echo $yaz["Adi"];

}
?>
</option>


      
				<?php
  
  
mysql_connect("localhost","root","");
mysql_selectdb("bs");


  $cek=mysql_query("SELECT * FROM koordinator");
while($yaz=mysql_fetch_array($cek))
{
  echo "<option value='.$yaz[sicilNo].'>";


   echo $yaz["Adi"];
 echo'</option>';
}
?>
		
   
    </select></td>
</tr>

<tr>
    <td>
        ICERIK
    </td>
    <td colspan="5"><textarea cols="60" rows='3' name="icerik" id="icerka"> 
<?PHP echo $oku['icerik']; ?>
	</textarea></td>
</tr>
</tbody>
</table>
</form>
</body>
</html>
