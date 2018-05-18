using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HostalWeb.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IHostal
    {
        [OperationContract]
        CompositeType Authenticate(string nombre, string contrasena);

        [OperationContract]
        bool CreateTrabajador(string xmlTrabajador);

        [OperationContract]
        string ObtenerUsuario();

    }

    [DataContract]
    public class CompositeType
    {
        bool _authenticated = false;
        string _name = "";

        [DataMember]
        public bool Authenticated
        {
            get { return _authenticated; }
            set { _authenticated = value; }
        }

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

}