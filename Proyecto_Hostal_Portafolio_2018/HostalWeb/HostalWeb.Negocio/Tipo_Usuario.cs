using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Tipo_Usuario
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }

        public Tipo_Usuario()
        {
            Inicializador();

        }
        private void Inicializador()
        {
            ID = 0;
            NOMBRE = "";

        }



        public bool Create()
        {
            try
            {
                //objeto que entra en la base de datos
                Datos.TIPO_USUARIO tipo_usuario = new Datos.TIPO_USUARIO()
                {

                    ID = ID,
                    NOMBRE = NOMBRE
                };

                Conexion.ModeloEntities.TIPO_USUARIO.Add(tipo_usuario);
                Conexion.ModeloEntities.SaveChanges(); //abre la conexion, hace el comando sql, actualiza la BD, cierra la conexion

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
                Datos.TIPO_USUARIO tipo_usuario = (from fam in Conexion.ModeloEntities.TIPO_USUARIO
                                                   where fam.ID == ID
                                                     select fam).First();
                ID = tipo_usuario.ID;
                NOMBRE = tipo_usuario.NOMBRE;


                //si no lo encuentra el resultado sera null 
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Update()
        {
            try
            {
                Datos.TIPO_USUARIO tipo_usuario = Conexion.ModeloEntities.TIPO_USUARIO.First(e => e.ID == ID);
                //aqui usamos lambda
                tipo_usuario.ID = ID;
                tipo_usuario.NOMBRE = NOMBRE;

                Conexion.ModeloEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public int GetID()
        {
            return ID;
        }
    }
}
