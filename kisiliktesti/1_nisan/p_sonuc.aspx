<%@ Page Title="" Language="C#" MasterPageFile="~/TEST.Master" AutoEventWireup="true" CodeBehind="p_sonuc.aspx.cs" Inherits="_1_nisan.p_sonuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br />
<br />
<br />
<table style="width:100%">
<tr>
<td></td>
<td style="background-color:Orange"> 1. BÖLÜM</td>
<td style="background-color:Maroon">2. BÖLÜM</td>
<td style="background-color:Purple">TOPLAM</td>
</tr>
<tr>
<td style="background-color:Fuchsia">GK</td>
<td>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
<td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
<td><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
<td style="background-color:Olive">MM</td>
<td><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
<td><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
<td><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
<td style="background-color:ActiveCaption">BS</td>
<td><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></td>
<td><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></td>
<td><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></td>
</tr>
<tr>
<td style="background-color:ThreeDDarkShadow">PO</td>
<td><asp:Label ID="Label10" runat="server" Text="Label"></asp:Label></td>
<td><asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></td>
<td><asp:Label ID="Label12" runat="server" Text="Label"></asp:Label></td>
</tr>
</table>
<br />
<br />
<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="GERİ" onclick="Button1_Click" />
</asp:Content>
