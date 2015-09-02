<%@ Page Title="" Language="C#" MasterPageFile="master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_1_nisan.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<br />
<br />
      <br />
<center>
    <asp:Image ID="Image1" runat="server" ImageUrl="~/images.jpg" />
    <br />
     <br />
      <br />
      <br />
     
TESTE BAŞLAYABİLMEK İÇİN ÖNCELİKLE GİRİŞ YAPMANIZ GEREKMEKTEDİR !!
<br />
<br />
<b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; AD</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <b>SOYAD</b>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
         <br />
         <asp:Button ID="Button1" runat="server" Text="GİRİŞ" 
        onclick="Button1_Click" />
         </center>
</asp:Content>
