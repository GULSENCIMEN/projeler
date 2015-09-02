<head>

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <link rel="stylesheet" type="text/css" href="CSS/bicim.css"/>
    <script src="JS/jquery-1.9.1.js"></script>
    <script>

        $(document).ready(function(){
            $("#4").hide();
            $("#5").hide();
            $("#6").show();
            $("#1").click(function()
            {
                $("#4").show();
                $("#5").hide();
                $("#6").hide();

            });
            $("#2").click(function()
            {
                $("#5").show();
                $("#4").hide();
                $("#6").hide();

            });
            $("#3").click(function()
            {
                $("#6").show();
                $("#4").hide();
                $("#5").hide();

            });

            $("#12").hide();
            $("#13").hide();
            $("#14").hide();
            $("#15").hide();
            $("#16").hide();

            $("#7").click(function()

                {
                    $("#12").load("DersPlani/ayrık.html");
                    $("#12").toggle("slow");
                }
            );
            $("#8").click(function()

                {
                    $("#13").load("DersPlani/org.html");
                    $("#13").toggle("slow");
                }
            );
            $("#9").click(function()

                {
                    $("#14").load("DersPlani/edl.html");
                    $("#14").toggle("slow");
                }
            );
            $("#10").click(function()

                {
                    $("#15").load("DersPlani/ndp.html");
                    $("#15").toggle("slow");
                }
            );
            $("#11").click(function()

                {
                    $("#16").load("DersPlani/pdp.html");
                    $("#16").toggle("slow");
                }
            );

            $("#17").click(function()

                {
                    $("#22").load("DersPlani/turkdili.php");
                    $("#22").fadeToggle("slow");
                }
            );
			   $("#18").click(function()

                {
                    $("#23").load("DersPlani/fizik.php");
                    $("#23").fadeToggle("slow");
                }
            );
			
			   $("#19").click(function()

                {
                    $("#24").load("DersPlani/lineercebir.php");
                    $("#24").fadeToggle("slow");
                }
            );
				$("#20").click(function()

					{
						$("#25").load("DersPlani/matematik.php");
						$("#25").fadeToggle("slow");
					}
				);
				
								$("#21").click(function()

					{
						$("#26").load("DersPlani/algoritma.php");
						$("#26").fadeToggle("slow");
					}
				);




        });

    </script>

</head>
<html lang="tr">
<body >

<div style="float:left">

    <img src="Adsız.png" style="width: 1288px;height: 120px">

</div>

<div class="ust_menu">
    <ul>
        <li><a href="#">ANASAYFA</a></li>
        <li><a href="#">BÖLÜM</a></li>
        <li><a href="#">AKADEMİK</a></li>
        <li><a href="#">EĞİTİM</a> </li>
        <li><a href="#">ÖĞRENCİ</a></li>
        <li><a href="#">BİLGİ</a></li>
        <li><a href="#">BAĞLANTILAR</a> </li>
        <li><a href="#">GALERİLER</a></li>
        <li><a href="#">İLETİŞİM</a></li>

    </ul>
    <br style="clear:left"/>
</div>

<div class="alt_menu" style="float: left">
    <ul>
        <li ><a href="#">PROGRAM BİLGİLERİ</a></li>
        <li id="1"><a href="#">Amaç ve Hedefler</a></li>
        <li id="2"><a href="#">Ders Planı-AKTS Kredileri</a></li>
        <li id="3"><a href="#">Program Öğrenme Çıktıları</a></li>
        <li><a href="#">Ders Kategori Listesi</a></li>
        <li><a href="#">Alınacak Derece</a></li>
        <li><a href="#">Özel Kabul Koşulları</a></li>
        <li><a href="#">Önceki Öğretimi Tanıma</a></li>
        <li id="2"><a href="#">İstihdam Olanakları</a></li>
        <li><a href="#">Mezuniyet Koşulları</a></li>
        <li><a href="#">Ölçme ve Değerlendirme</a></li>
        <li><a href="#">Bölüm Bşk. ve AKTS Koord.</a></li>
        <li><a href="#">Öğrencilere Uyg. Anketler</a></li>
        <li><a href="#">2012-2013 Ders Plan Güncellemeleri</a></li>
        <li><a href="#">İntibak Esasları</a></li>
        <li><a href="#">Anasayfa</a></li>
    </ul>
