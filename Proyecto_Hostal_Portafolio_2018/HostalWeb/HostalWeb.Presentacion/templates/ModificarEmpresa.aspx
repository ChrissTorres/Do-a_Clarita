<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ModificarEmpresa.aspx.cs" Inherits="HostalWeb.Presentacion.templates.ModificarEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 419px;
        }
        .auto-style4 {
            width: 220px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Modificar Empresa</h2>
    
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">
        <asp:Label ID="lbRut" runat="server" Text="Rut : "></asp:Label>
                </td>
                <td class="auto-style3">
              <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
              
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4"><asp:Label ID="lbNombre" runat="server" Text="Nombre : "></asp:Label>
                </td>
                <td class="auto-style3">
              <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
              
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4"><asp:Label ID="lbGiro" runat="server" Text="Giro : "></asp:Label>
                </td>
                <td class="auto-style3">
              <asp:TextBox ID="txtGiro" runat="server"></asp:TextBox>
              
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4"><asp:Label ID="lbDireccion" runat="server" Text="Direccion : "></asp:Label>
                </td>
                <td class="auto-style3">
              <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
              
  

                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">
    <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style3">
    <asp:Button ID="btnUpdate" runat="server" Text="Modificar"  Width="213px" OnClick="btnUpdate_Click" />
                </td>
            </tr>
        </table>
   
              
        <br />
              
        <br />
              
        <br />
              
  

    <br />
    <br />
    <asp:Button ID="btnRead" runat="server" Text="Buscar" OnClick="btnRead_Click" Width="470px" />
    <br />
    <br />
    <asp:Button ID="btnlimpiar" runat="server"  Text="Limpiar Campos" Width="470px" OnClick="btnlimpiar_Click" />
    <br />
    <br />

</asp:Content>
