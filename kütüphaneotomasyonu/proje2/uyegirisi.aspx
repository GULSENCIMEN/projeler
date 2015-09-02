<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="uyegirisi.aspx.cs" Inherits="proje2.uyegirisi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
  <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
  <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Image ID="Image1" runat="server" ImageUrl="~/uyee.png" 
        style="margin-top: 25px" Width="297px" Height="207px" />
    <br />
    <br />
    <br />
    <center style="margin-top: 0px">
        &nbsp;&nbsp;&nbsp;&nbsp;
        <td class="style1">
                 ÜYE ADI:&nbsp;&nbsp;&nbsp;  </td>
   <asp:TextBox ID="TextBox1" runat="server" Width="125px" ></asp:TextBox> 
      &nbsp;&nbsp;<br />
    &nbsp;&nbsp;
    <td class="style1">
                 ÜYE ŞİFRE:</td>
    <asp:TextBox ID="TextBox2" TextMode="password" runat="server" Width="125px"></asp:TextBox>
      <br />
        <br />
        <br />
<asp:Button class="button" ID="Button1" runat="server" Text="giriş" 
            onclick="Button1_Click" Width="60px" BackColor="#00CC00" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="vazgeç" 
            style="margin-left: 17px" BackColor="Red" />
        <br />
        <br />
<br />
<br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        </center>
</asp:Content>
