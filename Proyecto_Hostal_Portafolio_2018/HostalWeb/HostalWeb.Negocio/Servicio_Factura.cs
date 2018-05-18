using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Servicio_Factura
    {
        public int ID { get; set; }
        public int SERVICIO_ID { get; set; }
        public string NOMBRE { get; set; }
        public int VALOR { get; set; }
        public int FACTURA_ID { get; set; }

        public Servicio_Factura()
        {
            Init();
        }

        private void Init()
        {
            ID = 0;
            SERVICIO_ID = 0;
            NOMBRE = "";
            VALOR = 0;
            FACTURA_ID = 0;

        }


        public bool Create()
        {
            try
            {
                Datos.SERVICIO_FACTURA servicio_factura = new Datos.SERVICIO_FACTURA()
                {
                    ID = ID,
                    SERVICIO_ID=SERVICIO_ID,
                    NOMBRE = NOMBRE,
                    VALOR = VALOR,
                    FACTURA_ID=FACTURA_ID

                };
                Conexion.ModeloEntities.SERVICIO_FACTURA.Add(servicio_factura);
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
                Datos.SERVICIO_FACTURA servicio_factura = Conexion.ModeloEntities.SERVICIO_FACTURA.First(em => em.ID == ID);
                ID = servicio_factura.ID;
                SERVICIO_ID = servicio_factura.SERVICIO_ID;
                NOMBRE = servicio_factura.NOMBRE;
                VALOR = servicio_factura.VALOR;
                FACTURA_ID = servicio_factura.FACTURA_ID;


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
                Datos.SERVICIO_FACTURA servicio_factura = Conexion.ModeloEntities.SERVICIO_FACTURA.First(em => em.ID == ID);
                servicio_factura.ID = ID;
                servicio_factura.SERVICIO_ID = SERVICIO_ID;
                servicio_factura.NOMBRE = NOMBRE;
                servicio_factura.VALOR = VALOR;
                servicio_factura.FACTURA_ID = FACTURA_ID;

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
