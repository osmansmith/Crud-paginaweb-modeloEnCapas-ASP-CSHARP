<%@ Page Title="" Language="C#" MasterPageFile="~/MPSite.Master" AutoEventWireup="true" CodeBehind="ListarTicket.aspx.cs" Inherits="WebApplication1.Ticket.ListarTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <h1>Listado de tickets</h1>
    <asp:GridView ID="gdvListadoTickets" runat="server" HeaderStyle-HorizontalAlign="Center" DataKeyNames="Id" OnSelectedIndexChanged="gdvListadoTickets_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField CommandName="Select" Text="Ver Detalle" ButtonType="Button" ShowHeader="True" HeaderText="Ver Detalle"></asp:ButtonField>
        </Columns>
       
    </asp:GridView>
</asp:Content>
