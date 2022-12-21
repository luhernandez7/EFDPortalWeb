<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterPageLogin.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="EFDPortalWeb.MasterPages.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../JavaScrip/loginJS.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <div style="background-color:green; width: 800px; height:500px; margin:5%;">
            <img src="../Image/HCO.png" style="margin-top: 80px"/>
            <div style="margin-top: 10px; align-content:center">
                <label style="font-size:30px; font-family:'Times New Roman', Times, serif; color:white">Usuario:</label>
                <input type="text" id="Usuario" required minlength="4" maxlength="8" size="10" style="width:100px; height:15px;align-content:end"/>
            </div>
            <div style="margin-top: 10px; align-content:center;">
                <label style="font-size:30px; font-family:'Times New Roman', Times, serif; color:white">Password:</label>
                <input type="text" id="Password" required minlength="4" maxlength="8" size="10" style="width:100px; height:15px; align-content:end" />
            </div>
            <div style="margin-top: 30px; width:100%; height: 50px;">
            <button type="button" onclick="Login('Usuario', 'Password');">Aceptar</button>
            </div>
            <center><div id="msg" style="margin-top: 0px; width: 100%; height: 30px; color:white; font-size:20px; font-family:'Times New Roman', Times, serif;"></div>  </center>
        </div>
    </center>
</asp:Content>
