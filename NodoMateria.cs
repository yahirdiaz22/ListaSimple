using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appListaSimple2021
{
    class NodoMateria 
    {
        private int numero;
        private string nombre;
        private double calificacion;
        private NodoMateria siguiente;
       public NodoMateria Siguiente
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
        public double Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
        public NodoMateria()
        {
            numero = 0;
            nombre = "";
            calificacion = 0;
            siguiente = null;
        }
        public NodoMateria(int num, string n, double c)
        {
            numero = num;
            nombre = n;
            calificacion = c;
            siguiente = null;
        }
        public override string ToString()
        {
            return nombre + " - " + calificacion;
        }
    }
}
