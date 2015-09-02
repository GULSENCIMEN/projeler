<?php
session_start();
 ?>
<script  type="text/javascript" src="JS/jquery-1.9.1.js"></script>
<script  type="text/javascript" src="JS/jquery.history.js"></script>
<script  type="text/javascript" src="JS/jquery.js"></script>
<script  type="text/javascript" src="JS/jquery-12.js"></script>
<script  type="text/javascript" src="JS/jquery-ui-1.8.11.custom.min.js"></script>
<div  class="col_2 left" >
    <h3>Kullanici Adi Sifrenizi Giriniz </h3>

        <div class=" left">
            <label for="fullname">Kullanici Adi:</label>
            <input name="un" type="text" class="required input_field" id="userName" maxlength="40" />
        </div>
        <div class="right">
            <label for="email">Sifre:</label>
            <input name="pw" type="password" class="required input_field" id="sifre" maxlength="40" />
        </div>

        <div class="clear h10"></div>
        <p>
            <input type="submit" id="btndogrula" name="Giris" value="Giris" class="more left"  />
        </p>
        <div class="clear"></div>
       <div id="msj"></div>

        Uye Olmak Icin <a id="register" href="#">Tiklayiniz..</a>

</div>

<script   type="text/javascript">


        $("#btndogrula").click(function()
        {
            var userName = $('#userName').val();
            var sifre = $('#sifre').val();

            if (!userName || !sifre)
            {

                    if (!userName){ $("#userName").focus();$("#msj").html("Lütfen Kullanıcı adınızı giriniz!!!").slideDown("1500");}

                    else{  $("#sifre").focus();$("#msj").html("Lütfen şifrenizi giriniz!!!").slideDown("1500");}


                return false;
            }

            var form_data =
            {
                userName1 : $('#userName').val(),
                sifre1 : $('#sifre').val()
            };

              $.ajax(
                {
                    url : "Dogrula.php",
                    type : 'POST',
                    dataType : 'json',
                    data : form_data,
                    success : function(data)
                    {
                        var sonuc = data['sonuc'];
                       
                        if (sonuc == '1' || sonuc=='2')
                        {  $("#msj").html("Kayıt var!!!").slideDown("1500");
                            if(sonuc == '1')
                                goMypage();
                           else
                                goIndex();
                        }
                        else
                        {
                            $("#msj").html("Kayıt yok!!!").slideDown("1500");

                        }

                    },
                    error : function()
                    {
                        alert("Hata meydana geldi. Lütfen tekrar deneyinizzzzz !!!");
                    }
                });


        });
        function goMypage()
        {
            window.location = 'index.php';
            // Kayıtlı öğrenci
        }
        function goIndex()
        {
            window.location = 'index.php';
            // Kayıtlı öğrenci
        }


</script>