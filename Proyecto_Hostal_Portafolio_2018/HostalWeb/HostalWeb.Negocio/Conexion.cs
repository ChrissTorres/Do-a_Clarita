using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;
using Oracle.ManagedDataAccess.Client;

namespace HostalWeb.Negocio
{
     internal class Conexion
    {
        private static HostalEntities _modeloEntities;

        public static HostalEntities ModeloEntities
        {
            get
            {
                if (_modeloEntities == null)
                {
                    _modeloEntities = new HostalEntities();
                }
                return _modeloEntities;
            }
            set { _modeloEntities = value; }
        }

        //public OracleConnection Get_Connexion()
        //{


        //    return new OracleConnection("DATA SOURCE = ConexionHostal; PASSWORD = 1234; USER ID = HostalDB");

        //}

    }
}
