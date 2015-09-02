<%@ Page Title="" Language="C#" MasterPageFile="~/TEST.Master" AutoEventWireup="true" CodeBehind="ptesti.aspx.cs" Inherits="_1_nisan.ptesti" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="500px" Width="700px" 
BackColor="#8FBC8F" ScrollBars="Auto" runat="server">
<div>
    
        <p>
            
            <asp:Label ID="Label42" runat="server" Text="Başlama Tarihi:" Font-Italic="False"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label44" runat="server" Text="KİŞİLİK PROFİLİ" Font-Italic="False" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label45" runat="server" Text="Adı Soyadı:" Font-Italic="False"></asp:Label>
        </p>

        <p>
            <asp:Label ID="Label43" runat="server" Text="Bitiş Tarihi:" Font-Italic="False"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label47" runat="server" Text="CEVAP KAĞIDI" Font-Italic="False" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label46" runat="server" Text="Tarih: ..../..../20.." Font-Italic="False"></asp:Label>
        </p>
        <br />
        
        <p>
            <asp:Label ID="Label1" runat="server" Text="Aşağıda yanyana dört sözcükten oluşan sıraların her birinde, size en çok uyan bir sözcüğün önüne (1) sayısını koyun. Sorular içerisinde TUZAK sorular mevcuttur. Kişilik testinde aleyhiniz" Font-Italic="False"></asp:Label>
        </p>
        1.
         <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Maceraperest" Value="1" /> 
            <asp:ListItem Text="Uyumlu" Value="2" />
            <asp:ListItem Text="Canlı" Value="3" />
            <asp:ListItem Text="Analitik" Value="4" />
        </asp:RadioButtonList> 
        2.
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" 
            RepeatDirection="Horizontal">
         <asp:ListItem Text ="Israrcı" Value="1" />
          <asp:ListItem Text ="Oyuncu" Value="2" />
          <asp:ListItem Text ="İkna Edici" Value="3" />
         <asp:ListItem Text ="Barışçıl" Value="4" />
        </asp:RadioButtonList>
        3.
        <asp:RadioButtonList ID="RadioButtonList3" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Uysal" Value="1" />
            <asp:ListItem Text="Özverili" Value="2" />
            <asp:ListItem Text="Sosyal" Value="3" />
            <asp:ListItem Text="Güçlü İradeli" Value="4" />
        </asp:RadioButtonList>
         4.
        <asp:RadioButtonList ID="RadioButtonList4" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Düşünceli" Value="1" />
            <asp:ListItem Text="Kontrollü" Value="2" />
            <asp:ListItem Text="Rekabetçi" Value="3" />
            <asp:ListItem Text="İnandırıcı" Value="4" />
        </asp:RadioButtonList>
         5.
        <asp:RadioButtonList ID="RadioButtonList5" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Hayat Veren" Value="1" />
            <asp:ListItem Text="Saygılı" Value="2" />
            <asp:ListItem Text="Çekingen" Value="3" />
            <asp:ListItem Text="Becerikli" Value="4" />
        </asp:RadioButtonList>
           6.
        <asp:RadioButtonList ID="RadioButtonList6" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Halinden Memnun" Value="1" />
            <asp:ListItem Text="Duyarlı" Value="2" />
            <asp:ListItem Text="Kendine Güvenen" Value="3" />
            <asp:ListItem Text="Hayat Dolu" Value="4" />
        </asp:RadioButtonList>

        7.
        <asp:RadioButtonList ID="RadioButtonList7" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Planlayıcı" Value="1" />
            <asp:ListItem Text="Sabırlı" Value="2" />
            <asp:ListItem Text="Olumlu" Value="3" />
            <asp:ListItem Text="Yönlendirici" Value="4" />
        </asp:RadioButtonList>
        8.
        <asp:RadioButtonList ID="RadioButtonList8" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Spontane" Value="1" />
            <asp:ListItem Text="Sabırlı" Value="2" />
            <asp:ListItem Text="Programlı" Value="3" />
            <asp:ListItem Text="Utangaç" Value="4" />
        </asp:RadioButtonList>

        9.
        <asp:RadioButtonList ID="RadioButtonList9" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Düzenli" Value="1" />
            <asp:ListItem Text="Nazik" Value="2" />
            <asp:ListItem Text="Açıksözlü" Value="3" />
            <asp:ListItem Text="İyimser" Value="4" />
        </asp:RadioButtonList>
      10.
        <asp:RadioButtonList ID="RadioButtonList10" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Dostça Davranan" Value="1" />
            <asp:ListItem Text="Sadık" Value="2" />
            <asp:ListItem Text="Komik" Value="3" />
            <asp:ListItem Text="Etkili" Value="4" />
        </asp:RadioButtonList>
        11.
        <asp:RadioButtonList ID="RadioButtonList11" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Cesur" Value="1" />
            <asp:ListItem Text="Hoş" Value="2" />
            <asp:ListItem Text="Politik" Value="3" />
            <asp:ListItem Text="Ayrıntıcı" Value="4" />
        </asp:RadioButtonList>
          12.
        <asp:RadioButtonList ID="RadioButtonList12" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Neşeli" Value="1" />
            <asp:ListItem Text="Tutarlı" Value="2" />
            <asp:ListItem Text="Kültürlü" Value="3" />
            <asp:ListItem Text="Güvenli" Value="4" />
        </asp:RadioButtonList>
         13.
        <asp:RadioButtonList ID="RadioButtonList13" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="İdealist" Value="1" />
            <asp:ListItem Text="Bağımsız" Value="2" />
            <asp:ListItem Text="Zararsız" Value="3" />
            <asp:ListItem Text="Esin Kaynağı" Value="4" />
        </asp:RadioButtonList>
        14.
        <asp:RadioButtonList ID="RadioButtonList14" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Sıcakkanlı" Value="1" />
            <asp:ListItem Text="Kararlı" Value="2" />
            <asp:ListItem Text="İnce Esprili" Value="3" />
            <asp:ListItem Text="Derin" Value="4" />
        </asp:RadioButtonList>
        15.
        <asp:RadioButtonList ID="RadioButtonList15" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Arabulucu" Value="1" />
            <asp:ListItem Text="Müziksever" Value="2" />
            <asp:ListItem Text="Harekete Geçiren" Value="3" />
            <asp:ListItem Text="Kolay Kaynaşan" Value="4" />
        </asp:RadioButtonList>
        16.
        <asp:RadioButtonList ID="RadioButtonList16" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="İnce Düşünceli" Value="1" />
            <asp:ListItem Text="Azimli" Value="2" />
            <asp:ListItem Text="Konuşkan" Value="3" />
            <asp:ListItem Text="Hoşgörülü" Value="4" />
        </asp:RadioButtonList>
        17.
        <asp:RadioButtonList ID="RadioButtonList17" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="İyi Dinleyici" Value="1" />
            <asp:ListItem Text="Samimi" Value="2" />
            <asp:ListItem Text="Lider" Value="3" />
            <asp:ListItem Text="Enerjik" Value="4" />
        </asp:RadioButtonList>
        18.
        <asp:RadioButtonList ID="RadioButtonList18" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Kanaatkar" Value="1" />
            <asp:ListItem Text="Şef" Value="2" />
            <asp:ListItem Text="Organizatör" Value="3" />
            <asp:ListItem Text="Şirin" Value="4" />
        </asp:RadioButtonList>
       19.
        <asp:RadioButtonList ID="RadioButtonList19" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Mükemmelliyetçi" Value="1" />
            <asp:ListItem Text="Tatlı" Value="2" />
            <asp:ListItem Text="Üretken" Value="3" />
            <asp:ListItem Text="Popüler" Value="4" />
        </asp:RadioButtonList>
        20.
        <asp:RadioButtonList ID="RadioButtonList20" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Fıkır Fıkır" Value="1" />
            <asp:ListItem Text="Gözüpek" Value="2" />
            <asp:ListItem Text="Terbiyeli" Value="3" />
            <asp:ListItem Text="Dengeli" Value="4" />
        </asp:RadioButtonList>
      
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="20px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" BackColor="#FF9900" Width="40px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Width="20px"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" BackColor="#FF9900" Width="40px"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox9" runat="server" Width="20px"></asp:TextBox>
        <asp:TextBox ID="TextBox10" runat="server" BackColor="#FF9900" Width="40px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox13" runat="server" Width="20px"></asp:TextBox>
        <asp:TextBox ID="TextBox14" runat="server" BackColor="#FF9900" Width="40px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <br />
        21.
        <asp:RadioButtonList ID="RadioButtonList21" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="İfadesiz" Value="1" />
            <asp:ListItem Text="Sıkılgan" Value="2" />
            <asp:ListItem Text="Yüzsüz" Value="3" />
            <asp:ListItem Text="Zorba" Value="4" />
        </asp:RadioButtonList>
        22.
        <asp:RadioButtonList ID="RadioButtonList22" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Disiplinsiz" Value="1" />
            <asp:ListItem Text="Anlayışsız" Value="2" />
            <asp:ListItem Text="Coşkusuz" Value="3" />
            <asp:ListItem Text="Affetmeyen" Value="4" />
        </asp:RadioButtonList>
         23.
        <asp:RadioButtonList ID="RadioButtonList23" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Suskun" Value="1" />
            <asp:ListItem Text="Kinci" Value="2" />
            <asp:ListItem Text="Karşı Gelen" Value="3" />
            <asp:ListItem Text="Kendini Tekrarlayan" Value="4" />
        </asp:RadioButtonList>
        24.
        <asp:RadioButtonList ID="RadioButtonList24" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Telaşlı" Value="1" />
            <asp:ListItem Text="Korkak" Value="2" />
            <asp:ListItem Text="Unutkan" Value="3" />
            <asp:ListItem Text="Dobra" Value="4" />
        </asp:RadioButtonList>
      25.
        <asp:RadioButtonList ID="RadioButtonList25" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Sabırsız" Value="1" />
            <asp:ListItem Text="Güvensiz" Value="2" />
            <asp:ListItem Text="Kararsız" Value="3" />
            <asp:ListItem Text="Laf Kesen" Value="4" />
        </asp:RadioButtonList>
         26.
        <asp:RadioButtonList ID="RadioButtonList26" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Sevilmeyen" Value="1" />
            <asp:ListItem Text="Yaşamdan Kopuk" Value="2" />
            <asp:ListItem Text="Ne Yapacağı Belirsiz" Value="3" />
            <asp:ListItem Text="Şefkatsiz" Value="4" />
        </asp:RadioButtonList>
        27.
        <asp:RadioButtonList ID="RadioButtonList27" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Dikkafalı" Value="1" />
            <asp:ListItem Text="Gelişigüzel" Value="2" />
            <asp:ListItem Text="Müşkülpesent" Value="3" />
            <asp:ListItem Text="Tereddütlü" Value="4" />
        </asp:RadioButtonList>
         28.
        <asp:RadioButtonList ID="RadioButtonList28" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Renksiz" Value="1" />
            <asp:ListItem Text="Kötümser" Value="2" />
            <asp:ListItem Text="Kibirli" Value="3" />
            <asp:ListItem Text="Göz Yuman" Value="4" />
        </asp:RadioButtonList>
        29.
        <asp:RadioButtonList ID="RadioButtonList29" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Kolay Sinirlenen" Value="1" />
            <asp:ListItem Text="Amaçsız" Value="2" />
            <asp:ListItem Text="İddiacı" Value="3" />
            <asp:ListItem Text="Yabancılaşma" Value="4" />
        </asp:RadioButtonList>
        30.
        <asp:RadioButtonList ID="RadioButtonList30" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Saf" Value="1" />
            <asp:ListItem Text="Olumsuz Tutumlu" Value="2" />
            <asp:ListItem Text="Küstah" Value="3" />
            <asp:ListItem Text="Kayıtsız" Value="4" />
        </asp:RadioButtonList>
        31.
        <asp:RadioButtonList ID="RadioButtonList31" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Endişeli" Value="1" />
            <asp:ListItem Text="Yanlızlığa Sığınan" Value="2" />
            <asp:ListItem Text="İşkolik" Value="3" />
            <asp:ListItem Text="Tanınmak İsteyen" Value="4" />
        </asp:RadioButtonList>
        32.
        <asp:RadioButtonList ID="RadioButtonList32" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Fazla Hassas" Value="1" />
            <asp:ListItem Text="Patavatsız" Value="2" />
            <asp:ListItem Text="Ürkek" Value="3" />
            <asp:ListItem Text="Konuşkan" Value="4" />
        </asp:RadioButtonList>
          33.
        <asp:RadioButtonList ID="RadioButtonList33" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Kuşkulu" Value="1" />
            <asp:ListItem Text="Düzensiz" Value="2" />
            <asp:ListItem Text="Otoriter" Value="3" />
            <asp:ListItem Text="Bunalımlı" Value="4" />
        </asp:RadioButtonList>
         34.
        <asp:RadioButtonList ID="RadioButtonList34" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Tutarsız" Value="1" />
            <asp:ListItem Text="İçe Dönük" Value="2" />
            <asp:ListItem Text="Hoşgörüsüz" Value="3" />
            <asp:ListItem Text="Umursamaz" Value="4" />
        </asp:RadioButtonList>
        35.
        <asp:RadioButtonList ID="RadioButtonList35" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Dağınık" Value="1" />
            <asp:ListItem Text="Karamsar" Value="2" />
            <asp:ListItem Text="Geveleyen" Value="3" />
            <asp:ListItem Text="İnsan Kullanan" Value="4" />
        </asp:RadioButtonList>
        36.
        <asp:RadioButtonList ID="RadioButtonList36" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Uyuşuk" Value="1" />
            <asp:ListItem Text="İnatçı" Value="2" />
            <asp:ListItem Text="Hava Atan" Value="3" />
            <asp:ListItem Text="Kuşkucu" Value="4" />
        </asp:RadioButtonList>
        37.
        <asp:RadioButtonList ID="RadioButtonList37" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Yanlızlığı Seven" Value="1" />
            <asp:ListItem Text="Amirane" Value="2" />
            <asp:ListItem Text="Tembel" Value="3" />
            <asp:ListItem Text="Gürültücü" Value="4" />
        </asp:RadioButtonList>
        38.
        <asp:RadioButtonList ID="RadioButtonList38" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Ağır Kanlı" Value="1" />
            <asp:ListItem Text="Şüpheci" Value="2" />
            <asp:ListItem Text="Öfkeli" Value="3" />
            <asp:ListItem Text="Kafası Dağınık" Value="4" />
        </asp:RadioButtonList>
        39.
        <asp:RadioButtonList ID="RadioButtonList39" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="İntikamcı" Value="1" />
            <asp:ListItem Text="Yerinde Duramayan" Value="2" />
            <asp:ListItem Text="Gönülsüz" Value="3" />
            <asp:ListItem Text="Aceleci" Value="4" />
        </asp:RadioButtonList>
        40.
        <asp:RadioButtonList ID="RadioButtonList40" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Ödün Veren" Value="1" />
            <asp:ListItem Text="Tenkitçi" Value="2" />
            <asp:ListItem Text="Kurnaz" Value="3" />
            <asp:ListItem Text="Değişken" Value="4" />
        </asp:RadioButtonList>
      
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox17" runat="server" Width="23px">GK</asp:TextBox>
        <asp:TextBox ID="TextBox18" runat="server" BackColor="#FF9900" Height="16px" 
            Width="40px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox21" runat="server" Width="23px">BS</asp:TextBox>
        <asp:TextBox ID="TextBox22" runat="server" BackColor="#FF9900" Width="40px"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox25" runat="server" Width="23px">MM</asp:TextBox>
        <asp:TextBox ID="TextBox26" runat="server" BackColor="#FF9900" Width="40px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox29" runat="server" Width="23px">PO</asp:TextBox>
        <asp:TextBox ID="TextBox30" runat="server" BackColor="#FF9900" Width="40px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click1" Text="AKTAR" />
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="TESTİ BİTİR" style="margin-left: 33px" />
        </p>
    <%--    <br>
        <br>
        <br>
        <br></br>
        <br>
        <br></br>
        <br></br>
        <br></br>
        </br>
        </br>
        </br>
        </br>--%>
        
     
    </div>
      </asp:Panel>
</asp:Content>