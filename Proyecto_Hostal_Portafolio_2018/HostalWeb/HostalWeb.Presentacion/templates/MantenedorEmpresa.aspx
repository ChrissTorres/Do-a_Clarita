<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="MantenedorEmpresa.aspx.cs" Inherits="HostalWeb.Presentacion.templates.MantenedorEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        width: 75px;
    }
    .auto-style5 {
        width: 79px;
    }
    .auto-style6 {
        width: 201px;
    }
    .auto-style7 {
        width: 569px;
    }
        .auto-style8 {
            width: 64px;
        }
        .auto-style9 {
            width: 432px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Mantenedor Empresa</h2>

    <table style="width:100%;">
        <tr>
            <td class="auto-style8">

                &nbsp;</td>
            <td class="auto-style5">

              <asp:Label ID="lbRut" runat="server" Text="Rut : "></asp:Label>
              </td>
            <td class="auto-style4">
              <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
              
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style5"><asp:Label ID="lbNombre" runat="server" Text="Nombre : "></asp:Label>
              </td>
            <td class="auto-style4">
              <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
              
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style5"><asp:Label ID="lbGiro" runat="server" Text="Giro : "></asp:Label>
              </td>
            <td class="auto-style4">
              <asp:TextBox ID="txtGiro" runat="server"></asp:TextBox>
              
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style5"><asp:Label ID="lbDireccion" runat="server" Text="Direccion : "></asp:Label>
              </td>
            <td class="auto-style4">
              <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
              
  

            </td>
        </tr>
    </table>

              <table style="width:100%;">
                  <tr>
                      <td class="auto-style6">&nbsp;</td>
                      <td class="auto-style7">
    <asp:Button ID="btnCreate" runat="server" Text="Registrar"  Width="470px" OnClick="btnCreate_Click" />
                      </td>
                      <td>
    <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
                      </td>
                  </tr>
</table>
              
  

    <br /><br />
    <table style="width:100%;">
        <tr>
            <td class="auto-style9">
    <asp:Button ID="btnRead" runat="server" Text="Buscar" OnClick="btnRead_Click" Width="183px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">
    <asp:Button ID="btnUpdate" runat="server" Text="Modificar"  Width="182px" OnClick="btnUpdate_Click" />
            </td>
            <td>
                <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
    <asp:Button ID="btnlimpiar" runat="server"  Text="Limpiar Campos" Width="183px" OnClick="btnlimpiar_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
    <br />


</asp:Content>
