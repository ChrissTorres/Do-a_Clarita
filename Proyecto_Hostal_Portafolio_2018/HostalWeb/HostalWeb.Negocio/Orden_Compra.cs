using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Orden_Compra
    {
        public int ID { get; set; }
        public string DETALLE { get; set; }
        public int EMPRESA_ID { get; set; }
        public int CREADOR_ID { get; set; }

        public Orden_Compra()
        {
            Init();
        }

        private void Init()
        {
            ID = 0;
            DETALLE = "";
            EMPRESA_ID = 0;
            CREADOR_ID = 0;
        }


        public bool Create()
        {
            try
            {
                Datos.ORDEN_COMPRA orden_compra = new Datos.ORDEN_COMPRA()
                {
                    ID = ID,
                    DETALLE = DETALLE,
                    EMPRESA_ID = EMPRESA_ID,
                    CREADOR_ID = CREADOR_ID

                };
                Conexion.ModeloEntities.ORDEN_COMPRA.Add(orden_compra);
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
                Datos.ORDEN_COMPRA orden_compra = Conexion.ModeloEntities.ORDEN_COMPRA.First(em => em.ID == ID);
                ID = orden_compra.ID;
                DETALLE = orden_compra.DETALLE;
                EMPRESA_ID = orden_compra.EMPRESA_ID;
                CREADOR_ID = orden_compra.CREADOR_ID;


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
                Datos.ORDEN_COMPRA orden_compra = Conexion.ModeloEntities.ORDEN_COMPRA.First(em => em.ID == ID);
                orden_compra.ID = ID;
                orden_compra.DETALLE = DETALLE;
                orden_compra.EMPRESA_ID = EMPRESA_ID;
                orden_compra.CREADOR_ID = CREADOR_ID;

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
