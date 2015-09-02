$(document).ready(function() {
$("#1").click(function () {

       var form_data =
        {
            tur: "corba"
        };

        $.ajax({
            url:'yemekgetir.php',
            type:'POST',
            data:form_data,
            success: function(result)
            {
                $("#icerik").html(result);
            },
            error: function()
            {
                alert("Hatazzzzz meydana geldi. Lütfen tekrar deneyiniz !!!");

            }
        });

    });
	$("#2").click(function () {

       var form_data =
        {
            tur: "et"
        };

        $.ajax({
            url:'yemekgetir.php',
            type:'POST',
            data:form_data,
            success: function(result)
            {
                $("#icerik").html(result);
            },
            error: function()
            {
                alert("Hatazzzzz meydana geldi. Lütfen tekrar deneyiniz !!!");

            }
        });

    });
	$("#3").click(function () {

       var form_data =
        {
            tur: "hamur"
        };

        $.ajax({
            url:'yemekgetir.php',
            type:'POST',
            data:form_data,
            success: function(result)
            {
                $("#icerik").html(result);
            },
            error: function()
            {
                alert("Hatazzzzz meydana geldi. Lütfen tekrar deneyiniz !!!");

            }
        });

    });
	
	
	$("#4").click(function () 
	{

       var form_data =
        {
            tur: "salata"
        };

        $.ajax({
            url:'yemekgetir.php',
            type:'POST',
            data:form_data,
            success: function(result)
            {
                $("#icerik").html(result);
            },
            error: function()
            {
                alert("Hatazzzzz meydana geldi. Lütfen tekrar deneyiniz !!!");

            }
        });

    });
	
	
	$("#5").click(function () {

       var form_data =
        {
            tur: "tatli"
        };

        $.ajax({
            url:'yemekgetir.php',
            type:'POST',
            data:form_data,
            success: function(result)
            {
                $("#icerik").html(result);
            },
            error: function()
            {
                alert("Hatazzzzz meydana geldi. Lütfen tekrar deneyiniz !!!");

            }
        });

    });
	
	
    $(".login").click(function () {

        $.ajax({
            url: "login.php",

            success: function (result) {
                $("#icerik").html(result);
            },
            error: function () {
                alert("Hata meydana geldi. Lutfen tekrar deneyiniz !!!");
            }
        });
    });
$("#btn").click(function () 
{


       $("#icerik").load("Guvenlik/Cikis.php");
    });
	
	
	$("#10").click(function () 
	{
       $("#icerik").load("sonuc.php");
    });
	
	
	
	$("#tariif").click(function () 
	{
 $("#icerik").load("tarifekle.php");
    });
    $("#dogruMu").click(function () {

        $.ajax({
            url: "tarifekle.php",

            success: function (result) {
                $("#icerik").html(result);
            },
            error: function () {
                alert("Hata meydana geldi. Lutfen tekrar deneyiniz !!!");
            }
        });
    });
	



    $("#register").click(function () {


        $.ajax({
            url: "create_account.php",

            success: function (result) {
                $("#icerik").html(result);
            },
            error: function () {
                alert("Hata meydana geldi. Lutfen tekrar deneyiniz !!!");
            }
        });
    });

    $(".creat").click(function () {

        $.ajax({
            url: "create_account.php",

            success: function (result) {
                $("#icerik").html(result);
            },
            error: function () {
                alert("Hata meydana geldi. Lutfen tekrar deneyiniz !!!");
            }
        });
    });
	

    $("#tavsiye").click(function () {

        $.ajax({
            url: "icerik/tavsiyeler.php",

            success: function (result) {
                $("#icerik").html(result);
            },
            error: function () {
                alert("Hata meydana geldi. Lutfen tekrar deneyiniz !!!");
            }
        });
    });

    $("#pratik").click(function () {

        $.ajax({
            url: "icerik/pratik.html",

            success: function (result) {
                $("#icerik").html(result);
            },
            error: function () {
                alert("Hata meydana geldi. Lutfen tekrar deneyiniz !!!");
            }
        });
    });

    $("#sifali").click(function () {

        $.ajax({
            url: "icerik/sifali.html",

            success: function (result) {
                $("#icerik").html(result);
            },
            error: function () {
                alert("Hata meydana geldi. Lutfen tekrar deneyiniz !!!");
            }
        });
    });

   


    $("#umit").click(function () {

        $.ajax({
            url: "icerik/umit.html",

            success: function (result) {
                $("#icerik").html(result);
            },
            error: function () {
                alert("Hata meydana geldi. Lutfen tekrar deneyiniz !!!");
            }
        });
    });
	
	
    $("#ayse").click(function () 
	{

        $.ajax({
            url: "icerik/ayse.html",

            success: function (result) {
                $("#icerik").html(result);
            },
            error: function () {
                alert("Hata meydana geldi. Lutfen tekrar deneyiniz !!!");
            }
        });
    });
	
	
    $("#oktay").click(function () {

        $.ajax({
            url: "icerik/oktay.html",

            success: function (result) {
                $("#icerik").html(result);
            },
            error: function () {
                alert("Hata meydana geldi. Lutfen tekrar deneyiniz !!!");
            }
        });
    });
    $("#refika").click(function () {

        $.ajax({
            url: "icerik/refika.html",

            success: function (result) {
                $("#icerik").html(result);
            },
            error: function () {
                alert("Hata meydana geldi. Lutfen tekrar deneyiniz !!!");
            }
        });
    });



});
$(document).ready(function() {
   
    $("#dogruMu").click(function () {

        $.ajax({
            url: "index.php",

            success: function (result) {
                $("#icerik").html(result);
            },
            error: function () {
                alert("Hata meydana geldi. Lutfen tekrar deneyiniz !!!");
            }
        });
    });
});