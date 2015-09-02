<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<meta http-equiv="Content-Language" content="TR"/>	

</head>

<?php
session_start();
require_once("header.php");

?>
<div>
<div class="menu_div" style="float: left">
    <ul>
        <li id="active"><a href="#">YEMEKLER</a></li>
        <li id="1"><a href="#">CORBALAR</a></li>
        <li id="2" ><a href="#">ET YEMEKLERI</a></li>
        <li id="3"><a href="#">HAMUR ISLERI</a></li>
        <li id="4"><a href="#">SALATALAR</a></li>
        <li id="5"><a href="#">TATLILAR</a></li>
       
    </ul>
</div>
    <div id="icerik" >

   <?php
   require_once("galeri.php");
   ?>
    </div>
	</div>	
</html>