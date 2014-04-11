using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion
{
    class ENLinped
    {

        private int IdPedido;

        public int IdPedido1
        {
            get { return IdPedido; }
            set { IdPedido = value; }
        }
        private int IdLinea;

        public int IdLinea1
        {
            get { return IdLinea; }
            set { IdLinea = value; }
        }
        private int IdArticulo;

        public int IdArticulo1
        {
            get { return IdArticulo; }
            set { IdArticulo = value; }
        }
        private string Nombre;

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private string Descripcion;

        public string Descripcion1
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        private float Cantidad;

        public float Cantidad1
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }
        private float Precio;

        public float Precio1
        {
            get { return Precio; }
            set { Precio = value; }
        }
        private float Total;

        public float Total1
        {
            get { return Total; }
            set { Total = value; }
        }

    }
}
