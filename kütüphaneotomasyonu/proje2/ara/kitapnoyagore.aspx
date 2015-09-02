<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="kitapnoyagore.aspx.cs" Inherits="proje2.ara.kitapnoyagore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="ARA" 
    onclick="Button1_Click" />
    <br />
<br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
