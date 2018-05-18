using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Colecciones
    {
        #region Empleado
        public List<EMPLEADO> ListadoEmpleado()
        {
            List<EMPLEADO> salida = new List<EMPLEADO>();
            //guarad todos los datos de todas las empresas
            foreach (Datos.EMPLEADO datosempleado in Conexion.ModeloEntities.EMPLEADO)
            {
                salida.Add(
                    new EMPLEADO()
                    {
                        ID = datosempleado.ID,
                        RUT = datosempleado.RUT,                        
                        NOMBRE = datosempleado.NOMBRE,
                        APELLIDO = datosempleado.APELLIDO,
                        CARGO = datosempleado.CARGO


                    }
          );
            }
            return salida;
        }
        #endregion

        #region Empresas
        public List<Empresa> ListadoEmpresas()
        {
            List<Empresa> salida = new List<Empresa>();
            //guarad todos los datos de todas las empresas
            foreach (Datos.EMPRESA datosempresa in Conexion.ModeloEntities.EMPRESA)
            {
                salida.Add(
                    new Empresa()
                    {
                        ID_EMPRESA = datosempresa.ID,
                        RUT_EMPRESA = datosempresa.RUT + datosempresa.DV,
                        NOMBRE_EMPRESA = datosempresa.NOMBRE,
                        DIRECCION_EMPRESA = datosempresa.DIRECCION,
                        GIRO_EMPRESA = datosempresa.GIRO
                    }
          );
            }
            return salida;
        }
        #endregion

        #region Factura
        public List<FACTURA> ListadoFactura()
        {
            List<FACTURA> salida = new List<FACTURA>();
            //guarad todos los datos de todas las empresas
            foreach (Datos.FACTURA datosfactura in Conexion.ModeloEntities.FACTURA)
            {
                salida.Add(
                    new FACTURA()
                    {
                        ID = datosfactura.ID,
                        ORDEN_COMPRA_ID = datosfactura.ORDEN_COMPRA_ID,
                        EMPRESA_ID = datosfactura.EMPRESA_ID,
                        TOTAL = datosfactura.TOTAL


                    }
                    );
            }
            return salida;
        }
        #endregion

        #region Familia_Producto
        public List<FAMILIA_PRODUCTO> ListadoFamiliaProducto()
        {
            List<FAMILIA_PRODUCTO> salida = new List<FAMILIA_PRODUCTO>();
            //guarad todos los datos de todas las empresas
            foreach (Datos.FAMILIA_PRODUCTO datosfamiliaprod in Conexion.ModeloEntities.FAMILIA_PRODUCTO)
            {
                salida.Add(
                    new FAMILIA_PRODUCTO()
                    {
                        ID = datosfamiliaprod.ID,
                        NOMBRE = datosfamiliaprod.NOMBRE


                    }
          );
            }
            return salida;
        }
        #endregion

        #region Habitacion
        public List<HABITACION> ListadoHabitacion()
        {
            List<HABITACION> salida = new List<HABITACION>();
            //guarad todos los datos de todas las empresas
            foreach (Datos.HABITACION datoshabitacion in Conexion.ModeloEntities.HABITACION)
            {
                salida.Add(
                    new HABITACION()
                    {
                        ID = datoshabitacion.ID,
                        ESTADO = datoshabitacion.ESTADO,
                        VALOR = datoshabitacion.VALOR,
                        DESCRIPCION = datoshabitacion.DESCRIPCION


                    }
          );
            }
            return salida;
        }
        #endregion

        #region Habitacion_Factura
        public List<HABITACION_FACTURA> ListadoHabitacionFactura()
        {
            List<HABITACION_FACTURA> salida = new List<HABITACION_FACTURA>();
            //guarad todos los datos de todas las empresas
            foreach (Datos.HABITACION_FACTURA datoshabitacionfactura in Conexion.ModeloEntities.HABITACION_FACTURA)
            {
                salida.Add(
                    new HABITACION_FACTURA()
                    {
                        ID = datoshabitacionfactura.ID,
                        HABITACION_ID = datoshabitacionfactura.HABITACION_ID,
                        FACTURA_ID = datoshabitacionfactura.FACTURA_ID,
                        NOMBRE = datoshabitacionfactura.NOMBRE,
                        VALOR = datoshabitacionfactura.VALOR


                    }
          );
            }
            return salida;
        }
        #endregion

        #region Habitacion_Orden_Compra
        public List<HABITACION_ORDEN_COMPRA> ListadoHabitacionOrdenCompra()
        {
            List<HABITACION_ORDEN_COMPRA> salida = new List<HABITACION_ORDEN_COMPRA>();
            //guarad todos los datos de todas las empresas
            foreach (Datos.HABITACION_ORDEN_COMPRA datoshabitacionordencompra in Conexion.ModeloEntities.HABITACION_ORDEN_COMPRA)
            {
                salida.Add(
                    new HABITACION_ORDEN_COMPRA()
                    {
                        ID = datoshabitacionordencompra.ID,
                        HABITACION_ID = datoshabitacionordencompra.HABITACION_ID,
                        ORDEN_COMPRA_ID = datoshabitacionordencompra.ORDEN_COMPRA_ID,
                        VALOR = datoshabitacionordencompra.VALOR,
                        DESCRIPCION = datoshabitacionordencompra.DESCRIPCION


                    }
          );
            }
            return salida;
        }
        #endregion



        #region Trabajador
        public List<Trabajador> ListadoTrabajadores()
        {
            List<Trabajador> salida = new List<Trabajador>();
            //guarad todos los datos de todas las empresas
            foreach (Datos.TRABAJADOR datostrabajador in Conexion.ModeloEntities.TRABAJADOR)
            {
                salida.Add(
                    new Trabajador()
                    {
                        ID = datostrabajador.ID,
                        RUT = datostrabajador.RUT + datostrabajador.DV,
                        NOMBRE = datostrabajador.NOMBRE,
                        APELLIDO = datostrabajador.APELLIDO,
                        EMPRESA_ID = datostrabajador.EMPRESA_ID
                        
                        
                    }
                    );
                      }
                    return salida;
        }

        #endregion

        #region Usuario
        public List<User> ListadoUsuario()
        {
            List<User> salida = new List<User>();
            //guarad todos los datos de todas las empresas
            foreach (Datos.USUARIO datosusuario in Conexion.ModeloEntities.USUARIO)
            {
                salida.Add(
                    new User()
                    {
                        ID = datosusuario.ID,
                        NOMBRE=datosusuario.NOMBRE
                        


                    }
                    );
            }
            return salida;
        }

        #endregion





    }
}
