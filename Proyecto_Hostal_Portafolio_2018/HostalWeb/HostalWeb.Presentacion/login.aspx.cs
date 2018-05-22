using HostalWeb.Negocio;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
//using System.Data.OracleClient;
using HostalWeb.Presentacion.ServiceReference1;
namespace HostalWeb.Presentacion
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        OracleConnection conexion = new OracleConnection("DATA SOURCE = XE; PASSWORD=1234;USER ID = HOSTALDB");

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECT * FROM USUARIO WHERE NOMBRE = :usuario AND CONTRASENA = :contra", conexion);
            comando.Parameters.Add(":usuario", txtUser.Text);
            comando.Parameters.Add(":contra", txtPass.Text);

            OracleDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                if (lector["TIPO_USUARIO_ID"].ToString() == "1")
                {
                    Server.Transfer("index.aspx");
                    conexion.Close();
                }
                
            }
            //Response.Redirect("index.aspx");
            //User user = new User();
            //if (user.Authenticate())
            //{
            //    Response.Redirect("index.aspx");
        }
        
}


        //private void GetSearchLogin()
        //{
        //    //https://support.microsoft.com/en-us/help/301240/how-to-implement-forms-based-authentication-in-your-asp-net-applicatio
        //    try
        //    {
        //        User usuario = new User();
        //        Boolean _resp = false;
        //        _resp = usuario.GetSearchUsuarioLogin(txtUser.Text, txtPass.Text);

        //        if (usuario.GetSearchUsuarioLogin(txtUser.Text, txtPass.Text))
        //        {
        //            // secion con tocken de encriptacion para diferente navegadores 
        //            Session["USUARIO_USUARIO"] = usuario.NOMBRE;
        //            Session["RUN_USU"] = txtPass.Text;

        //            FormsAuthenticationTicket tkt;
        //            string cookiestr;
        //            HttpCookie ck;
        //            tkt = new FormsAuthenticationTicket(1, txtUser.Text, DateTime.Now,
        //            DateTime.Now.AddMinutes(30), chkMantenerCuenta.Checked, "tus datos personalizados");
        //            cookiestr = FormsAuthentication.Encrypt(tkt);
        //            ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);
        //            if (chkMantenerCuenta.Checked)
        //                ck.Expires = tkt.Expiration;
        //            ck.Path = FormsAuthentication.FormsCookiePath;
        //            Response.Cookies.Add(ck);

        //            string strRedirect;
        //            strRedirect = Request["ReturnUrl"];
        //            if (strRedirect == null)
        //                strRedirect = "default.aspx";
        //            Response.Redirect(strRedirect, true);
        //        }
        //        else
        //        {
        //            Response.Redirect("login.aspx", true);
        //        }
        //        usuario = null;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        //{

        //}
    }
