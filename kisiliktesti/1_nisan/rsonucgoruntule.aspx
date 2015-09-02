<%@ Page Title="" Language="C#" MasterPageFile="~/TEST.Master" AutoEventWireup="true" CodeBehind="rsonucgoruntule.aspx.cs" Inherits="_1_nisan.rsonucgoruntule" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<table style="width:100%;">
<tr style="background-color:Aqua">

<td>Sadık Çalışan
</td>
<td>Başkan
</td>
<td>Biçimlendirici
</td>
<td>Yaratıcı
</td>

</tr>
<tr style="background-color:Lime">
<td>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</td>
<td>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</td>
<td>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
</td>
<td>
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
</td>
</tr>

<tr style="background-color:Aqua">

<td>Kaynak Araştıran
</td>
<td>Derecelendirici
</td>
<td>Ekip Üyesi
</td>
<td>Rotus Yapan
</td>

</tr>
<tr style="background-color:Lime">
<td>
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
</td>
<td>
    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
</td>
<td>
    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
</td>
<td>
    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
</td>
</tr>

</table>
<br />
<div>
<div style=" float:left; width:224px">
<table style="width:100%;">
<tr style="background-color:Aqua">

<td colspan="2">Dışa Dönüklük testi
</td>
</tr>

<tr style="background-color:Lime">
<td>
Pratiklik
</td>
<td>
    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr style="background-color:Lime">
<td>
Sorumluluk
</td>
<td>
    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label> </td>
</tr>
<tr style="background-color:Lime">
<td>
Atılganlık
</td>
<td>
    <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
    </td>
</tr>
<tr style="background-color:Lime">
<td>
Riske Girme
</td>
<td>
    <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
    </td>
</tr>
<tr style="background-color:Lime">
<td>
Etkinlik
</td>
<td>
    <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
    </td>
</tr>
<tr style="background-color:Lime">
<td>
Sosyal Uyum
</td>
<td>
    <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
    </td>
</tr>
<tr style="background-color:Lime">
<td>
Tepkicilik
</td>
<td>
    <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
    </td>
</tr>
</table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</div>

<div style=" float:left; width:224px">
<table style="width:100%;"">
<tr style="background-color:Aqua">
<td colspan="2">Duygusal Denge Testi
</td>
</tr>

<tr style="background-color:Lime">
<td>
Uzlaşmazlık
</td>
<td class="style1">
    <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
    </td>
</tr>
<tr style="background-color:Lime">
<td>
Üstünlük
</td>
<td class="style1">
    <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
    </td>
</tr>
<tr style="background-color:Lime">
<td>
Kaygılı
</td>
<td class="style1">
    <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
    </td>
</tr>
<tr style="background-color:Lime">
<td>
Başarı Hırsı
</td>
<td class="style1">
    <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
    </td>
</tr>
<tr style="background-color:Lime">
<td>
Bağımlılık
</td>
<td class="style1">
    <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
    </td>
</tr>
<tr style="background-color:Lime">
<td>
Sıkıntılı-Üzüntülü
</td>
<td class="style1">
    <asp:Label ID="Label21" runat="server" Text="Label"></asp:Label>
    </td>
</tr>
<tr style="background-color:Lime">
<td>
Takıntılı-Saplantılı
</td>
<td class="style1">
    <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
    </td>
</tr>
</table>
</div>
</div>
<div>
<div style=" float:left">
<asp:Chart ID="Chart1" runat="server" onload="Chart1_Load">
    <series>
        <asp:Series Name="Series1" XValueType="Int32">
        </asp:Series>
    </series>
    <chartareas>
        <asp:ChartArea Name="ChartArea1">
        </asp:ChartArea>
    </chartareas>
</asp:Chart>
</div>
<div style="float:left">
    <br /><asp:TextBox ID="TextBox9" runat="server" BackColor="Orange" Width="43px"></asp:TextBox>
    <asp:Label  ID="Label23" runat="server" Text="GK"></asp:Label>
    <br /><asp:TextBox ID="TextBox10" runat="server" BackColor="Red" Width="46px"></asp:TextBox>
    <asp:Label  ID="Label24" runat="server" Text="MM"></asp:Label>
    <br /><asp:TextBox ID="TextBox11" runat="server" BackColor="Blue" Width="46px"></asp:TextBox>
    <asp:Label  ID="Label25" runat="server" Text="BS"></asp:Label>
    <br /><asp:TextBox ID="TextBox12" runat="server" BackColor="Gray" Width="47px"></asp:TextBox>
    <asp:Label  ID="Label26" runat="server" Text="PO"></asp:Label>

</div>
</div>
<br />
<div>
    <asp:TextBox ID="TextBox1" runat="server" Visible="false"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server" Visible="false"></asp:TextBox>
    <asp:TextBox ID="TextBox3" runat="server" Visible="false"></asp:TextBox>
    <asp:TextBox ID="TextBox4" runat="server" Visible="false"></asp:TextBox>
    <asp:TextBox ID="TextBox5" runat="server" Visible="false"></asp:TextBox>
    <asp:TextBox ID="TextBox6" runat="server" Visible="false"></asp:TextBox>
    <asp:TextBox ID="TextBox7" runat="server" Visible="false"></asp:TextBox>
    <asp:TextBox ID="TextBox8" runat="server" Visible="false"></asp:TextBox>
</div> 
    <div style=" float:left;">
 </br>  <a href="po.aspx" link="Lime" alink="green" vlink="red">PO -POPÜLER OPTİMİST</a>
</br>   <a href="gk.aspx" link="Lime" alink="green" vlink="red">GK- GÜÇLÜ KOLERİK</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <a href="uygunmeslek.aspx" link="Lime" alink="green" vlink="red">EN UYGUN MESLEK</a>
</br>   <a href="mm.aspx" link="Lime" alink="green" vlink="red">MM- MÜKEMMELİYETÇİ MELANKOLİK</a>
 </br>  <a href="bs.aspx" link="Lime" alink="green" vlink="red">BS -BARIŞÇIL SOĞUKKANLI</a>
 </div>
 <br />
 <br />
 <br />
 <br />
</asp:Content>
