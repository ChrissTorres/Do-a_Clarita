using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HostalWeb.Negocio;

namespace HostalWeb.Presentacion.templates
{
    public partial class IngresarTrabajador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRead_Click(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {



            Trabajador trabajador = new Trabajador
            {
                RUT=txtRut.Text,
                NOMBRE=txtNombre.Text,
                APELLIDO=txtApellido.Text
                

            };

            bool respusta = trabajador.Create();
            if (respusta)
                lblMessages.Text = "gasto creado correctamente";
            else
                lblMessages.Text = "error al ingresar el gasto";
            //try
            //{
            //    Trabajador trab = new Trabajador()
            //    {
            //        RUT = txtRut.Text,

            //        NOMBRE = txtNombre.Text,
            //        APELLIDO = txtApellido.Text,
            //        EMPRESA_ID = int.Parse(txtEmpresa.Text)


            //    };

            //    if (trab.Read())
            //    {
            //        lblMessages.Text = "Trabajador Existente";
            //    }
            //    else if (txtRut.Text != "" && txtNombre.Text != "" && txtApellido.Text != "")
            //    {
            //        trab.Create();
            //        Clear();
            //        lblMessages.Text = "Registrado con Éxito";
            //    }
            //    else
            //    {
            //        lblMessages.Text = "No Guardado, verifique datos";
            //    }

            //}
            //catch (Exception ex)
            //{
            //    lblMessages.Text = ex.Message;
            //}
        }

        protected void btnClear_Click(object sender, EventArgs e)
         {
              Clear();
         }
        private void Clear()
        {
            txtRut.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmpresa.Text = "";
            lblMessages.Text = "";
        }
    }
}
    
