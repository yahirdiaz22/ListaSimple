using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appListaSimple2021
{
    class Nodo
    {
        protected int numero;
        protected string nombre;
        protected string telefono;
        protected Nodo siguiente;

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }


        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public Nodo()
        {
            numero = 0;
            nombre = "";
            telefono = "";
            siguiente = null;
        }
        public Nodo(int num, string nom, string tel)
        {
            numero = num;
            nombre = nom;
            telefono = tel;
            siguiente = null;
        }
        public override string ToString()
        {
            return numero + " - " + nombre + " - " + telefono;
        }
    }
}
