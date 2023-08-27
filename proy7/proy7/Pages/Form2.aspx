<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaM1.Master" AutoEventWireup="true" CodeBehind="Form2.aspx.cs" Inherits="proy7.Pages.Form2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">Pagina Switch
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="server">
    <center><h1>Actividad Switch</h1></center>
 <center><h2>DETERMINAR EL MES QUE REPRESENTA EL NUMERO</h2></center>
 <br/><br/>
 <form id="formularioSwitch" runat="server">

 <asp:Label ID="label2" runat="server" Text="Label">INGRESE EL NUMERO</asp:Label>
 <asp:TextBox ID="txtNumero2" runat="server" TextMode="Number"></asp:TextBox><br/><br/>
 <center>
     <asp:Label ID="lblResultado2" runat="server" Text=""></asp:Label><br/><br/><br/>
 
     <asp:Button ID="bttAceptar2" runat="server" Text="Aceptar" OnClick="bttAceptar2_Click"  />
  </center>
 </form>
</asp:Content>
