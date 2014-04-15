using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion
{
    public class ENProductos
    {
        private int idProducto;

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }


        private string nombre_es;

        public string Nombre_es
        {
            get { return nombre_es; }
            set { nombre_es = value; }
        }


        private string nombre_en;

        public string Nombre_en
        {
            get { return nombre_en; }
            set { nombre_en = value; }
        }


        private string descripcion_es;

        public string Descripcion_es
        {
            get { return descripcion_es; }
            set { descripcion_es = value; }
        }


        private string descripcion_en;

        public string Descripcion_en
        {
            get { return descripcion_en; }
            set { descripcion_en = value; }
        }


        private float pVP;

        public float PVP
        {
            get { return pVP; }
            set { pVP = value; }
        }


        private int idFamilia;


        private int idMarca;


        private int stock;


        private float valoracion;



    }
}
