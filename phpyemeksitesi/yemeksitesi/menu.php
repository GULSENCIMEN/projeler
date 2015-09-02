<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<meta http-equiv="Content-Language" content="TR"/>	
</head>


<div id="menu">
<ul>
  <li class="menu1"><a href="index.php" class="menu1">ANASAYFA  </a>
  </li>
    </li>
    <li class="menu1"><a href="#" id="tavsiye" class="menu1">  TAVSİYELER    </a>
    </li>
  <li class="menu1"><a href="#" class="menu1">ÜNLÜ AŞÇILAR </a>
	<ul>
        <li><a id="umit" href="#">Ümit Usta	</a></li>
        <li><a id="ayse" href="#">Ayşe Tüter	</a></li>
        <li><a id="oktay" href="#">Oktay Usta	</a></li>
        <li><a  id="refika" href="#">Refika Birgül</a></li>
	</ul>
  <li class="menu1"><a href="#"  class="creat1" id="tariif">TARİF EKLE</a>
</li>
  <li class="menu1"><a href="#" id="pratik" class="menu1">PRATİK BİLGİLER    </a></li>
  <li class="menu1"><a href="#" id="sifali" class="menu1">ŞİFALI BİLGİLER   </a></li>
    <li class="menu1"><a href="#" class="creat">UYE OL     </a></li>
  <li class="menu1"><a href="#" class="login">GIRIS YAP    </a></li>
  
</ul>
    <?php
    if(!isset($_SESSION['name']))
    {
        echo "Merhaba     :";
        echo "  ";
    }
    else
    { echo "Merhaba     :         ";   
	echo $_SESSION['name'];
	}
    ?>
	<div>
	<input type="submit" id="btn" name="ÇIKIŞ" value="ÇIKIŞ">
	<div>
	<br>
	
	<form action="sonuc.php" method="get" align="right">
 <input type="text" name="aramasorgusu" placeholder="Aramak istediğiniz kelimeyi yazınız"><br>
 <input type="submit" value="Ara" align="center">
</form>
</div>
