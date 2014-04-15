using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion
{
    class ENPedidos
    {
        private ENLinped lineas;

        private int id;


        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


        private int idCliente;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private string nIF;

        public string NIF
        {
            get { return nIF; }
            set { nIF = value; }
        }


        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        private string cP;

        public string CP
        {
            get { return cP; }
            set { cP = value; }
        }


        private string poblacion;

        public string Poblacion
        {
            get { return poblacion; }
            set { poblacion = value; }
        }


        private int idProvincia;

        public int IdProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
        }


        private int idPais;

        public int IdPais
        {
            get { return idPais; }
            set { idPais = value; }
        }


        private float baseImp;

        public float BaseImp
        {
            get { return baseImp; }
            set { baseImp = value; }
        }


        private float impiva;

        public float Impiva
        {
            get { return impiva; }
            set { impiva = value; }
        }


        private float total;

        public float Total
        {
            get { return total; }
            set { total = value; }
        }




    }
}
