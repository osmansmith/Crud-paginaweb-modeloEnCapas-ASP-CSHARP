<%@ Page Title="" Language="C#" MasterPageFile="~/MPSite.Master" AutoEventWireup="true" CodeBehind="CrearTicket.aspx.cs" Inherits="WebApplication1.Ticket.CrearTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
            <table style="width: 30%; margin-top:40px">
                <tr>
                    <td><asp:Label ID="lblNombre" runat="server" Text="Ingrese Cliente"></asp:Label></td>            
                    <td><asp:TextBox ID="txtNombre" runat="server" Text=""></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator 
                            ID="rfvNombre" 
                            runat="server"
                            Text="*"
                            ControlToValidate="txtNombre"
                            ValidationGroup="vgCrearTicket"
                            ErrorMessage="Nombre es obligatorio" />
                        <asp:CustomValidator 
                            ID="cvMinLenNombre"
                            Text="*"
                            runat="server"
                            ControlToValidate="txtNombre"
                            OnServerValidate="cvMinLenNombre_ServerValidate" 
                            ValidationGroup="vgCrearTicket"
                            ErrorMessage="Nombre debe tener al menos 5 caracteres de largo" />

                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblTipo" runat="server" Text="Ingrese tipo de cliente"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlTipo" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DdlTipo_SelectedIndexChanged">
                            <asp:ListItem disabled="true">Seleccionar</asp:ListItem>
                            <asp:ListItem>Empresa</asp:ListItem>
                            <asp:ListItem>Persona Natural</asp:ListItem>
                        </asp:DropDownList></td>
                    <td>
                        <asp:CompareValidator 
                            ID="cvTipo" 
                            runat="server" 
                            Text="*" 
                            ControlToValidate="ddlTipo" 
                            ValidationGroup="vgCrearTicket" 
                            ValueToCompare="Seleccionar" 
                            Type="String"
                            Operator="NotEqual" 
                            ErrorMessage="Elige una opción valida"/>
                    </td>
                </tr>
                <tr id="divRazonSocial" runat="server" visible="false">
                    <td><asp:Label ID="lblRazonSocial" runat="server" Text="Ingrese Razón Social"></asp:Label></td>
                    <td><asp:TextBox ID="txtRazonSocial" runat="server" Text=""></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                   <td><asp:Label ID="lblRut" runat="server" Text="Ingrese Rut"></asp:Label></td>            
                   <td><asp:TextBox ID="txtRut" runat="server" placeholder="12345678-9" Text=""></asp:TextBox></td>
                   <td>
                       <asp:RequiredFieldValidator 
                            ID="rfvRut" 
                            runat="server"
                            Text="*"
                            ControlToValidate="txtRut"
                            ValidationGroup="vgCrearTicket"
                            ErrorMessage="Rut es obligatorio" />
                       <asp:RegularExpressionValidator 
                           ID="revRut" 
                           runat="server" 
                           Text="*"
                           ControlToValidate="txtRut"
                           ValidationGroup="vgCrearTicket"
                           ValidatorExpression="^(\d{8,9}-[\dkK])$"
                           ErrorMessage="Rut no tiene el formato esperado" />
                   </td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lblTelefono" runat="server" Text="Ingrese Telefono"></asp:Label></td>            
                    <td><asp:TextBox ID="txtTelefono" runat="server" Text=""></asp:TextBox></td>
                    <td>
                     <asp:RequiredFieldValidator 
                          ID="rfvTelefono" 
                          runat="server"
                          Text="*"
                          ControlToValidate="txtTelefono"
                          ValidationGroup="vgCrearTicket"
                          ErrorMessage="Telefono es obligatorio" />
                    </td>
                 </tr>
                 <tr>
                    <td><asp:Label ID="lblEmail" runat="server" Text="Ingrese Email"></asp:Label></td>            
                    <td><asp:TextBox ID="txtEmail" runat="server" Text=""></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator 
                             ID="rfvEmail" 
                             runat="server"
                             Text="*"
                             ControlToValidate="txtEmail"
                             ValidationGroup="vgCrearTicket"
                             ErrorMessage="Email es obligatorio" />
                         <asp:RegularExpressionValidator 
                             ID="revEmail" 
                             runat="server" 
                             Text="*"
                             ControlToValidate="txtEmail"
                             ValidationGroup="vgCrearTicket"
                             ValidatorExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"
                             ErrorMessage="Email no tiene el formato esperado" />
                    </td>
                 </tr>
                <tr>
                   <td><asp:Label ID="lblProducto" runat="server" Text="Ingrese Producto"></asp:Label></td>            
                   <td><asp:TextBox ID="txtProducto" runat="server" Text=""></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator 
                            ID="rfvProducto" 
                            runat="server"
                            Text="*"
                            ControlToValidate="txtProducto"
                            ValidationGroup="vgCrearTicket"
                            ErrorMessage="Nombre de producto es obligatorio" />
                        <asp:CustomValidator 
                            ID="cvMinLenProducto"
                            Text="*"
                            runat="server"
                            ControlToValidate="txtProducto"
                            OnServerValidate="cvMinLenProducto_ServerValidate" 
                            ValidationGroup="vgCrearTicket"
                            ErrorMessage="Nombre de producto debe tener al menos 10 caracteres de largo" />
                    </td>
                </tr>
                <tr>
                   <td><asp:Label ID="lblDescripcion" runat="server" Text="Ingrese Descripción"></asp:Label></td>            
                   <td><asp:TextBox ID="txtDescripcion" runat="server" Text=""></asp:TextBox></td>
                   <td>
                       <asp:RequiredFieldValidator 
                            ID="rfvDescripcion" 
                            runat="server"
                            Text="*"
                            ControlToValidate="txtDescripcion"
                            ValidationGroup="vgCrearTicket"
                            ErrorMessage="Descripción es obligatorio" />
                        <asp:CustomValidator 
                            ID="cvMinLenDescripcion"
                            Text="*"
                            runat="server"
                            ControlToValidate="txtDescripcion"
                            OnServerValidate="cvMinLenDescripcion_ServerValidate" 
                            ValidationGroup="vgCrearTicket"
                            ErrorMessage="Descripción debe tener al menos 10 caracteres de largo" />
                   </td>
                </tr>
                <tr>
                   <td><asp:Label ID="lblEstado" runat="server" Text="Ingrese Estado"></asp:Label></td>            
                   <td><asp:TextBox ID="txtEstado" runat="server" Text=""></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button 
                            ID="btnAgregarTicket" 
                            OnClick="AgregarTicket" 
                            runat="server" 
                            Text="Agregar Ticket"
                            ValidationGroup="vgCrearTicket" 
                            CausesValidation="true"/>
                      </td>  
                    <td></td>
                </tr>                
            </table>       
    <asp:ValidationSummary 
        ID="vsErrors" 
        runat="server" 
        ValidationGroup="vgCrearTicket" />    
</asp:Content>
