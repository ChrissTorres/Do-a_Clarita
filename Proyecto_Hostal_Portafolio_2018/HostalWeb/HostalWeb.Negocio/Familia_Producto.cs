using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Familia_Producto
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }

        public Familia_Producto()
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
                Datos.FAMILIA_PRODUCTO objetoDato = new Datos.FAMILIA_PRODUCTO()
                {

                   ID=ID,
                   NOMBRE=NOMBRE
                };

                Conexion.ModeloEntities.FAMILIA_PRODUCTO.Add(objetoDato);
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
                Datos.FAMILIA_PRODUCTO familia_producto_datos = (from fam in Conexion.ModeloEntities.FAMILIA_PRODUCTO
                                                                where fam.ID == ID select fam ).First();
                ID = familia_producto_datos.ID;
                NOMBRE = familia_producto_datos.NOMBRE;


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
                Datos.FAMILIA_PRODUCTO familia_producto_datos = Conexion.ModeloEntities.FAMILIA_PRODUCTO.First(e => e.ID == ID);
                //aqui usamos lambda
                familia_producto_datos.ID = ID;
                familia_producto_datos.NOMBRE = NOMBRE;
               
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

