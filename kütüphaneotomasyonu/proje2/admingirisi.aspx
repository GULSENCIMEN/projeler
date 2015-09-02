<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="admingirisi.aspx.cs" Inherits="proje2.admingirisi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 90px;
        }
        .style2
        {
            margin-left: 120px;
        }
        .style3
        {
            width: 534px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <br />
&nbsp;
</center>
    <table style="width:100%;">
        <tr>
            <td class="style1">
                Kullanıcı Adı:</td>
            <td class="style3" >
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="style1">
                Şifre:</td>
            <td class="style3">
                <asp:TextBox ID="TextBox2"  TextMode="password" runat="server"></asp:TextBox>
            </td>     
        </tr>
    </table>
    <table style="width: 5%;">
        <tr>
            <td class="style2">
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="kaydet" />
            </td>
        </tr>
    </table>
</asp:Content>
