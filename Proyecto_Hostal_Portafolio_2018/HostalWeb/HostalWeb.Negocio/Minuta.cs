using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Minuta
    {
        public int ID { get; set; }
        public DateTime DIA { get; set; }
        public int SERVICIO_ID { get; set; }

        public Minuta()
        {
            Init();
        }

        private void Init()
        {
            ID = 0;
            DIA = DateTime.Now;
            SERVICIO_ID = 0;
           
        }


        public bool Create()
        {
            try
            {
                Datos.MINUTA minuta = new Datos.MINUTA()
                {
                    ID = ID,
                    DIA = DIA,
                    SERVICIO_ID = SERVICIO_ID
                    
                };
                Conexion.ModeloEntities.MINUTA.Add(minuta);
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
                Datos.MINUTA minuta = Conexion.ModeloEntities.MINUTA.First(em => em.ID == ID);
                ID = minuta.ID;
                DIA = DIA;
                SERVICIO_ID = minuta.SERVICIO_ID;
                

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
                Datos.MINUTA minuta = Conexion.ModeloEntities.MINUTA.First(em => em.ID == ID);
                minuta.ID = ID;
                minuta.DIA = DIA;
                minuta.SERVICIO_ID = SERVICIO_ID;

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
