<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="moduloClientes.aspx.cs" Inherits="HostalWeb.Presentacion.moduloClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Módulo Administración Clientes</h2>
    <div class="contenedor">
        <div class="box" >
            <h3>Registrar Empresa</h3>
            <a href="../templates/MantenedorEmpresa.aspx">Mantenedor Empresa (completo)</a><br />
            <a href="../templates/RegistroEmpresa.aspx">Ingresar Empresa</a><br /><a href="../templates/ModificarEmpresa.aspx">Modificar Empresa</a>
        </div>
        <div class="box" >
             <h3>Registrar Trabajador</h3>
                <a href="../templates/MantenedorTrabajador.aspx">Mantenedor Trabajador</a><br />
                <a href="../templates/IngresarTrabajador.aspx">Ingresar Trabajador</a><br />
                <a href="../templates/ObtenerUsuario.aspx">Obtener Usuario</a><br />
                <a href="../templates/ModificarTrabajador.aspx">Modificar Trabajador</a>
        </div>
    </div>
</asp:Content>
