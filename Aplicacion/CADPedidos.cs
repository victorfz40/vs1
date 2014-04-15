using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion
{
    class CADPedidos
    {


        private string conexion;

        public string Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }
        public ENProductos ObtenerPedido(int Id)
        {
            ENPedidos p = new ENPedidos();
            return p;
        }
        public static ENPedidos[] ObtenerPedidos()
        {
            ENPedidos[] pt = new ENPedidos[3];
            return pt;
        }
        public int Nuevo(ENPedidos p)
        {
            ENPedidos pn = new ENPedidos();
            return 1;//Si es OK devuelve el ID
        }
        public int ActualizarPedido()
        {
            // ......
            return 1;//Si es OK devuelve el ID
        }


    }
}
