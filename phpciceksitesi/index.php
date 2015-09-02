
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN"
    "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>ÇİÇEK</title>

    <link rel="stylesheet"  type="text/css" href="CSS/Bicim.css" />

    <script src="JS/jquery-1.9.1.js"></script>

<?php
require_once 'veritabanibaglanti.php';
?>

    <script>
      $(document).ready(function(){
          $("#ortaform").load("biryillik.php");
        $("#adi").keyup(function(){
       var form_data =
        {
            ad: $("#adi").val()
        };
        $.ajax({
            url: "ara.php",
            type: 'POST',
            data: form_data,
            success: function(sunucudanGelenVeri)
            {

                $("#ortaform").html(sunucudanGelenVeri);
            },
            error: function()
            {
                alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
            }
        });

        return false;

    });

          $("#giris").click(function()
          {
              var uye = $('#uyeid').val();
              var sifre = $('#sifreid').val();
              if (!uye || !sifre)
              {
                  alert("ad veya sifre bos olamaz");
                  return false;
              }

              var form_data =
              {
                  uye : $('#uyeid').val(),
                  sifre:$('#sifreid').val()
              };

              $.ajax(
                  {

                      url : "kontrol.php",
                      type : 'POST',
                      dataType : 'json',
                      data : form_data,
                      success : function(data)
                      {

                          var sonuc = data['sonuc'];
                          if (sonuc == '1')
                          {
                            window.location = 'uyesayfasi.php';

                              return false;
                          }
                          else
                          {
                              alert("KAYIT BULUNAMADI. LÜTFEN BİLGİLERİNİZİN DOĞRULUĞUNDAN EMİN OLUN.");
                              return false;
                          }

                      },
                      error : function()
                      {
                          alert("Hata meydana geldi. Lütfen tekrar deneyinizzzzz !!!");
                      }
                  });

              return false;
          });
          $("#biryillik").click(function(){
              var form_data =
              {
                  turid:'1'
              };
              $.ajax({
                  url: "cicektur.php",
                  type: 'POST',
                  data: form_data,
                  success: function(sunucudanGelenVeri)
                  {
                      $("#ortaform").html(sunucudanGelenVeri);
                  },
                  error: function()
                  {
                      alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                  }
              });

              return false;

          });
          $("#cokyillik").click(function(){
              var form_data =
              {
                  turid:'2'
              };
              $.ajax({
                  url: "cicektur.php",
                  type: 'POST',
                  data: form_data,
                  success: function(sunucudanGelenVeri)
                  {

                      $("#ortaform").html(sunucudanGelenVeri);
                  },
                  error: function()
                  {
                      alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                  }
              });

              return false;

          });
          $("#soganli").click(function(){
              var form_data =
              {
                  turid:'3'
              };
              $.ajax({
                  url: "cicektur.php",
                  type: 'POST',
                  data: form_data,
                  success: function(sunucudanGelenVeri)
                  {

                      $("#ortaform").html(sunucudanGelenVeri);
                  },
                  error: function()
                  {
                      alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                  }
              });

              return false;

          });
          $("#yumrulu").click(function(){
              var form_data =
              {
                  turid:'4'
              };
              $.ajax({
                  url: "cicektur.php",
                  type: 'POST',
                  data: form_data,
                  success: function(sunucudanGelenVeri)
                  {

                      $("#ortaform").html(sunucudanGelenVeri);
                  },
                  error: function()
                  {
                      alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                  }
              });

              return false;

          });

          $("#ilkbahar").click(function(){
              var form_data =
              {
                  bakimid:'1'
              };
              $.ajax({
                  url: "bakim.php",
                  type: 'POST',
                  data: form_data,
                  success: function(sunucudanGelenVeri)
                  {

                      $("#ortaform").html(sunucudanGelenVeri);
                  },
                  error: function()
                  {
                      alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                  }
              });

              return false;

          });
          $("#yaz").click(function(){
              var form_data =
              {
                  bakimid:'2'
              };
              $.ajax({
                  url: "bakim.php",
                  type: 'POST',
                  data: form_data,
                  success: function(sunucudanGelenVeri)
                  {

                      $("#ortaform").html(sunucudanGelenVeri);
                  },
                  error: function()
                  {
                      alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                  }
              });

              return false;

          });
          $("#sonbahar").click(function(){
              var form_data =
              {
                  bakimid:'3'
              };
              $.ajax({
                  url: "bakim.php",
                  type: 'POST',
                  data: form_data,
                  success: function(sunucudanGelenVeri)
                  {

                      $("#ortaform").html(sunucudanGelenVeri);
                  },
                  error: function()
                  {
                      alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                  }
              });

              return false;

          });
          $("#kis").click(function(){
              var form_data =
              {
                  bakimid:'4'
              };
              $.ajax({
                  url: "bakim.php",
                  type: 'POST',
                  data: form_data,
                  success: function(sunucudanGelenVeri)
                  {

                      $("#ortaform").html(sunucudanGelenVeri);
                  },
                  error: function()
                  {
                      alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                  }
              });

              return false;

          });
          $("#saksi").click(function(){
              var form_data =
              {
                  bakimid:'5'
              };
              $.ajax({
                  url: "bakim.php",
                  type: 'POST',
                  data: form_data,
                  success: function(sunucudanGelenVeri)
                  {
                      $("#ortaform").html(sunucudanGelenVeri);
                  },
                  error: function()
                  {
                      alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                  }
              });

              return false;

          });
          $("#sulama").click(function(){
              var form_data =
              {
                  bakimid:'6'
              };
              $.ajax({
                  url: "bakim.php",
                  type: 'POST',
                  data: form_data,
                  success: function(sunucudanGelenVeri)
                  {

                      $("#ortaform").html(sunucudanGelenVeri);
                  },
                  error: function()
                  {
                      alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                  }
              });

              return false;

          });
          $("#gubreleme").click(function(){
              var form_data =
              {
                  bakimid:'7'
              };
              $.ajax({
                  url: "bakim.php",
                  type: 'POST',
                  data: form_data,
                  success: function(sunucudanGelenVeri)
                  {

                      $("#ortaform").html(sunucudanGelenVeri);
                  },
                  error: function()
                  {
                      alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                  }
              });

              return false;

          });
          $("#bitbocek").click(function(){
              var form_data =
              {
                  bakimid:'8'
              };
              $.ajax({
                  url: "bakim.php",
                  type: 'POST',
                  data: form_data,
                  success: function(sunucudanGelenVeri)
                  {
                    $("#ortaform").html(sunucudanGelenVeri);
                  },
                  error: function()
                  {
                      alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                  }
              });

              return false;

          });

          $("#budama").click(function(){
              var form_data =
              {
                  bakimid:'9'
              };
              $.ajax({
                  url: "bakim.php",
                  type: 'POST',
                  data: form_data,
                  success: function(sunucudanGelenVeri)
                  {
                      // alert("heyyyy");
                      $("#ortaform").html(sunucudanGelenVeri);
                  },
                  error: function()
                  {
                      alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                  }
              });

              return false;

          });
		       $("#burclar").click(function () {

       xmlhttp=new XMLHttpRequest();
                xmlhttp.onreadystatechange=function()
                {
                    if (xmlhttp.readyState==4 && xmlhttp.status==200)
                    {
                        xmlDoc=xmlhttp.responseXML;
						var txt="<br>";
                        txt=txt +"<table border='2' ;' id='ogrenmeciktitablosu'>";
                        var x=xmlDoc.getElementsByTagName("PROGRAM");
						txt=txt + '<tr style="height: 25px;background-color: pink">'+
						'<td style="width: 100px"><b>BURÇLAR</td>'+
						'<td style="width: 400px"><b>TARİHLERİ</td>'+
						'<td style="width: 400px"><b>ÇİÇEKLER</td>'+
						"</tr>"
						
                        for ( var i=0;i<x.length;i++)
                        {
                            txt=txt + '<tr style="height: 25px">'+
                                '<td style="width: 100px;">'+
                                x[i].getElementsByTagName("BASLIK")[0].childNodes[0].nodeValue + "</td>"+
                               '<td style="width: 400px">'+
							'<b>'+x[i].getElementsByTagName("ICERIK")[0].childNodes[0].nodeValue +"</td>"+
							 '<td style="width: 400px">'+
							'<b>'+x[i].getElementsByTagName("AD")[0].childNodes[0].nodeValue +'</td></tr>';
							
						}
                        document.getElementById("ortaform").innerHTML=txt;
                    }
                }
                xmlhttp.open("GET","burclar.xml",true);
                xmlhttp.send();
    });
	
		$("#notlar").click(function () {
			$("#ortaform").empty();
		  $.ajax({
        url: "sonuc.json",
        dataType: "json",
        success: function(sonuc) {
                    $.each(sonuc.books.book, function (i, val) {
                        $("#ortaform").append('<div><h3>' + val.title + '</h3></div><div style="color: #000000;"><div>' + val.satir1 + '</div><div>' + val.satir2 + '</div><div>' + val.satir3 + '</div><div>' + val.satir4 + '</div></div><br>');
                    });
            }
    });
		});
	
	
			       $("#cicekanlamlari").click(function () {

       xmlhttp=new XMLHttpRequest();
                xmlhttp.onreadystatechange=function()
                {
                    if (xmlhttp.readyState==4 && xmlhttp.status==200)
                    {
                        xmlDoc=xmlhttp.responseXML;
						var txt="<br>";
                        txt=txt+ "<table border='2' ;' id='ogrenmeciktitablosu'>";
                        var x=xmlDoc.getElementsByTagName("PROGRAM");
						txt=txt + '<tr style="height: 25px;background-color: pink">'+
						'<td style="width: 200px"><b>ÇİÇEKLER</td>'+
						'<td style="width: 700px"><b>ANLAMLARI</td>'+
						"</tr>"
                        for ( var i=0;i<x.length;i++)
                        {
                            txt=txt + '<tr style="height: 25px">'+
                                '<td style="width: 200px;">'+
                                x[i].getElementsByTagName("BASLIK")[0].childNodes[0].nodeValue + "</td>"+
                               '<td style="width: 700px">'+
							'<b>'+x[i].getElementsByTagName("ICERIK")[0].childNodes[0].nodeValue +'</td></tr>';
							
						}
                        document.getElementById("ortaform").innerHTML=txt;
                    }
                }
                xmlhttp.open("GET","cicekanlamlari.xml",true);
                xmlhttp.send();
    });

          $("#uyeol").click(function(){
              $("#yanform").load("uyeol.php");
});

          $("#anasayfa").click(function(){
              window.location = 'index.php';
          });
      });


 </script>
    <img src="resim/menu.jpg" width="1345" height="100" >

    <div class="header-menu">

        <ul>
            <li><a id="anasayfa">ANASAYFA</a></li>
            <li><a >ÇİÇEK TÜRLERİ</a>
                <ul>
                    <li><a id="biryillik">BİR YILLIK ÇİÇEKLER</a></li>
                    <li><a id="cokyillik">ÇOK YILLIK ÇİÇEKLER</a></li>
                    <li><a id="soganli">SOĞANLI ÇİÇEKLER </a></li>
                    <li><a id="yumrulu">YUMRULU ÇİÇEKLER </a></li>
                </ul>
            </li>
            <li><a>MEVSİMLİK ÇİÇEK BAKIMI</a>
                <ul>
                    <li><a id="ilkbahar">İLKBAHAR BAKIMI</a></li>
                    <li><a id="yaz">YAZ BAKIMI</a></li>
                    <li><a id="sonbahar" >SONBAHAR BAKIMI</a></li>
                    <li><a id="kis">KIŞ BAKIMI </a></li>
                </ul>
            </li>
        <li><a>GENEL ÇİÇEK BAKIMI</a>
            <ul>
                <li><a id="saksi">SAKSI DEĞİŞTİRME</a></li>
                <li><a id="sulama">SULAMA</a></li>
                <li><a id="budama">BUDAMA </a></li>
                <li><a id="gubreleme">GÜBRELEME </a></li>
                <li><a id="bitbocek">BİT/BÖCEK </a></li>
        </ul>
        </li>
            <li><a id="uyeol">ÜYE OL</a>
        </ul>
    </div>

