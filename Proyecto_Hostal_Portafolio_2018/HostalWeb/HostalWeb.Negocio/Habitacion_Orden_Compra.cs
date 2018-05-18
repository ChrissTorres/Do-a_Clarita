using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Habitacion_Orden_Compra
    {
        public int ID { get; set; }
        public int HABITACION_ID { get; set; }
        public int ORDEN_COMPRA_ID { get; set; }
        public int VALOR { get; set; }
        public string DESCRIPCION { get; set; }

        private void Init()
        {
            ID = 0;
            HABITACION_ID = 0;
            ORDEN_COMPRA_ID = 0;
            VALOR = 0;
            DESCRIPCION = "";
        }
        public bool Create()
        {
            try
            {
                Datos.HABITACION_ORDEN_COMPRA habitacion_orden_compra = new Datos.HABITACION_ORDEN_COMPRA()
                {
                    ID = ID,
                    HABITACION_ID = HABITACION_ID,
                    ORDEN_COMPRA_ID = ORDEN_COMPRA_ID,
                    VALOR = VALOR,
                    DESCRIPCION=DESCRIPCION
                };
                Conexion.ModeloEntities.HABITACION_ORDEN_COMPRA.Add(habitacion_orden_compra);
                Conexion.ModeloEntities.SaveChanges();
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
                Datos.HABITACION_ORDEN_COMPRA habitacion_orden_compra = Conexion.ModeloEntities.HABITACION_ORDEN_COMPRA.First(em => em.ID == ID);
                ID = habitacion_orden_compra.ID;
                HABITACION_ID = habitacion_orden_compra.HABITACION_ID;
                ORDEN_COMPRA_ID = habitacion_orden_compra.ORDEN_COMPRA_ID;
                VALOR = habitacion_orden_compra.VALOR;
                DESCRIPCION = habitacion_orden_compra.DESCRIPCION;



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
                Datos.HABITACION_ORDEN_COMPRA habitacion_orden_compra = Conexion.ModeloEntities.HABITACION_ORDEN_COMPRA.First(em => em.ID == ID);
                habitacion_orden_compra.ID = ID;
                habitacion_orden_compra.HABITACION_ID = HABITACION_ID;
                habitacion_orden_compra.VALOR = VALOR;
                habitacion_orden_compra.DESCRIPCION = DESCRIPCION;
                habitacion_orden_compra.ORDEN_COMPRA_ID = ORDEN_COMPRA_ID;


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
