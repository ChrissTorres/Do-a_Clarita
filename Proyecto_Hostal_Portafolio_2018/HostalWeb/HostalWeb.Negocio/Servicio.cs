using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Servicio
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public int VALOR { get; set; }

        public Servicio()
        {
            Init();
        }

        private void Init()
        {
            ID = 0;
            NOMBRE = "";
            VALOR = 0;

        }


        public bool Create()
        {
            try
            {
                Datos.SERVICIO servicio = new Datos.SERVICIO()
                {
                    ID = ID,
                    NOMBRE = NOMBRE,
                    VALOR = VALOR

                };
                Conexion.ModeloEntities.SERVICIO.Add(servicio);
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
                Datos.SERVICIO servicio = Conexion.ModeloEntities.SERVICIO.First(em => em.ID == ID);
                ID = servicio.ID;
                NOMBRE = servicio.NOMBRE;
                VALOR = servicio.VALOR;


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
                Datos.SERVICIO servicio = Conexion.ModeloEntities.SERVICIO.First(em => em.ID == ID);
                servicio.ID = ID;
                servicio.NOMBRE = NOMBRE;
                servicio.VALOR = VALOR;

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
