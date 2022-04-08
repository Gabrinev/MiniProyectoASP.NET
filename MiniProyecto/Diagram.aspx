<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Diagram.aspx.cs" Inherits="MiniProyecto.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    Shape selector:
    <br />
    <asp:Panel ID="Panel1" runat="server" Height="98px">
        <asp:RadioButton ID="rbRectangulo" runat="server" Checked="True" GroupName="1" Text="Rectangulo" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:RadioButton ID="rbRombo" runat="server" GroupName="1" Text="Rombo" />
        <br />
        <br />
        <asp:Button ID="btnAddShape" runat="server" OnClick="btnAddShape_Click" Text="Add Shape" />
        <br />
        <br />
    </asp:Panel>
    <asp:Image ID="img" runat="server" Height="120px" Width="200px" Visible="False" />
    <br />
    <asp:Image ID="img1" runat="server" Height="120px" Width="200px" Visible="False" />
    <br />
    <asp:Image ID="img2" runat="server" Height="120px" Width="200px" Visible="False" />
    <br />
    <asp:Image ID="img3" runat="server" Height="120px" Width="200px" Visible="False" />
    <br />
    <asp:Image ID="img4" runat="server" Height="120px" Width="200px" Visible="False"/>
</asp:Content>
