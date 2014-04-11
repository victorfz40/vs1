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
        public ENProductos obtenerProducto(int Id)
        {
            ENProductos p= new ENProductos();
            return p;
        }
        public static ENProductos[] obtenerProductos()
        {
            ENProductos[] pt=new ENProductos[3];
            return pt;
        }
        public int nuevo(ENProductos p)
        {
            ENProductos pn = new ENProductos();
            return 1;//Si es OK devuelve el ID
        }
        public int actualizarProducto()
        {
            // ......
            return 1;//Si es OK devuelve el ID
        }


    }
}
