using HostalWeb.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HostalWeb.Presentacion.templates
{
    public partial class ModificarTrabajador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Trabajador trab = new Trabajador();

                if (txtRut.Text == trab.RUT)
                {
                   
                    lblMessages.Text = "Eliminado ☺";
                }
                else
                {
                    lblMessages.Text = "No Eliminado )=";
                }
            }
            catch (Exception ex)
            {

                Label1.Text = ex.Message;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Trabajador trab = new Trabajador()
                {
                    RUT = txtRut.Text,
                    NOMBRE = txtNombre.Text,
                    APELLIDO = txtApellido.Text,
                    EMPRESA_ID = int.Parse(txtEmpresa.Text)

                };
                if (txtRut.Text != "" || txtNombre.Text != "" || txtApellido.Text != "" ||txtEmpresa.Text!="")
                {
                    if (trab.Update())
                    {
                        
                        lblMessages.Text = "Actualizado ☺";
                    }
                    else
                    {
                        lblMessages.Text = "NO Actualizado";
                    }
                }
                else
                {
                    lblMessages.Text = "No se pudo Actualizar Verifique datos";
                }
            }
            catch (Exception ex)
            {
                lblMessages.Text = ex.Message;
            }
        }
    }
}