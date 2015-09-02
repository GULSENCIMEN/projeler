<?php

 ?>
<script  type="text/javascript" src="JS/jquery-1.9.1.js"></script>
<script  type="text/javascript" src="JS/jquery.history.js"></script>
<script  type="text/javascript" src="JS/jquery.js"></script>
<script  type="text/javascript" src="JS/jquery-12.js"></script>
<script  type="text/javascript" src="JS/jquery-ui-1.8.11.custom.min.js"></script>
<script>
    $(document).ready(function(){

        $('#btnKayıt').click(function() {

            var userName = $('#username').val();
            var sifre = $('#pswd').val();

            if (!userName || !sifre)
            {

                if (!userName){ $("#userName").focus();$("#msj2").html("Lütfen Kullanıcı adınızı giriniz!!!").slideDown("1500");}

                else{  $("#sifre").focus();$("#msj2").html("Lütfen şifrenizi giriniz!!!").slideDown("1500");}


                return false;
            }

            var form_data =
            {
                username: $('#username').val(),
                mail: $('#mail').val(),
                sifre: $('#pswd').val()

            };

            $.ajax({
                url:'kisiEkle.php',
                type:'POST',
                data:form_data,
                success: function(data)
                {
                    $("#icerik").html("basarili");
                },
                error: function()
                {
                    alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");

                }
            });

        });


        $('#username').blur(function() {
            var form_data =
            {
                userName: $('#username').val()
            };

            $.ajax({
                url:'kisiDogrula.php',
                type: 'POST',
                data:form_data,
                dataType: 'json',

                success: function(data)
                {
                    if(data.sonuc==1)
                        {	   $("#msj2").html("Bu kullanıcı isimli bir üyemiz Var!!!").slideDown("1500");
                            $('#username').focus();
                            exit(0);

                        }
                    else
                        {
                            $("#msj2").hide();
                        }
                },
                error: function()
                {
                    alert("Hata meydana geldi. Lütfen tekrar deneyiniz !!!");

                }
            });


        });
        });

</script>
<div >

    <h1>UYE OLMA EKRANI</h1>


    <div  class=" left" style="width: 500px">
        <h3>Yeni Kayıt</h3>
            <table style="width: 400px">
                <tr style="width:400px">
                    <td style="width: 150px">
                        <label for="username">Kullanici Adi</label>
                    </td>

                    <td>
                        :
                    </td>

                    <td>
                        <input name="username" type="text" id="username" maxlength="40" />
                    </td>

                </tr >
                <tr style="width:400px">
                    <td style="width: 70px">
                        <label for="phone">Sifre</label>
                    </td>

                    <td>
                        :
                    </td>

                    <td>
                        <input name="pswd" type="password"  id="pswd" maxlength="20" value=""/>
                    </td>

                </tr>
                <tr style="width:400px">
                    <td style="width: 70px">
                        <label for="phone">Email</label>
                    </td>

                    <td>
                        :
                    </td>

                    <td>
                        <input name="mail" type="text"  id="mail" maxlength="20" />
                    </td>

                </tr>
                <tr >
                   <td colspan="2"  >    <input type="submit" id="btnKayıt" name="Submit" value="Kaydet"   />
                   </td>
                    <td >
                        <h5  id="msj2" ></h5>
                    </td>
                </tr>
            </table>
    </div>

    <div class="clear"></div>


    