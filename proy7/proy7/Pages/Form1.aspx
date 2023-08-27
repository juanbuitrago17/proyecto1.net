<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaM1.Master" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="proy7.Pages.Form1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">Pagina If
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">
   <center><h1>Actividad If</h1></center>
    <center><h2>DETERMINAR SI EL NUMERO ES POSITIVO,NEGATIVO O CERO</h2></center>
    <br/><br/>
    <form id="formularioIf" runat="server">

    <asp:Label ID="label1" runat="server" Text="Label">INGRESE EL NUMERO</asp:Label>
    <asp:TextBox ID="txtNumero1" runat="server" TextMode="Number"></asp:TextBox><br/><br/>
    <center>
        <asp:Label ID="lblresultado1" runat="server" Text=""></asp:Label><br/><br/><br/>
        <asp:Button ID="bttAceptar1" runat="server" Text="Aceptar" OnClick="bttAceptar1_Click"  />
     </center>
    </form>
</asp:Content>