</div>

<div class="icerikler" id="4">
    <table class="icerikler">
        <tr>
            <td style="background-color: darkcyan">
                AMAÇLAR
                <br>
			</td>
		</tr>
        <tr>
            <td>
                <br>
                <br>
                a- Bilgisayar yazılımı/donanımı , AR-GE, ulusal/uluslararası bilişim kuruluşlarında yada akademik alanlarda başarılı
                <br>
                kariyer sergileyebilecek mühendisler yetiştirmek,
                <br>
                <br>

                b- Bilgisayar ve Bilişim Mühendisliği problemlerine sürdürülebilir çözümler sunabilen, bilimsel ve
                <br>teknolojik gelişmeleri takip edebilen mühendisler yetiştirmek,
                <br>
                <br>
                c- Sorumluluk duygusu gelişmiş, girişimci ve alanlarında rekabet edebilen mühendisler yetiştirmek..
            </td>
        </tr>
        <tr>
            <td style="background-color: darkcyan">

                HEDEFLER
                <br>
            </td>
        </tr>
        <tr>
            <td>
                <br>
                <br>
                Kazandığı bilgiyi toplumsal ve endüstriyel faydaya dönüştürerek bilgisayar bilimini üretici ve sürükleyici bir güç haline
                <br>
                getiren ve küresel alandaki gelişmeleri izleyebilen ve rekabet cesaretine sahip mühendisleri yetiştirmek için sürekli
                <br>
                yenilenme ve gelişme bilinciyle çalışan bir bölüm olmak.
            </td>
        </tr>
    </table>
</div>
<div class="icerikler" id="5" style="overflow: scroll; height: 500px" >
    <p > GÖSTERİM BİÇİMİ</p>

    <table >
        <tr>
            <td style="width: 328px;height: 25px; background-color: darkcyan">
                Sınıflandırılmış
            </td>
            <td style="width: 328px;height: 25px; background-color: darkcyan">
                Sıralı
            </td>
            <td style="width: 328px;height: 25px; background-color: darkcyan">
                Düzey / Alan / Program
            </td>
        </tr>
    </table>

    <table  border="2">
        <tr>


        </tr>
        <tr>
            <td>
                PROGRAM ÖĞRENME ÇIKTILARI
            </td>
        </tr>
        <tr>
            <td style="background-color: darkcyan">
                BİLGİ
            </td>
        </tr>
        <tr>
            <td>
                <br>
                Kuramsal, Olgusal
                <br>
                <br>

                - Matematik, fen bilimleri ve ayrık Matematik, Olasılık/İstatistik gibi kendi dalları ile ilgili mühendislik konularında
                <br>yeterli altyapıya sahip olma; bu alanlardaki kuramsal ve uygulamalı bilgileri mühendislik çözümleri için beraber
                <br>kullanabilme becerisi,
                <br>
                <br>

                - Mühendislik problemlerini saptama, tanımlama, formüle etme ve çözme becerisi; bu amaçla uygun analitik
                <br>yöntemler ve modelleme tekniklerini seçme ve uygulama becerisi,
                <br>
            </td>
        </tr>
        <tr>
            <td style="background-color: darkcyan">

                BECERİLER
            </td>
        </tr>
        <tr>
            <td>
                <br>
                Bilişsel, Uygulamalı
                <br>
                <br>

                - Bir sistemi, sistem bileşenini ya da süreci analiz etme ve istenen gereksinimleri karşılamak üzere gerçekçi kısıtlar
                <br>altında tasarlama becerisi; bu doğrultuda modern tasarım yöntemlerini uygulama becerisi,
                <br>
                <br>

                - Mühendislik uygulamaları için gerekli olan modern teknik ve araçları seçme ve kullanma becerisi; bilişim teknolojilerini
                <br>etkin kullanma becerisi,
                <br>
                <br>

                - Deney tasarlama, deney yapma, veri toplama, sonuçları analiz etme ve yorumlama becerisi ve araştırmalarda gönüllü olma bilinci,
                <br>

            </td>
        </tr>
        <tr>
            <td style="background-color: darkcyan">
                YETKİNLİKLER
            </td>

        </tr>
        <tr>
            <td>
                <br>
                Bağımsız Çalışabilme ve Sorumluluk Alabilme Yetkinliği
                <br>
                <br>

                - Bireysel olarak ve çok disiplinli takımlarda etkin çalışabilme becerisi, sorumluluk alma özgüveni,
                <br>
                <br>
                Öğrenme Yetkinliği
                <br>
                <br>

                - Yaşam boyu öğrenmenin gerekliliği bilinci; bilim ve teknolojideki gelişmeleri izleme ve kendini sürekli yenileme becerisi,

                - Bilişim Teknolojilerinin yönetim, denetim, gelişim ve güvenliği/güvenilirliği hakkında bilgi sahibi olma ve farkındalık,
                <br>
                <br>
                İletişim ve Sosyal Yetkinlik
                <br>
                <br>
                - Kendini veya bir problemi sözlü/yazılı ifade edebilme yeteneği ve etkin iletişim kurma becerisi; en az bir yabancı dil
                <br>bilgisi,
                <br>
                <br>

                - Proje yönetimi, işyeri uygulamaları, çalışanların sağlığı, çevre ve iş güvenliği konularında bilinç; mühendislik
                <br>uygulamalarının hukuksal sonuçları hakkında farkındalık,
                <br>
                <br>
                Alana Özgü Yetkinlik
                <br>
                <br>
                - Proje yönetimi, işyeri uygulamaları, çalışanların sağlığı, çevre ve iş güvenliği konularında bilinç; mühendislik
                <br>uygulamalarının hukuksal sonuçları hakkında farkındalık,
                <br>
                <br>
                - Mühendislik çözümlerinin ve uygulamalarının evrensel ve toplumsal boyutlardaki etkilerinin bilincinde olmak;
                <br>girişimcilik ve yenilikçilik konularının farkında olmak ve çağın sorunları hakkında bilgi sahibi olmak.
                <br>
                <br>

                - Mesleki ve etik sorumluluk bilincine sahip olma ve uygulama duyarlılığı, toplumda bu sorumluluğu yayma bilinci,
                <br>
            </td>


        </tr>

    </table>


