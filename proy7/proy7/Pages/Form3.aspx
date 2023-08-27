<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaM1.Master" AutoEventWireup="true" CodeBehind="Form3.aspx.cs" Inherits="proy7.Pages.Form3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">Pagina While
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">
     <center><h1>Actividad Ciclica While</h1></center>
  <center><h2>DETERMINAR SI EL NUMERO ES PRIMO O NO</h2></center>
  <br/><br/>
  <form id="formularioIf" runat="server">

  <asp:Label ID="label3" runat="server" Text="Label">INGRESE EL NUMERO</asp:Label>
  <asp:TextBox ID="txtNumero3" runat="server" TextMode="Number"></asp:TextBox><br/><br/>
  <center>
      <asp:Label ID="lblR" runat="server" Text=""></asp:Label><br/><br/><br/>
 
      <asp:Button ID="bttAceptar3" runat="server" Text="Aceptar" OnClick="bttAceptar3_Click" />
   </center>
  </form>
</asp:Content>
