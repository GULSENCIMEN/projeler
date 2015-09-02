<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="kitapal.aspx.cs" Inherits="proje2.kitapal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 174px;
        }
        .style2
        {
            width: 882px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width:100%; left:380px; margin-top:50px;">
        <tr>
            <td class="style1" >
                Kitap Numarası:</td>
            <td class="style2">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" 
                    Text="Kitap Al" />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
            
        </tr>
      
    </table>
    </asp:Content>