</div>


<div id="6" style="overflow: scroll; height: 500px">
<div>
<table border='1' width='800px' style="background-color:#FFFF00">
<tr>
<td><center>
<b>B1112.10013 GÜLSEN ÇİMEN 1-B</b></center>
</td>
</tr>
    <table border='1' width='800px'>
        <td align="center" colspan="10" style="background-color: darkcyan"><b> 1. Yarıyıl Ders Planı</b></td>
        <tr>
            <td <b>Kodu</b></td>
            <td <b>Ders</b></td>
            <td <b>Z/S </b></td>
            <td <b>Dil </b></td>
            <td <b>T+U Saat </b></td>
            <td <b>Kredi </b></td>
            <td <b>AKTS </b></td>
        </tr>
        <tr>
            <td>
                TUR 101
            </td>
            <td id="17">
                TÜRK DİLİ
            </td>
            <td> Zorunlu
            </td>
            <td> Türkçe
            </td>
            <td> 4+0
            </td>
            <td> 4
            </td>
            <td> 4
            </td>
        </tr>
        <tbody id="22"></tbody>
        <tr>
            <td>FIZ 111</td>
            <td id="18">FİZİK I</td>
            <td>Zorunlu </td>
            <td>Türkçe</td>
            <td> 3+2</td>
            <td> 4 </td>
            <td>6 </td>
        </tr>
        <tbody id="23"></tbody>
        <tr>
            <td>MAT 113</td>
            <td id="19">LİNEER CEBİR</td>
            <td>Zorunlu</td>
            <td>Türkçe </td>
            <td>2+0</td>
            <td>2</td>
            <td>4</td>
        </tr>
        <tbody id="24"></tbody>
        <tr>
            <td>MAT 111</td>
            <td id="20">MATEMATİK 1</td>
            <td>Zorunlu</td>
            <td>Türkçe İngilizce</td>
            <td>4+0</td>
            <td>4</td>
            <td>6</td>
        </tr>
        <tbody id="25"></tbody>
        <tr>
            <td>BSM 103</td>
            <td id="21">ALGORİTMALAR VE PROGRAMLAMA I</td>
            <td>Zorunlu</td>
            <td>Türkçe</td>
            <td>3+0</td>
            <td>3</td>
            <td>6</td>
        </tr>
        <tbody id="26"></tbody>
        <tr height="25">
            <td colspan="6" align="right"><b>AKTS kredisi toplamı :</b></td>
            <td align="center"><b>30</b></td>
        </tr>
    </table>
