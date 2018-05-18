using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Orden_Pedido_Producto
    {

        public int ID { get; set; }
        public int PRODUCTO_ID { get; set; }
        public int ORDEN_PEDIDO_ID { get; set; }
        public string DESCRIPCION { get; set; }
        public int VALOR { get; set; }

        public Orden_Pedido_Producto()
        {
            Init();
        }

        private void Init()
        {
            ID = 0;
            PRODUCTO_ID = 0;
            ORDEN_PEDIDO_ID = 0;
            DESCRIPCION = "";
            VALOR = 0;
        }


        public bool Create()
        {
            try
            {
                Datos.ORDEN_PEDIDO_PRODUCTO orden_pedido_producto = new Datos.ORDEN_PEDIDO_PRODUCTO()
                {
                    ID = ID,
                    PRODUCTO_ID = PRODUCTO_ID,
                    ORDEN_PEDIDO_ID = ORDEN_PEDIDO_ID,
                    DESCRIPCION = DESCRIPCION,
                    VALOR=VALOR

                };
                Conexion.ModeloEntities.ORDEN_PEDIDO_PRODUCTO.Add(orden_pedido_producto);
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
                Datos.ORDEN_PEDIDO_PRODUCTO orden_pedido_producto = Conexion.ModeloEntities.ORDEN_PEDIDO_PRODUCTO.First(em => em.ID == ID);
                ID = orden_pedido_producto.ID;
                PRODUCTO_ID = orden_pedido_producto.PRODUCTO_ID;
                ORDEN_PEDIDO_ID = orden_pedido_producto.ORDEN_PEDIDO_ID;
                DESCRIPCION = orden_pedido_producto.DESCRIPCION;
                VALOR = orden_pedido_producto.VALOR;


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
                Datos.ORDEN_PEDIDO_PRODUCTO orden_pedido_producto = Conexion.ModeloEntities.ORDEN_PEDIDO_PRODUCTO.First(em => em.ID == ID);
                orden_pedido_producto.ID = ID;
                orden_pedido_producto.PRODUCTO_ID = PRODUCTO_ID;
                orden_pedido_producto.ORDEN_PEDIDO_ID = ORDEN_PEDIDO_ID;
                orden_pedido_producto.DESCRIPCION = DESCRIPCION;
                orden_pedido_producto.VALOR = VALOR;

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
