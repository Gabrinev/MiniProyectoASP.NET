<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MiniProyecto._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form action="action_page.php" method="post">
  <div class="imgcontainer">
    &nbsp;<asp:Panel ID="Panel1" runat="server" Height="95px">
          <div class="container">
              <label for="uname">
              <b>&nbsp;Correro&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </b>
              </label>
              &nbsp;<asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
              <br />
              &nbsp;<label for="psw"><b>Password</b></label>&nbsp;
              <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
              <br />
              <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
          </div>
      </asp:Panel>
      <br />&nbsp;&nbsp;&nbsp;

    
  </div>

  <div class="container" style="background-color:#f1f1f1">
        </div>
</form>
    </asp:Content>