</div>

<div >
    <table border='1' width='800px'>
        <td align="center" colspan="10" style="background-color: darkcyan"><b> 2. Yarıyıl Ders Planı</b></td>
        <tr>
            <td <b>Kodu</b></td>
            <td <b>Ders</b></td>
            <td <b>Z/S </b></td>
            <td <b>Dil </b></td>
            <td <b>T+U Saat </b></td>
            <td <b>Kredi </b></td>
            <td <b>AKTS </b></td>
        </tr>
        <tr>
            <td>
                BSM 301
            </td>
            <td >
                İNGİLİZCE
            </td>
            <td> Zorunlu
            </td>
            <td> Türkçe
            </td>
            <td> 3+0
            </td>
            <td> 3
            </td>
            <td> 5
            </td>
        </tr>

        <tr>
            <td>BSM 307</td>
            <td>FİZİK II</td>
            <td>Zorunlu </td>
            <td>Türkçe</td>
            <td> 3+0</td>
            <td> 3 </td>
            <td>5 </td>
        </tr>
        <tr>
            <td>BSM 309</td>
            <td>MATEMATİK II</td>
            <td>Zorunlu</td>
            <td>Türkçe </td>
            <td>3+0</td>
            <td>3</td>
            <td>6</td>
        </tr>
        <tr>
            <td>BSM 305</td>
            <td>OLASILIK VE İSTATİSTİK</td>
            <td>Zorunlu</td>
            <td>Türkçe İngilizce</td>
            <td>3+0</td>
            <td>3</td>
            <td>5</td>
        </tr>
        <tr>
            <td>BSM 303</td>
            <td>WEB TEKNOLOJİLERİ	</td>
            <td>Zorunlu</td>
            <td>Türkçe</td>
            <td>4+0</td>
            <td>4</td>
            <td>7</td>
        </tr>

        <tr height="25">
            <td colspan="6" align="right"><b>AKTS kredisi toplamı :</b></td>
            <td align="center"><b>30</b></td>
        </tr>
    </table>
</div>

<div>
    <table border='1' width='800px'>
        <td align="center" colspan="10" style="background-color: darkcyan"><b> 3. Yarıyıl Ders Planı</b></td>
        <tr>
            <td <b>Kodu</b></td>
            <td <b>Ders</b></td>
            <td <b>Z/S </b></td>
            <td <b>Dil </b></td>
            <td <b>T+U Saat </b></td>
            <td <b>Kredi </b></td>
            <td <b>AKTS </b></td>
        </tr>
        <tr>
            <td>
                BSM 301
            </td>
            <td >
                ATATÜRK İLKELERİ VE İNKİLAP TARİHİ
            </td>
            <td> Zorunlu
            </td>
            <td> Türkçe
            </td>
            <td> 3+0
            </td>
            <td> 3
            </td>
            <td> 5
            </td>
        </tr>

        <tr>
            <td>BSM 307</td>
            <td>DİFERANSİYEL DENKLEMLER</td>
            <td>Zorunlu </td>
            <td>Türkçe</td>
            <td> 3+0</td>
            <td> 3 </td>
            <td>5 </td>
        </tr>
        <tr>
            <td>BSM 309</td>
            <td>ELEKTRİK DEVRE TEMELLERİ	</td>
            <td>Zorunlu</td>
            <td>Türkçe </td>
            <td>3+0</td>
            <td>3</td>
            <td>6</td>
        </tr>
        <tr>
            <td>BSM 305</td>
            <td>MANTIK DEVRELERİ</td>
            <td>Zorunlu</td>
            <td>Türkçe İngilizce</td>
            <td>3+0</td>
            <td>3</td>
            <td>5</td>
        </tr>
        <tr>
            <td>BSM 303</td>
            <td>SAYISAL ANALİZ	</td>
            <td>Zorunlu</td>
            <td>Türkçe</td>
            <td>4+0</td>
            <td>4</td>
            <td>7</td>
        </tr>
        <tr>
            <td>BSM 303</td>
            <td>VERİ YAPILARI	</td>
            <td>Zorunlu</td>
            <td>Türkçe</td>
            <td>4+0</td>
            <td>4</td>
            <td>7</td>
        </tr>

        <tr height="25">
            <td colspan="6" align="right"><b>AKTS kredisi toplamı :</b></td>
            <td align="center"><b>30</b></td>
        </tr>
    </table>
