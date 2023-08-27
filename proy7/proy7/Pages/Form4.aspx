<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaM1.Master" AutoEventWireup="true" CodeBehind="Form4.aspx.cs" Inherits="proy7.Pages.Form4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server"> Pagina Try-Catch
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">
       <center><h1>Actividad Try-Catch</h1></center>
<center><h2>CONVERTIR UN NUMERO A BYTE</h2></center>
<br/><br/>
<form id="formularioIf" runat="server">

<asp:Label ID="label4" runat="server" Text="Label">INGRESE EL NUMERO</asp:Label>
<asp:TextBox ID="txtNumero4" runat="server" TextMode="Number"></asp:TextBox><br/><br/>
<center>
    <asp:Label ID="lblResultado4" runat="server" Text=""></asp:Label><br/><br/><br/>
 
    <asp:Button ID="bttAceptar4" runat="server" Text="Aceptar" OnClick="bttAceptar4_Click"  />
 </center>
</form>
</asp:Content>
