using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Habitacion
    {
        public int ID { get; set; }
        public string ESTADO { get; set; }
        public int VALOR { get; set; }
        public string DESCRIPCION { get; set; }

        private void Init()
        {
            ID = 0;
            ESTADO = "";
            VALOR = 0;
            DESCRIPCION = "";
        }
        public bool Create()
        {
            try
            {
                Datos.HABITACION habitacion = new Datos.HABITACION()
                {
                    ID = ID,
                    ESTADO = ESTADO,
                    VALOR = VALOR,
                    DESCRIPCION = DESCRIPCION
                };
                Conexion.ModeloEntities.HABITACION.Add(habitacion);
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
                Datos.HABITACION habitacion = Conexion.ModeloEntities.HABITACION.First(em => em.ID == ID);
                ID = habitacion.ID;
                ESTADO = habitacion.ESTADO;
                VALOR = habitacion.VALOR;
                DESCRIPCION = habitacion.DESCRIPCION;
                habitacion.HABITACION_FACTURA = habitacion.HABITACION_FACTURA;
                


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
                Datos.HABITACION habitacion = Conexion.ModeloEntities.HABITACION.First(em => em.ID == ID);
                habitacion.ID = ID;
                habitacion.ESTADO = ESTADO;
                habitacion.VALOR = VALOR;
                habitacion.DESCRIPCION = DESCRIPCION;
                habitacion.HABITACION_FACTURA = habitacion.HABITACION_FACTURA;
                

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