</div>

<div>
    <table border='1' width='800px'>
        <td align="center" colspan="10" style="background-color: darkcyan"><b> 4. Yarıyıl Ders Planı</b></td>
        <tr>
            <td <b>Kodu</b></td>
            <td <b>Ders</b></td>
            <td <b>Z/S </b></td>
            <td <b>Dil </b></td>
            <td <b>T+U Saat </b></td>
            <td <b>Kredi </b></td>
            <td <b>AKTS </b></td>
        </tr>
        <tr>
            <td>
                BSM 301
            </td>
            <td id="7">
                AYRIK İŞLEMSEL YAPILAR
            </td>
            <td> Zorunlu
            </td>
            <td> Türkçe
            </td>
            <td> 3+0
            </td>
            <td> 3
            </td>
            <td> 5
            </td>
        </tr>
        <tbody id="12"></tbody>
        <tr>
            <td>BSM 307</td>
            <td id="8"> BİLGİSAYAR ORGANİZASYONU</td>
            <td>Zorunlu </td>
            <td>Türkçe</td>
            <td> 3+0</td>
            <td> 3 </td>
            <td>5 </td>
        </tr>
        <tbody id="13"></tbody>
        <tr>
            <td>BSM 309</td>
            <td id="9">ELEKTRONİK DEVRELER VE LABORATUARI</td>
            <td>Zorunlu</td>
            <td>Türkçe </td>
            <td>3+0</td>
            <td>3</td>
            <td>6</td>
        </tr>
        <tbody id="14"></tbody>
        <tr>
            <td>BSM 305</td>
            <td id="10">NESNEYE DAYALI PROGRAMLAMA</td>
            <td>Zorunlu</td>
            <td>Türkçe İngilizce</td>
            <td>3+0</td>
            <td>3</td>
            <td>5</td>
        </tr>
        <tbody id="15"></tbody>
        <tr>
            <td>BSM 303</td>
            <td id="11">PROGRAMLAMA DİLLERİNİN PRENSİPLERİ</td>
            <td>Zorunlu</td>
            <td>Türkçe</td>
            <td>4+0</td>
            <td>4</td>
            <td>7</td>
        </tr>
        <tbody id="16"></tbody>

        <tr height="25">
            <td colspan="6" align="right"><b>AKTS kredisi toplamı :</b></td>
            <td align="center"><b>30</b></td>
        </tr>
    </table>
</div>

<div>
    <table border='1' width='800px'>
        <td align="center" colspan="10" style="background-color: darkcyan"><b> 5. Yarıyıl Ders Planı</b></td>
        <tr>
            <td <b>Kodu</b></td>
            <td <b>Ders</b></td>
            <td <b>Z/S </b></td>
            <td <b>Dil </b></td>
            <td <b>T+U Saat </b></td>
            <td <b>Kredi </b></td>
            <td <b>AKTS </b></td>
        </tr>
        <tr>
            <td>
                BSM 301
            </td>
            <td id="1">
                BİÇİMSEL DİLLER VE SOYUT MAKİNELER
            </td>
            <td> Zorunlu
            </td>
            <td> Türkçe
            </td>
            <td> 3+0
            </td>
            <td> 3
            </td>
            <td> 5
            </td>
        </tr>

        <tr>
            <td>BSM 307</td>
            <td>İŞARETLER VE SİSTEMLER</td>
            <td>Zorunlu </td>
            <td>Türkçe</td>
            <td> 3+0</td>
            <td> 3 </td>
            <td>5 </td>
        </tr>
        <tr>
            <td>BSM 309</td>
            <td>İŞLETİM SİSTEMLERİ</td>
            <td>Zorunlu</td>
            <td>Türkçe </td>
            <td>3+0</td>
            <td>3</td>
            <td>6</td>
        </tr>
        <tr>
            <td>BSM 305</td>
            <td>VERİ İLETİŞİMİ</td>
            <td>Zorunlu</td>
            <td>Türkçe İngilizce</td>
            <td>3+0</td>
            <td>3</td>
            <td>5</td>
        </tr>
        <tr>
            <td>BSM 303</td>
            <td>VERİTABANI YÖNETİM SİSTEMLERİ	</td>
            <td>Zorunlu</td>
            <td>Türkçe</td>
            <td>4+0</td>
            <td>4</td>
            <td>7</td>
        </tr>
        <tr>
            <td>
                <font color="blue"> - </font>
            </td>
            <td>
                <font color="blue"> ÜNİVERSİTE ORTAK DERSİ </font>
            </td>
            <td> <font color="blue"> Üniversite Ortak Dersi </font>
            </td>
            <td>  <font color="blue"> - </font>
            </td>
            <td> <font color="blue"> 2+0 </font>
            </td>
            <td> <font color="blue"> 2</font>
            </td>
            <td>  <font color="blue"> 2 </font>
            </td>
        </tr>
        <tr height="25">
            <td colspan="6" align="right"><b>AKTS kredisi toplamı :</b></td>
            <td align="center"><b>30</b></td>
        </tr>
    </table>
