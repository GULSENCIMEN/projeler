<?php
?>
<script src="JS/jquery-1.9.1.js"></script>
<script>
$(document).ready(function(){

$("#uyekaydet").click(function(){

    var ad = $('#adi').val();
    var soyad = $('#soyadi').val();
    var sifre = $('#sifre').val();
    if (!ad || !sifre || !sifre)
    {
        alert("Alanlar bos olamaz");
        return false;
    }
    var form_data =
        {
            ad: $("#adi").val(),
            soyad:$("#soyadi").val(),
            sifre:$("#sifre").val()
        };
        $.ajax({
            url: "kaydet.php",
            type: 'POST',
            data: form_data,
            success: function(sunucudanGelenVeri)
            {
               // alert("heyyyyyyy");
               $("#uyeform").show("fast");
            },
            error: function()
            {
                alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");
            }
        });

        return false;

    });
});
</script>

<html>
<div style="width:250px; height: 200px; top: 100px" >
    <br/>
    <br/>
    <br/>
    Adi:
    <br/>
    <input type="text" id="adi" style="color:#9e84f5; "  />
    <br/>
    <br/>
    Soyadi:
    <br/>
        <input type="text" id="soyadi" style="color: #9e84f5;" />
    <br/>
    <br/>
    Sifre :
    <br/>
        <input type="text" id="sifre" style="color: #9e84f5;"  />
    <br/>
    <br/>
        <input type="submit" style="color: #9e84f5; background-color: #ffb4ec" id="uyekaydet" value="ÜYE KAYDET"/>
    <div id="uyeform" hidden="true" style="top:500px;">
        <p>Kayıt işleminiz başarıyla gercekleştirildi!</p>
        <p>Anasayfaya dönüp giriş yapabilirsiniz</p>
    </div>
</div>


</html>



