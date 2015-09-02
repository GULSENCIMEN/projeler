<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="_1_nisan.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp; &nbsp;<asp:TreeView ID="TreeView1" runat="server" ImageSet="BulletedList3" 
            ShowExpandCollapse="False">
            <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
            <Nodes>
                <asp:TreeNode NavigateUrl="~/uyeler.aspx" Text="KİŞİLER" Value="KİŞİLER">
                </asp:TreeNode>
                <asp:TreeNode Text="TESTLER" Value="TESTLER">
                    <asp:TreeNode NavigateUrl="~/test1.aspx" Text="TEST 1" Value="TEST 1">
                    </asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/test2.aspx" Text="TEST 2" Value="TEST 2">
                    </asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/ptesti.aspx" Text="P TESTİ" Value="P TESTİ">
                    </asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/rtesti.aspx" Text="R TESTİ" Value="R TESTİ">
                    </asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/uygunmeslek.aspx" Text="MESLEKLER" 
                    Value="MESLEKLER"></asp:TreeNode>
                <asp:TreeNode Text="KİŞİLİK TİPLERİ" Value="KİŞİLİK TİPLERİ">
                    <asp:TreeNode NavigateUrl="~/gk.aspx" Text="GK" Value="GK"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/mm.aspx" Text="MM" Value="MM"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/bs.aspx" Text="BS" Value="BS"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/po.aspx" Text="PO" Value="PO"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/index.aspx" Text="OTURUMU KAPAT" 
                    Value="OTURUMU KAPAT"></asp:TreeNode>
            </Nodes>
            <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" 
                HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" 
                HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>
    </p>
</asp:Content>
