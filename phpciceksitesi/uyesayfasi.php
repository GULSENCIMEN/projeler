
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN"
    "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>ÇİCEK</title>
<link rel="stylesheet"  type="text/css" href="CSS/Bicim.css" />

<script src="JS/jquery-1.9.1.js"></script>
<style>
<!--
.chat_wrapper {
	width: 250px;
	margin-right: auto;
	margin-left: auto;
	background: #CCCCCC;
	border: 1px solid #999999;
	padding: 10px;
	font: 12px 'lucida grande',tahoma,verdana,arial,sans-serif;
}
.chat_wrapper .message_box {
	background: #FFFFFF;
	height: 120px;
	overflow: auto;
	padding: 10px;
	border: 1px solid #999999;
}
.chat_wrapper .panel input{
	padding: 2px 2px 2px 5px;
}
.system_msg{color: #BDBDBD;font-style: italic;}
.user_name{font-weight:bold;}
.user_message{color: #88B6E0;}
-->
</style>

<?php
    require_once 'uyedenetim.php';
	$colours = array('007AFF','FF7000','FF7000','15E25F','CFC700','CFC700','CF1100','CF00BE','F00');
$user_colour = array_rand($colours);
?>

<script>
    $(document).ready(function(){
        $("#ortaform").load("biryillik.php");
		//create a new WebSocket object.
	var wsUri = "ws://localhost:9000/demo/server.php"; 	
	websocket = new WebSocket(wsUri); 
	
	websocket.onopen = function(ev) { // connection is open 
		$('#message_box').append("<div class=\"system_msg\">Connected!</div>"); //notify user
	}

	$('#send-btn').click(function(){ //use clicks message send button	
		var mymessage = $('#message').val(); //get message text
		var myname = $('#name').val(); //get user name
		
		if(myname == ""){ //empty name?
			alert("Enter your Name please!");
			return;
		}
		if(mymessage == ""){ //emtpy message?
			alert("Enter Some message Please!");
			return;
		}
		
		//prepare json data
		var msg = {
		message: mymessage,
		name: myname,
		color : '<?php echo $colours[$user_colour]; ?>'
		};
		//convert and send data to server
		websocket.send(JSON.stringify(msg));
	});
	
	//#### Message received from server?
	websocket.onmessage = function(ev) {
		var msg = JSON.parse(ev.data); //PHP sends Json data
		var type = msg.type; //message type
		var umsg = msg.message; //message text
		var uname = msg.name; //user name
		var ucolor = msg.color; //color

		if(type == 'usermsg') 
		{
			$('#message_box').append("<div><span class=\"user_name\" style=\"color:#"+ucolor+"\">"+uname+"</span> : <span class=\"user_message\">"+umsg+"</span></div>");
		}
		if(type == 'system')
		{
			$('#message_box').append("<div class=\"system_msg\">"+umsg+"</div>");
		}
		
		$('#message').val(''); //reset text
	};
	
	websocket.onerror	= function(ev){$('#message_box').append("<div class=\"system_error\">Error Occurred - "+ev.data+"</div>");}; 
	websocket.onclose 	= function(ev){$('#message_box').append("<div class=\"system_msg\">Connection Closed</div>");}; 
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
                    //alert("heyyyy");
                    $("#ortaform").html(sunucudanGelenVeri);
                },
                error: function()
                {
                    alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                }
            });

            return false;

        });
        $("#cikis").click(function(){

            window.location="cikis.php";

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
        $("#yorumgonder").click(function(){

            var yorum = $('#yorum').val();
            if (!yorum)
            {
                alert("lütfen yorumunuzu giriniz");
                return false;
            }
            var form_data =
            {
                yorum : $('#yorum').val()
            };
            $.ajax({
                url: "yorumgonder.php",
                type: 'POST',
                data: form_data,
                success: function(sunucudanGelenVeri)
                {
                    alert("yorumunuz eklenmiştir");
                    //$("#ortaform").html(sunucudanGelenVeri);
                },
                error: function()
                {
                    alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
                }
            });

            return false;

        });
        $("#tumyorum").click(function(){

            var form_data =
            {
                yorum : $('#yorum').val()
            };
            $.ajax({
                url: "yorumlar.php",
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
        $("#anasayfa").click(function(){
            window.location = 'uyesayfasi.php';
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
        <li><a><?php echo "AKTİF ÜYE:&nbsp;".$_SESSION['uyead']."&nbsp;&nbsp;".$_SESSION['uyesoyad']."&nbsp;&nbsp;&nbsp;"?></a>
    <ul>
        <li><a id="cikis" name="cikis">OTURUMU KAPAT<hr></a></li>
    </ul>
     </li>
    </ul>
</div>

</head>

<body>

<div id="ortaform">

</div>

<div id="yanform">
    <br/><th>
        
       
        <ul>ÇİCEK ARAMA</ul>
        <ul>Adini giriniz:</ul>
        <ul>  <input type="text" id="adi" name="adi" style="color: #9e84f5;"  /></ul>
       
        <br/>
        <ul>YORUMUNUZU GİRİNİZ</ul>
        <ul> <textarea id='yorum' rows='10' cols='28' value="deger1" style="color: #9e84f5;"></textarea></ul>
        <ul> <input type="submit" id="yorumgonder" name="yorumgonder" value="YORUMU GÖNDER" style="color: #9e84f5;background-color: #ffb4ec"/>
            <input type="submit" id="tumyorum" name="tumyorum" value="TÜM YORUMLAR" style="color: #9e84f5;background-color: #ffb4ec"/></ul>
    </th>
	<br>
	<div>
	ONLİNE KULLANICILARA MESAJ GÖNDER
	<div class="chat_wrapper">
<div class="message_box" id="message_box"></div>
<div class="panel">
<input type="text" name="name" id="name" placeholder="Nick" maxlength="10" style="width:20%"  />
<input type="text" name="message" id="message" placeholder="Mesaj" maxlength="80" style="width:71%" />
<button id="send-btn">Gönder</button>
</div>
</div>
	</div>

</div>
</body>

</html>
