using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Habitacion_Factura
    {
        public int ID { get; set; }
        public int HABITACION_ID { get; set; }
        public int FACTURA_ID { get; set; }
        public string NOMBRE { get; set; }
        public int VALOR { get; set; }

        private void Init()
        {
            ID = 0;
            HABITACION_ID = 0;
            FACTURA_ID = 0;
            NOMBRE = "";
            VALOR = 0;
        }
        public bool Create()
        {
            try
            {
                Datos.HABITACION_FACTURA habitacion_factura = new Datos.HABITACION_FACTURA()
                {
                    ID = ID,
                    HABITACION_ID = HABITACION_ID,
                    FACTURA_ID = FACTURA_ID,
                    NOMBRE = NOMBRE,
                    VALOR=VALOR
                };
                Conexion.ModeloEntities.HABITACION_FACTURA.Add(habitacion_factura);
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
                Datos.HABITACION_FACTURA habitacion_factura = Conexion.ModeloEntities.HABITACION_FACTURA
                                                                            .First(em => em.ID == ID);
                ID = habitacion_factura.ID;
                HABITACION_ID = habitacion_factura.HABITACION_ID;
                FACTURA_ID = habitacion_factura.FACTURA_ID;
                NOMBRE = habitacion_factura.NOMBRE;
                VALOR = habitacion_factura.VALOR;



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
                Datos.HABITACION_FACTURA habitacion_factura = Conexion.ModeloEntities.HABITACION_FACTURA.First(em => em.ID == ID);
                habitacion_factura.ID = ID;
                habitacion_factura.HABITACION_ID = HABITACION_ID;
                habitacion_factura.FACTURA_ID=FACTURA_ID;
                habitacion_factura.NOMBRE = NOMBRE ;
                habitacion_factura.VALOR=VALOR ;


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
