using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Tipo_Producto
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }

        public Tipo_Producto()
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
                Datos.TIPO_PRODUCTO tipo_producto = new Datos.TIPO_PRODUCTO()
                {

                    ID = ID,
                    NOMBRE = NOMBRE
                };

                Conexion.ModeloEntities.TIPO_PRODUCTO.Add(tipo_producto);
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
                Datos.TIPO_PRODUCTO tipo_producto = (from fam in Conexion.ModeloEntities.TIPO_PRODUCTO
                                                     where fam.ID == ID  select fam).First();
                ID = tipo_producto.ID;
                NOMBRE = tipo_producto.NOMBRE;


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
                Datos.TIPO_PRODUCTO tipo_producto = Conexion.ModeloEntities.TIPO_PRODUCTO.First(e => e.ID == ID);
                //aqui usamos lambda
                tipo_producto.ID = ID;
                tipo_producto.NOMBRE = NOMBRE;

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
