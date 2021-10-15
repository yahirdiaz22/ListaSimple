using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appListaSimple2021
{
    class NodoAlumno
    {

        private int numero;
        private string matricula;
        private string nombre;     
        private string apellidopaterno;
        private string apellidomaterno;
        private NodoAlumno siguiente;
        private ListaMaterias listaMateria;

        public ListaMaterias ListaMateria
        {
            get { return listaMateria; }
            set { listaMateria = value; }
        }


        public NodoAlumno Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
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
        public string Apellidopaterno
        {
            get { return apellidopaterno; }
            set { apellidopaterno = value; }
        }
        public string Apellidomaterno
        {
            get { return apellidomaterno; }
            set { apellidomaterno = value; }
        }
        public NodoAlumno()
        {
            numero = 0;            
            matricula = "";
            nombre = "";
            apellidopaterno = "";
            apellidomaterno = "";            
            listaMateria = new ListaMaterias();
            siguiente = null;
        }
        public NodoAlumno(int num, string mat, string nom, string ap,string am)
        {
            numero =num;            
            matricula = mat;
            nombre = nom;
            apellidopaterno = ap;
            apellidomaterno = am;            
            listaMateria = new ListaMaterias();
            siguiente = null;
            
        }
        public override string ToString()
        {
            if (listaMateria==null)
            {
                return numero + " - " + matricula + " - " + nombre + " - " + apellidopaterno + " - " +
                apellidomaterno;
            }
        
            return numero + " - " + matricula + " - " + nombre + " - " + apellidopaterno + " - "+ 
                apellidomaterno + "    " + listaMateria.ToString();
        }
    }
}
