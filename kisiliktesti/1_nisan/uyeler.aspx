<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="uyeler.aspx.cs" Inherits="_1_nisan.uyeler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;<asp:Label ID="Label2" runat="server" ForeColor="#FF0066" 
        Text="TEST YAPAN KİŞİ SAYISI : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
