<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kitapekle.aspx.cs" Inherits="proje2.kitapekle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    
    <link href="BİCİM.css" rel="Stylesheet"type ="text/css" />
    <style type="text/css">
        .style2
        {
            width: 754px;
        }
        .style3
        {
            width: 119px;
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="textbox" style="height: 590px; width: 1058px;">
    
        Kitap 
        Eklemek İçin İlgili Alanları Doldurun
        <asp:Panel ID="Panel1" runat="server" Height="435px">
            <table style="width:100%; height: 204px;">
                <tr>
                    <td class="style3">
                        Kitap Adı:</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Dili:</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Basım Yılı:</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Tür:</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox4" runat="server" Width="124px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Yayınevi Numarası:</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Ekle" />
                    </td>
                    <td class="style3">
                        <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
                    </td>
                </tr>
                <tr>
                   <td>
                   </td>
                </tr>
                <tr>
      
                   <td class="style3">
                        Kitap No</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBox16" runat="server" Width="124px"></asp:TextBox>
                    </td>
       
                </tr>
                <tr>
                   <td>
                        Kitap Adı:</td>
                    <td class="style3">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Dili:</td>
                    <td class="style3">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Basım Yılı:</td>
                    <td class="style3">
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Tür:</td>
                    <td class="style3">
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Yayınevi Numarası:</td>
                    <td class="style3">
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                            Text="Güncelle" />
                    </td>
                    <td class="style3">
                        <asp:Label ID="Label2" runat="server" Text="Label" Visible="false" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        Kitap Numarası:</td>
                    <td class="style3">
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Adı:</td>
                    <td class="style3">
                        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="Sil" onclick="Button3_Click" />
                    </td>
                    <td class="style3">
                        <asp:Label ID="Label3" runat="server" Text="Label" Visible="false"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
     </div>
    </form>
</body>
</html>