<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="uyelikformu.aspx.cs" Inherits="proje2.uyelikformu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <br />
&nbsp;&nbsp;&nbsp; ÜYE FORMU<br />
    <br />
    <br>
        <asp:Label ID="Label1" runat="server" Text="TC kimlik"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </br>
    <asp:Label ID="Label2" runat="server" Text="ÜYE ADI"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" Width="133px"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="ÜYE SOYADI"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:TextBox ID="TextBox3" runat="server" Width="132px"></asp:TextBox>
    <br>
    <asp:Label ID="Label4" runat="server" Text="E-MAİL"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </br>
    <asp:Label ID="Label5" runat="server" Text="TELEFON NO"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <br>
    <asp:Label ID="Label6" runat="server" Text="ADRES"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label7" runat="server" Text="MESLEK"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label8" runat="server" Text="DOGUM TARİHİ"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label9" runat="server" Text="DOGUM YERİ"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label10" runat="server" Text="ŞİFRE"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
    <br />
   <p>
       <asp:Button ID="Button1" runat="server" Text="UYE KAYDET" 
           onclick="Button1_Click" />
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;
   </p>







</asp:Content>
