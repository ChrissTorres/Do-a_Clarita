<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="IngresarTrabajador.aspx.cs" Inherits="HostalWeb.Presentacion.templates.IngresarTrabajador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 305px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Ingreso Trabajador</h2>


           <table style="width: 100%;">
               <tr>
                   <td>&nbsp;</td>
                   <td class="auto-style3">


           <asp:Label ID="lbRut" runat="server" Text="Rut : "></asp:Label>
                   </td>
                   <td>
              <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
              
                   </td>
               </tr>
               <tr>
                   <td>&nbsp;</td>
                   <td class="auto-style3"><asp:Label ID="lbNombre" runat="server" Text="Nombre : "></asp:Label>
                   </td>
                   <td>
              <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
              
                   </td>
               </tr>
               <tr>
                   <td>&nbsp;</td>
                   <td class="auto-style3"><asp:Label ID="lbApellido" runat="server" Text="Apellido : "></asp:Label>
                   </td>
                   <td>
              <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
              
                   </td>
               </tr>
               <tr>
                   <td>&nbsp;</td>
                   <td class="auto-style3"><asp:Label ID="lbEmpresa" runat="server" Text="Empresa : "></asp:Label>
                   </td>
                   <td>
              <asp:TextBox ID="txtEmpresa" runat="server"></asp:TextBox>
              
  

                   </td>
               </tr>
               <tr>
                   <td>&nbsp;</td>
                   <td class="auto-style3">
                       <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Limpiar" />
                   </td>
                   <td>
    <asp:Button ID="btnCreate" runat="server" Text="Ingresar"  Width="274px" OnClick="btnCreate_Click"  />
                   </td>
                   <td>
    <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
                   </td>
               </tr>
    </table>
    <br />
              
        <br />
              
        <br />
              
        <br />
              
  

    <br /><br />
    <br />
    <asp:Button ID="btnRead" runat="server" Text="Buscar"  Width="470px" OnClick="btnRead_Click" />
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Modificar"  Width="470px"  />
    <br />
    <asp:Button ID="btnlimpiar" runat="server"  Text="Limpiar Campos" Width="470px"  />
    <br />
    <br />


</asp:Content>
