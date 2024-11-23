<%@ Page Title="" Language="C#" MasterPageFile="~/MPSite.Master" AutoEventWireup="true" CodeBehind="CrearTicket.aspx.cs" Inherits="WebApplication1.Ticket.CrearTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
            <table style="width: 30%; margin-top:40px">
                <tr>
                    <td><asp:Label ID="lblNombre" runat="server" Text="Ingrese Cliente"></asp:Label></td>            
                    <td><asp:TextBox ID="txtNombre" runat="server" Text=""></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td><asp:Label ID="lblTipo" runat="server" Text="Ingrese tipo de cliente"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlTipo" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DdlTipo_SelectedIndexChanged">
                            <asp:ListItem disabled="true">Seleccionar</asp:ListItem>
                            <asp:ListItem>Empresa</asp:ListItem>
                            <asp:ListItem>Persona Natural</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr id="divRazonSocial" runat="server" visible="false">
                    <td><asp:Label ID="lblRazonSocial" runat="server" Text="Ingrese Razón Social"></asp:Label></td>
                    <td><asp:TextBox ID="txtRazonSocial" runat="server" Text=""></asp:TextBox></td>
                </tr>
                <tr>
                   <td><asp:Label ID="lblRut" runat="server" Text="Ingrese Rut"></asp:Label></td>            
                   <td><asp:TextBox ID="txtRut" runat="server" Text=""></asp:TextBox></td>
                   
                </tr>
                 <tr>
                    <td><asp:Label ID="lblTelefono" runat="server" Text="Ingrese Telefono"></asp:Label></td>            
                    <td><asp:TextBox ID="txtTelefono" runat="server" Text=""></asp:TextBox></td>
    
                 </tr>
                 <tr>
                    <td><asp:Label ID="lblEmail" runat="server" Text="Ingrese Email"></asp:Label></td>            
                    <td><asp:TextBox ID="txtEmail" runat="server" Text=""></asp:TextBox></td>
    
                 </tr>
                <tr>
                   <td><asp:Label ID="lblProducto" runat="server" Text="Ingrese Producto"></asp:Label></td>            
                   <td><asp:TextBox ID="txtProducto" runat="server" Text=""></asp:TextBox></td>
    
                </tr>
                <tr>
                   <td><asp:Label ID="lblDescripcion" runat="server" Text="Ingrese Descripción"></asp:Label></td>            
                   <td><asp:TextBox ID="txtDescripción" runat="server" Text=""></asp:TextBox></td>
    
                </tr>
                <tr>
                   <td><asp:Label ID="lblEstado" runat="server" Text="Ingrese Estado"></asp:Label></td>            
                   <td><asp:TextBox ID="txtEstado" runat="server" Text=""></asp:TextBox></td>
    
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnAgregarTicket" OnClick="AgregarTicket" runat="server" Text="Agregar Ticket" />
                      </td>                                       
                </tr>                
            </table>                                            
</asp:Content>
