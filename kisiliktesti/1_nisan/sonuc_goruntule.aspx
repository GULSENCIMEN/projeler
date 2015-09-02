<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="sonuc_goruntule.aspx.cs" Inherits="_1_nisan.sonuc_goruntule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <br />
   <br />
   <br />
   <br />
     <br />
   <br />
   <br />
   <br />
   <center>
   AŞAĞIDAN GÖRÜNTÜLEMEK İSTEDİĞİNİZ SONUCU SEÇİNİZ
   <br />
    <br />
       <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/test1_sonuc.aspx">TEST-1 SONUÇLARI</asp:HyperLink>
       <br />
       <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/test2_sonuc.aspx">TEST-2 SONUÇLARI</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/p_sonuc.aspx" >P TESTİ</asp:HyperLink>
          <br /><asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/r_sonuc.aspx">R TESTİ</asp:HyperLink>
           <br /><asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/rsonucgoruntule.aspx">TÜM SONUÇLAR</asp:HyperLink>
   </center>
   <br />
   

</asp:Content>
