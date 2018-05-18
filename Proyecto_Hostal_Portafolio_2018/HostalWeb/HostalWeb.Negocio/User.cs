using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostalWeb.Negocio
{
    public class User
    {

        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string CONTRASENA { get; set; }
        public int TIPO_USUARIO_ID { get; set; }

        public User()
        {

        }

        public User(int id, string nombre, string contrasena, int tipo_usuario)
        {
            ID = id;
            NOMBRE = nombre;
            CONTRASENA = contrasena;
            TIPO_USUARIO_ID = tipo_usuario;
        }

        public bool Authenticate()
        {
            try
            {
                Datos.USUARIO user = Conexion.ModeloEntities.USUARIO.First
                    (u => u.NOMBRE == NOMBRE && u.CONTRASENA == CONTRASENA);
                NOMBRE = user.NOMBRE;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                Datos.USUARIO usuario = Conexion.ModeloEntities.USUARIO.First(em => em.ID == ID);
                ID = usuario.ID;
                NOMBRE = usuario.NOMBRE;

                //USUARIO_ID = trabajador.



                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }

 }