</div>

<div>
    <table border='1' width='800px'>
        <td align="center" colspan="10" style="background-color: darkcyan"><b> 6. Yarıyıl Ders Planı</b></td>
        <tr>
            <td <b>Kodu</b></td>
            <td <b>Ders</b></td>
            <td <b>Z/S </b></td>
            <td <b>Dil </b></td>
            <td <b>T+U Saat </b></td>
            <td <b>Kredi </b></td>
            <td <b>AKTS </b></td>
        </tr>
        <tr>
            <td>
                BSM 301
            </td>
            <td id="1">
                BİLGİSAYAR AĞLARI
            </td>
            <td> Zorunlu
            </td>
            <td> Türkçe
            </td>
            <td> 3+0
            </td>
            <td> 3
            </td>
            <td> 5
            </td>
        </tr>

        <tr>
            <td>BSM 307</td>
            <td>MİKROİŞLEMCİLİ SİSTEMLER VE LABARATUVAR</td>
            <td>Zorunlu </td>
            <td>Türkçe</td>
            <td> 3+0</td>
            <td> 3 </td>
            <td>5 </td>
        </tr>
        <tr>
            <td>BSM 309</td>
            <td>SİSTEM PROGRAMLAMA</td>
            <td>Zorunlu</td>
            <td>Türkçe </td>
            <td>3+0</td>
            <td>3</td>
            <td>6</td>
        </tr>
        <tr>
            <td>BSM 305</td>
            <td>WEB PROGRAMLAMA</td>
            <td>Zorunlu</td>
            <td>Türkçe İngilizce</td>
            <td>3+0</td>
            <td>3</td>
            <td>5</td>
        </tr>
        <tr>
            <td>BSM 303</td>
            <td>YAZILIM MÜHENDİSLİĞİ</td>
            <td>Zorunlu</td>
            <td>Türkçe</td>
            <td>4+0</td>
            <td>4</td>
            <td>7</td>
        </tr>

        <tr height="25">
            <td colspan="6" align="right"><b>AKTS kredisi toplamı :</b></td>
            <td align="center"><b>30</b></td>
        </tr>
    </table>
</div>

