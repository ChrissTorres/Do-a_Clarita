using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Producto
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public DateTime FECHA_VENCIMIENTO { get; set; }/*public Nullable<System.DateTime> FECHA_VENCIMIENTO { get; set; }*/
        public int TIPO_PRODUCTO_ID { get; set; }
        public int FAMILIA_ID { get; set; }
        public int PROVEEDOR_ID { get; set; }
        public long CODIGO_BARRAS { get; set; }
        public int FAMILIA_PRODUCTO_ID { get; set; }
        public int STOCK_TOTAL { get; set; }
        public int STOCK_SALDO { get; set; }

        public Producto()
        {
            Init();
        }

        private void Init()
        {
            ID = 0;
            NOMBRE = "";
            FECHA_VENCIMIENTO = DateTime.Now;
            TIPO_PRODUCTO_ID = 0;
            FAMILIA_ID = 0;
            PROVEEDOR_ID = 0;
            CODIGO_BARRAS = 0;
            FAMILIA_PRODUCTO_ID = 0;
            STOCK_TOTAL = 0;
            STOCK_SALDO = 0;

        }


        public bool Create()
        {
            try
            {
                Datos.PRODUCTO producto = new Datos.PRODUCTO()
                {
                    ID = ID,
                    NOMBRE = NOMBRE,
                    FECHA_VENCIMIENTO = FECHA_VENCIMIENTO,
                    TIPO_PRODUCTO_ID = TIPO_PRODUCTO_ID,
                    FAMILIA_ID = FAMILIA_ID,
                    PROVEEDOR_ID = PROVEEDOR_ID,
                    CODIGO_BARRAS = CODIGO_BARRAS,
                    FAMILIA_PRODUCTO_ID = FAMILIA_PRODUCTO_ID,
                    STOCK_TOTAL = STOCK_TOTAL,
                    STOCK_SALDO = STOCK_SALDO


            };
                Conexion.ModeloEntities.PRODUCTO.Add(producto);
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
                Datos.PRODUCTO producto = Conexion.ModeloEntities.PRODUCTO.First(em => em.ID == ID);
                ID = producto.ID;
                NOMBRE = producto.NOMBRE;
                FECHA_VENCIMIENTO = FECHA_VENCIMIENTO;
                TIPO_PRODUCTO_ID = producto.TIPO_PRODUCTO_ID;
                FAMILIA_ID = producto.FAMILIA_ID;
                PROVEEDOR_ID = producto.PROVEEDOR_ID;
                CODIGO_BARRAS = producto.CODIGO_BARRAS;
                FAMILIA_PRODUCTO_ID = producto.FAMILIA_PRODUCTO_ID;
                STOCK_TOTAL = producto.STOCK_TOTAL;
                STOCK_SALDO = producto.STOCK_SALDO;



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
                Datos.PRODUCTO producto = Conexion.ModeloEntities.PRODUCTO.First(em => em.ID == ID);
                producto.ID=ID;
                producto.NOMBRE=NOMBRE;
                producto.FECHA_VENCIMIENTO=FECHA_VENCIMIENTO;
                producto.TIPO_PRODUCTO_ID=TIPO_PRODUCTO_ID;
                producto.FAMILIA_ID=FAMILIA_ID;
                producto.PROVEEDOR_ID=PROVEEDOR_ID;
                producto.CODIGO_BARRAS=CODIGO_BARRAS;
                producto.FAMILIA_PRODUCTO_ID=FAMILIA_PRODUCTO_ID;
                producto.STOCK_TOTAL=STOCK_TOTAL;
                producto.STOCK_SALDO=STOCK_SALDO;


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
