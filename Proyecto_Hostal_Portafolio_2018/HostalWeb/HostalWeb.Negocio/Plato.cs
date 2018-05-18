using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Plato
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }

        public Plato()
        {
            Init();
        }

        private void Init()
        {
            ID = 0;
            NOMBRE = "";
            DESCRIPCION = "";
            
        }


        public bool Create()
        {
            try
            {
                Datos.PLATO plato = new Datos.PLATO()
                {
                    ID = ID,
                    NOMBRE=NOMBRE,                    
                    DESCRIPCION = DESCRIPCION
                    

                };
                Conexion.ModeloEntities.PLATO.Add(plato);
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
                Datos.PLATO plato = Conexion.ModeloEntities.PLATO.First(em => em.ID == ID);
                ID = plato.ID;
                NOMBRE = plato.NOMBRE;
                DESCRIPCION = plato.DESCRIPCION;
                


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
                Datos.PLATO plato = Conexion.ModeloEntities.PLATO.First(em => em.ID == ID);
                plato.ID = ID;
                plato.NOMBRE = NOMBRE;
                plato.DESCRIPCION = DESCRIPCION;
               

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
