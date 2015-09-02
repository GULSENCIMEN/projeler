<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="admingiris.aspx.cs" Inherits="_1_nisan.admingiris" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
   <center><img src="1491661_768946846479107_30726522881292785_n%20(1).jpg" /> </center>
  <center><br />
    <br />
    <b>AD&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </b>
    &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <b>SOYAD</b>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="GİRİŞ" />
    </center>
</asp:Content>