</head>

<body>

<div id="ortaform">
</div>

<div id="yanform">
    <br/>
    <br/>
    <th style="color:#9e84f5;">ÇİCEK ARAMA<br/>

    <ul>Adini giriniz:</ul>
        <ul>
        <input type="text" id="adi" name="adi" style="color:#9e84f5;" /></ul>
        <br/>
        <br/>
        <br/>
        <?php
        $sql="SELECT uy.uyead ad,yo.yorumicerik yor,yo.tarih tarih FROM yorum yo inner join uye uy on yo.uyeid=uy.uyeid";

        $result = mysqli_query($baglantiNo,$sql);

        mysqli_set_charset($baglantiNo,"utf-8");
        mysqli_query($baglantiNo,"SET COLLATION_CONNECTION = 'utf8_turkish_ci' ");

        mysqli_close($baglantiNo);

        ?>
        <ul style="text-align: left; color: #9e84f5;">YORUMLAR</ul>
        <ul><marquee align="middle" scrollamount="1" height="140px" width="250px" direction="up" style="text-align: left; color: #ffb4ec;" scrolldelay="1">
                <?php
                while ($row = mysqli_fetch_array($result)) {
                    echo $row['ad']."&nbsp&nbsp&nbsp&nbsp&nbsp".$row['tarih'];
                    echo"<br/>";
                    echo $row['yor'];
                    echo"<br/>";
                    echo"<br/>";

                }
                mysqli_free_result($result);
         echo "</marquee>  </ul>";


?>
<br>
       <ul style="color: #9e84f5;">ÜYE GİRİŞİ</ul>
        <ul>AD&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type="text" id="uyeid" style="color: #9e84f5;"/></ul>
        <ul>ŞİFRE &nbsp;  <input type="password"  id="sifreid" name="sifre" style="color: #9e84f5;"/></ul>
    <ul><input type="submit" style="color: #9e84f5;background-color:#ffb4ec; " id="giris" name="giris" value="Giriş"/></ul>
<br>
<br>

	<div style="width:200px;height:100px;background-color:#ffb4ec;padding-left:50px; font-size:1em;font-family:Arial, Helvetica, sans-serif;color:#000000">
	<br>
	<a href="#" id="cicekanlamlari" style="text-decoration:none">ÇİÇEK ANLAMLARI</a>
	<br>
	<a href="#" id="burclar"style="text-decoration:none">BURÇLAR VE ÇİÇEKLER</a>
	<br>
	<a href="#" id="notlar"style="text-decoration:none">ÇİCEK EŞLİĞİNDE NOTLAR</a>
	
	</div>
	
	</div>
</body>

</html>
