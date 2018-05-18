using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;


namespace HostalWeb.Negocio
{
    public class Factura
    {
        public int ID { get; set; }
        public int ORDEN_COMPRA_ID { get; set; }
        public int EMPRESA_ID { get; set; }
        public int TOTAL { get; set; }

        public Factura()
        {
            Init();
        }

        private void Init()
        {
            ID = 0;
            ORDEN_COMPRA_ID = 0;
            EMPRESA_ID = 0;
            TOTAL = 0;
        }
        public bool Create()
        {
            try
            {
                Datos.FACTURA factura = new Datos.FACTURA()
                {
                    ID = ID,
                    ORDEN_COMPRA_ID = ORDEN_COMPRA_ID,
                    EMPRESA_ID = EMPRESA_ID,
                    TOTAL = TOTAL
                };
                Conexion.ModeloEntities.FACTURA.Add(factura);
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
                Datos.FACTURA factura = Conexion.ModeloEntities.FACTURA.First(em => em.ID == ID);
                ID = factura.ID;
                ORDEN_COMPRA_ID = factura.ORDEN_COMPRA_ID;
                EMPRESA_ID = factura.EMPRESA_ID;
                TOTAL = factura.TOTAL;
                factura.HABITACION_FACTURA = factura.HABITACION_FACTURA;
                factura.SERVICIO_FACTURA = factura.SERVICIO_FACTURA;
                

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
                Datos.FACTURA factura = Conexion.ModeloEntities.FACTURA.First(em => em.ID == ID);
                factura.ID = ID;
                factura.ORDEN_COMPRA_ID = ORDEN_COMPRA_ID;
                factura.EMPRESA_ID = EMPRESA_ID;
                factura.TOTAL = TOTAL;
                factura.HABITACION_FACTURA = factura.HABITACION_FACTURA;
                factura.SERVICIO_FACTURA = factura.SERVICIO_FACTURA;
                
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
