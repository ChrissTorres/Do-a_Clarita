using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HostalWeb.Negocio;
using System.Xml.Serialization;
using System.IO;

namespace HostalWeb.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Hostal : IHostal
    {
        public CompositeType Authenticate(string nombre, string contrasena)
        {
            User user = new User()
            {
                NOMBRE = nombre,
                CONTRASENA = contrasena
            };
            CompositeType output = new CompositeType()
            {
                Authenticated = user.Authenticate(),
                Name = user.NOMBRE
            };
            return output;

        }

        public bool CreateTrabajador(string xmlTrabajador)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Trabajador));
            StringReader reader = new StringReader(xmlTrabajador);
            Trabajador trabajador = (Trabajador)serializer.Deserialize(reader);
            return trabajador.Create();
        }

        public string ObtenerUsuario()
        {
            Colecciones collectionManager = new Colecciones();
            List<User> usuario = collectionManager.ListadoUsuario();
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, usuario);
            return writer.ToString();
        }
    }
}

