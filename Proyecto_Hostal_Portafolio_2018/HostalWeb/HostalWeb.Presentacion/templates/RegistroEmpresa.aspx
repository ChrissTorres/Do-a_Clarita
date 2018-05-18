<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="RegistroEmpresa.aspx.cs" Inherits="HostalWeb.Presentacion.templates.IngresarEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Registrar Empresa</h2>

              <table style="width:100%;">
                  <tr>
                      <td>&nbsp;</td>
                      <td>

              <asp:Label ID="lbRut" runat="server" Text="Rut : "></asp:Label>
                      </td>
                      <td>
              <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
              
                      </td>
                  </tr>
                  <tr>
                      <td>&nbsp;</td>
                      <td><asp:Label ID="lbNombre" runat="server" Text="Nombre : "></asp:Label>
                      </td>
                      <td>
              <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
              
                      </td>
                  </tr>
                  <tr>
                      <td>&nbsp;</td>
                      <td><asp:Label ID="lbGiro" runat="server" Text="Giro : "></asp:Label>
                      </td>
                      <td>
              <asp:TextBox ID="txtGiro" runat="server"></asp:TextBox>
              
                      </td>
                  </tr>
                  <tr>
                      <td>&nbsp;</td>
                      <td><asp:Label ID="lbDireccion" runat="server" Text="Direccion : "></asp:Label>
                      </td>
                      <td>
              <asp:TextBox ID="txtDireccion" runat="server" OnTextChanged="txtDireccion_TextChanged"></asp:TextBox>
              
  

                      </td>
                  </tr>
                  <tr>
                      <td></td>
                      <td>
                          <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
                      </td>
                      <td>
                          <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                          </td>
                  </tr>
                  <tr>
                      <td>&nbsp;</td>
                      <td>
                          <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
                      </td>
                      <td>
                          <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
                      </td>
                  </tr>
                  <tr>
                      <td>&nbsp;</td>
                      <td>
    <asp:Button ID="btnlimpiar" runat="server"  Text="Limpiar Campos" Width="221px" OnClick="btnlimpiar_Click" />
                      </td>
                      <td>
    <asp:Button ID="btnCreate" runat="server" Text="Ingresar"  Width="241px" OnClick="btnCreate_Click" />
                      </td>
                      <td>
    <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
                      </td>
                  </tr>
    </table>
    <br />


</asp:Content>
