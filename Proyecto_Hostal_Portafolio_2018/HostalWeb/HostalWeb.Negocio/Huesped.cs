using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Huesped
    {
        public int ID { get; set; }
        public int TRABAJADOR_ID { get; set; }
        public int HABITACION_ID { get; set; }
        public int ENTRADA { get; set; }
        public int SALIDA { get; set; }

        private void Init()
        {
            ID = 0;
            HABITACION_ID = 0;
            TRABAJADOR_ID = 0;
            ENTRADA = 0;
            SALIDA = 0;
        }
        public bool Create()
        {
            try
            {
                Datos.HUESPED huesped = new Datos.HUESPED()
                {
                    ID = ID,
                    HABITACION_ID = HABITACION_ID,
                    TRABAJADOR_ID = TRABAJADOR_ID,
                    ENTRADA = ENTRADA,
                    SALIDA = SALIDA
                };
                Conexion.ModeloEntities.HUESPED.Add(huesped);
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
                Datos.HUESPED huesped = Conexion.ModeloEntities.HUESPED.First(em => em.ID == ID);
                ID = huesped.ID;
                HABITACION_ID = huesped.HABITACION_ID;
                TRABAJADOR_ID = huesped.TRABAJADOR_ID;
                ENTRADA = huesped.ENTRADA;
                SALIDA = huesped.SALIDA;



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
                Datos.HUESPED huesped = Conexion.ModeloEntities.HUESPED.First(em => em.ID == ID);
                huesped.ID = ID;
                huesped.HABITACION_ID = HABITACION_ID;
                huesped.TRABAJADOR_ID = TRABAJADOR_ID;
                huesped.ENTRADA = ENTRADA;
                huesped.SALIDA = SALIDA;


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
