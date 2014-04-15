using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion
{
    class ENLinped
    {

        private int idPedido;

        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }


        private int idLinea;

        public int IdLinea
        {
            get { return idLinea; }
            set { idLinea = value; }
        }


        private int idArticulo;

        public int IdArticulo
        {
            get { return idArticulo; }
            set { idArticulo = value; }
        }


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        private float cantidad;

        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        private float total;

        public float Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
