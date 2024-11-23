<%@ Page Title="" Language="C#" MasterPageFile="~/MPSite.Master" AutoEventWireup="true" CodeBehind="EditarTicket.aspx.cs" Inherits="WebApplication1.Ticket.EditarTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Label ID="lblMessage" runat="server" Style="margin-bottom:25px"></asp:Label>
 <table>
     <tr>
         <td><asp:Label ID="lblId" runat="server" Text="Id"></asp:Label></td>
         <td><asp:Label ID="lblIdValue" runat="server"></asp:Label></td>
     </tr>
     <tr>
         <td><asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label></td>
         <td><asp:Label ID="lblNombreValue" runat="server"></asp:Label></td>
     </tr>
     <tr visible="false" runat="server" id="trRazonSocial">
        <td><asp:Label ID="lblRazonSocial" runat="server" Text="Razón Social"></asp:Label></td>
        <td><asp:Label ID="lblRazonSocialValue" runat="server"></asp:Label></td>
     </tr>
     <tr>
         <td><asp:Label ID="lblRut" runat="server" Text="Rut"></asp:Label></td>
         <td><asp:Label ID="lblRutValue" runat="server"></asp:Label></td>
     </tr>
     
     <tr>
         <td><asp:Label ID="lblTelefono" runat="server" Text="Telefono"></asp:Label></td>
         <td><asp:TextBox ID="txtTelefonoValue" AutoPostBack="true" runat="server"></asp:TextBox></td>
     </tr>
     <tr>
         <td><asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label></td>
         <td><asp:TextBox ID="txtEmailValue" AutoPostBack="true" runat="server"></asp:TextBox></td>
     </tr>
     <tr>
         <td><asp:Label ID="lblProducto" runat="server" Text="Producto"></asp:Label></td>
         <td><asp:TextBox ID="txtProductoValue" AutoPostBack="true" runat="server"></asp:TextBox></td>
     </tr>
      <tr>
          <td><asp:Label ID="lblDescripcion" runat="server" Text="Descripción"></asp:Label></td>
          <td><asp:TextBox ID="txtDescripcionValue" AutoPostBack="true" runat="server"></asp:TextBox></td>
      </tr>
      <tr>
          <td><asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label></td>
          <td><asp:Label ID="lblEstadoValue" runat="server"></asp:Label></td>
      </tr>
      <tr>          
          <td><asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" /></td>
          
      </tr>
 </table>
</asp:Content>
