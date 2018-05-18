using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Minuta_Plato
    {
        public int ID { get; set; }
        public int MINUTA_ID { get; set; }
        public int PLATO_ID { get; set; }
        public DateTime HORA { get; set; }/*public Nullable<System.DateTime> HORA { get; set; }*/

        public Minuta_Plato()
        {
            Init();
        }

        private void Init()
        {
            ID = 0;
            MINUTA_ID = 0;
            PLATO_ID = 0;
            HORA = DateTime.Now;

        }


        public bool Create()
        {
            try
            {
                Datos.MINUTA_PLATO minuta_plato = new Datos.MINUTA_PLATO()
                {
                    ID = ID,
                    MINUTA_ID = MINUTA_ID,
                    PLATO_ID = PLATO_ID,
                    HORA=HORA

                };
                Conexion.ModeloEntities.MINUTA_PLATO.Add(minuta_plato);
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
                Datos.MINUTA_PLATO minuta_plato = Conexion.ModeloEntities.MINUTA_PLATO.First(em => em.ID == ID);
                ID = minuta_plato.ID;
                MINUTA_ID = minuta_plato.MINUTA_ID;
                PLATO_ID = minuta_plato.PLATO_ID;
                HORA = HORA;


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
                Datos.MINUTA_PLATO minuta_plato = Conexion.ModeloEntities.MINUTA_PLATO.First(em => em.ID == ID);
                minuta_plato.ID = ID;
                minuta_plato.MINUTA_ID = MINUTA_ID;
                minuta_plato.PLATO_ID = PLATO_ID;
                minuta_plato.HORA = HORA;

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
