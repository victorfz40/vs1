using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion
{
    class CADProductos
    {
        private string conexion;

        public string Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }
        public ENProductos ObtenerProducto(int Id)
        {
            ENProductos p= new ENProductos();
            return p;
        }
        public static ENProductos[] ObtenerProductos()
        {
            ENProductos[] pt=new ENProductos[3];
            return pt;
        }
        public int Nuevo(ENProductos p)
        {
            ENProductos pn = new ENProductos();
            return 1;//Si es OK devuelve el ID
        }
        public int ActualizarProducto()
        {
            // ......
            return 1;//Si es OK devuelve el ID
        }


    }
}
