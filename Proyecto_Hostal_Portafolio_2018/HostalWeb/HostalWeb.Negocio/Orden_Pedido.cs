using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Orden_Pedido
    {
        public int ID { get; set; }
        public string DETALLE { get; set; }
        public int PROVEEDOR_ID { get; set; }
        public int EMPLEADO_ID { get; set; }
        public string ESTADO { get; set; }

        public Orden_Pedido()
        {
            Init();
        }

        private void Init()
        {
            ID = 0;
            DETALLE = "";
            PROVEEDOR_ID = 0;
            EMPLEADO_ID = 0;
            ESTADO = "";
        }


        public bool Create()
        {
            try
            {
                Datos.ORDEN_PEDIDO orden_pedido = new Datos.ORDEN_PEDIDO()
                {
                    ID = ID,
                    DETALLE = DETALLE,
                    PROVEEDOR_ID = PROVEEDOR_ID,
                    EMPLEADO_ID = EMPLEADO_ID,
                    ESTADO=ESTADO

                };
                Conexion.ModeloEntities.ORDEN_PEDIDO.Add(orden_pedido);
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
                Datos.ORDEN_PEDIDO orden_pedido = Conexion.ModeloEntities.ORDEN_PEDIDO.First(em => em.ID == ID);

                ID = orden_pedido.ID;
                DETALLE = orden_pedido.DETALLE;
                PROVEEDOR_ID = orden_pedido.PROVEEDOR_ID;
                EMPLEADO_ID = orden_pedido.EMPLEADO_ID;
                ESTADO = orden_pedido.ESTADO;


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
                Datos.ORDEN_PEDIDO orden_pedido = Conexion.ModeloEntities.ORDEN_PEDIDO.First(em => em.ID == ID);

                orden_pedido.ID = ID;
                orden_pedido.DETALLE = DETALLE;
                orden_pedido.PROVEEDOR_ID = PROVEEDOR_ID;
                orden_pedido.EMPLEADO_ID = EMPLEADO_ID;
                orden_pedido.ESTADO = ESTADO;

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
