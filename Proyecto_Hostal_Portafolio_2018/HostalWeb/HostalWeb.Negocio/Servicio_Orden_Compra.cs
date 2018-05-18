using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Servicio_Orden_Compra
    {
        public int ID { get; set; }
        public int SERVICIO_ID { get; set; }
        public int ORDEN_COMPRA_ID { get; set; }
        public int VALOR { get; set; }
        public string DESCRIPCION { get; set; }

        public Servicio_Orden_Compra()
        {
            Init();
        }

        private void Init()
        {
            ID = 0;
            SERVICIO_ID = 0;
            ORDEN_COMPRA_ID = 0;
            DESCRIPCION = "";
            VALOR = 0;
        }


        public bool Create()
        {
            try
            {
                Datos.SERVICIO_ODEN_COMPRA servicio_orden_compra = new Datos.SERVICIO_ODEN_COMPRA()
                {
                    ID = ID,
                    SERVICIO_ID = SERVICIO_ID,
                    ORDEN_COMPRA_ID = ORDEN_COMPRA_ID,
                    DESCRIPCION = DESCRIPCION,
                    VALOR = VALOR

                };
                Conexion.ModeloEntities.SERVICIO_ODEN_COMPRA.Add(servicio_orden_compra);
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
                Datos.SERVICIO_ODEN_COMPRA servicio_orden_compra = Conexion.ModeloEntities.SERVICIO_ODEN_COMPRA.First(em => em.ID == ID);
                ID = servicio_orden_compra.ID;
                SERVICIO_ID = servicio_orden_compra.SERVICIO_ID;
                ORDEN_COMPRA_ID = servicio_orden_compra.ORDEN_COMPRA_ID;
                DESCRIPCION = servicio_orden_compra.DESCRIPCION;
                VALOR = servicio_orden_compra.VALOR;


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
                Datos.SERVICIO_ODEN_COMPRA servicio_orden_compra = Conexion.ModeloEntities.SERVICIO_ODEN_COMPRA.First(em => em.ID == ID);
                servicio_orden_compra.ID = ID;
                servicio_orden_compra.SERVICIO_ID = SERVICIO_ID;
                servicio_orden_compra.ORDEN_COMPRA_ID = ORDEN_COMPRA_ID;
                servicio_orden_compra.DESCRIPCION = DESCRIPCION;
                servicio_orden_compra.VALOR = VALOR;

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
