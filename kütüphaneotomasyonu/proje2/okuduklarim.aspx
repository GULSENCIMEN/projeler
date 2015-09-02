<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="okuduklarım.aspx.cs" Inherits="proje2.okuduklarım" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />OKUDUKLARIM
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