<div >
    <table border='1' width='800px'>
        <td align="center" colspan="10" style="background-color: darkcyan"><b> 7. Yarıyıl Ders Planı</b></td>
        <tr>
            <td <b>Kodu</b></td>
            <td <b>Ders</b></td>
            <td <b>Z/S </b></td>
            <td <b>Dil </b></td>
            <td <b>T+U Saat </b></td>
            <td <b>Kredi </b></td>
            <td <b>AKTS </b></td>
        </tr>
        <tr>
            <td>
                BSM 301
            </td>
            <td id="1">
                BİLGİSAYAR MÜHENDİSLİĞİ TASARIMI
            </td>
            <td> Zorunlu
            </td>
            <td> Türkçe
            </td>
            <td> 3+0
            </td>
            <td> 3
            </td>
            <td> 5
            </td>
        </tr>

        <tr>
            <td>BSM 307</td>
            <td>STAJ I</td>
            <td>Zorunlu </td>
            <td>Türkçe</td>
            <td> 3+0</td>
            <td> 3 </td>
            <td>5 </td>
        </tr>
        <tr>
            <td>BSM 309</td>
            <td>SOSYAL SEÇİMLİK</td>
            <td>Zorunlu</td>
            <td>Türkçe </td>
            <td>3+0</td>
            <td>3</td>
            <td>6</td>
        </tr>
        <tr>
            <td ><font color="blue">BSM 305</font></td>
            <td ><font color="blue">SEÇİMLİK 1</font></td>
            <td ><font color="blue">Seçmeli</font></td>
            <td ><font color="blue">Türkçe İngilizce</font></td>
            <td ><font color="blue">3+0</font></td>
            <td ><font color="blue"> 3</font></td>
            <td ><font color="blue">5 </font></td>
        </tr>
        <tr>
            <td ><font color="blue">BSM 303</font></td>
            <td ><font color="blue">SEÇİMLİK 2	</font></td>
            <td ><font color="blue">Seçmeli</font></td>
            <td ><font color="blue">Türkçe </font></td>
            <td ><font color="blue">4+0</font></td>
            <td ><font color="blue">4 </font></td>
            <td ><font color="blue">7</font></td>
        </tr>
        <tr>
            <td> <font color="blue">BSM 303 </font></td>
            <td ><font color="blue">SEÇİMLİK 3 </font></td>
            <td ><font color="blue">Seçmeli </font></td>
            <td ><font color="blue">Türkçe </font></td>
            <td ><font color="blue">4+0 </font></td>
            <td ><font color="blue">4</font></td>
            <td ><font color="blue">7</font></td>
        </tr>
        <tr height="25">
            <td colspan="6" align="right"><b>AKTS kredisi toplamı :</b></td>
            <td align="center"><b>30</b></td>
        </tr>
    </table>
</div>

<div >
    <table border='1' width='800px'>
        <td align="center" colspan="10" style="background-color: darkcyan"><b> 8. Yarıyıl Ders Planı</b></td>
        <tr>
            <td <b>Kodu</b></td>
            <td <b>Ders</b></td>
            <td <b>Z/S </b></td>
            <td <b>Dil </b></td>
            <td <b>T+U Saat </b></td>
            <td <b>Kredi </b></td>
            <td <b>AKTS </b></td>
        </tr>
        <tr>
            <td>
                BSM 301
            </td>
            <td id="1">
                BİTİRME ÇALIŞMASI
            </td>
            <td> Zorunlu
            </td>
            <td> Türkçe
            </td>
            <td> 3+0
            </td>
            <td> 3
            </td>
            <td> 5
            </td>
        </tr>

        <tr>
            <td>BSM 307</td>
            <td>STAJ II</td>
            <td>Zorunlu </td>
            <td>Türkçe</td>
            <td> 3+0</td>
            <td> 3 </td>
            <td>5 </td>
        </tr>
        <tr>
            <td>BSM 309</td>
            <td>SOSYAL SEÇİMLİK</td>
            <td>Zorunlu</td>
            <td>Türkçe </td>
            <td>3+0</td>
            <td>3</td>
            <td>6</td>
        </tr>
        <tr>
            <td ><font color="blue">BSM 305</font></td>
            <td ><font color="blue">SEÇİMLİK 1</font></td>
            <td ><font color="blue">Seçmeli</font></td>
            <td ><font color="blue">Türkçe İngilizce</font></td>
            <td ><font color="blue">3+0</font></td>
            <td ><font color="blue"> 3</font></td>
            <td ><font color="blue">5 </font></td>
        </tr>
        <tr>
            <td ><font color="blue">BSM 303</font></td>
            <td ><font color="blue">SEÇİMLİK 2	</font></td>
            <td ><font color="blue">Seçmeli</font></td>
            <td ><font color="blue">Türkçe </font></td>
            <td ><font color="blue">4+0</font></td>
            <td ><font color="blue">4 </font></td>
            <td ><font color="blue">7</font></td>
        </tr>
        <tr>
            <td> <font color="blue">BSM 303 </font></td>
            <td ><font color="blue">SEÇİMLİK 3 </font></td>
            <td ><font color="blue">Seçmeli </font></td>
            <td ><font color="blue">Türkçe </font></td>
            <td ><font color="blue">4+0 </font></td>
            <td ><font color="blue">4</font></td>
            <td ><font color="blue">7</font></td>
        </tr>

        <tr height="25">
            <td colspan="6" align="right"><b>AKTS kredisi toplamı :</b></td>
            <td align="center"><b>30</b></td>
        </tr>
    </table>
</div>
</div>
</body>
</html>