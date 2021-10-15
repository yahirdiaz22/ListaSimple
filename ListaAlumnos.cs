using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appListaSimple2021
{
    class ListaAlumnos
    {
        private NodoAlumno head;

        public NodoAlumno Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaAlumnos()
        {
            head = null;
        }
        //operaciones
        //agregar
        public void Agregar(NodoAlumno n)
        {
            //Lista esta vacia
            if (head == null)
            {
                head = n;
                return;
            }
            //No esta vacia
            if (n.Numero < head.Numero)
            {
                //alInicio
                n.Siguiente = head;
                head = n;
                return;
            }
            NodoAlumno h = head;
            while (h.Siguiente != null)
            {
                if (n.Numero < h.Siguiente.Numero)
                {
                    break;
                }
                h = h.Siguiente;
            }

            n.Siguiente = h.Siguiente;
            h.Siguiente = n;


        }

        public void AgregarMateria(NodoMateria n, int num)
        {
            //revisar que la lista no este vacia!!!
            if (head == null)
            {
                return ;
            }
            //si el nodo a buscar es el primero (head)
            if (head.Numero == num)
            {
                head.ListaMateria.Agregar(n);
                return ;
            }
            NodoAlumno h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == num)
                {
                    h.Siguiente.ListaMateria.Agregar(n);
                    return ;
                }
                h = h.Siguiente;
            }
            return ;
        }
         
           
        public void Eliminar(int d)
        {
            //revisar que la lista no este vacia!!!
            if (head == null)
            {
                return;
            }
            //si el nodo a eliminar es el primero (head)
            if (head.Numero == d)
            {
                head = head.Siguiente;
                return;
            }
            NodoAlumno h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente != null)
                {
                    break;
                }
                h = h.Siguiente;
            }
            if (h.Siguiente != null)
            {
                h.Siguiente = h.Siguiente.Siguiente;

            }
        }
        public bool Buscar(int d, ref NodoAlumno b)
        {
            //revisar que la lista no este vacia!!!
            if (head == null)
            {
                return false;
            }
            //si el nodo a eliminar es el primero (head)
            if (head.Numero == d)
            {
                b = head;
                return true;
            }
            NodoAlumno h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == d)
                {
                    return true;
                }
                h = h.Siguiente;
            }
            return false;
        }
        public void Modificar(int num, string m, string ap, string am, string n,
            ListaMaterias lm)
        {
            //revisar que la lista no este vacia!!!
            if (head == null)
            {
                return;
            }
            //si el nodo a modificar es el primero (head)
            if (head.Numero == num)
            {
                head.Nombre = n;
                head.Apellidopaterno = ap;
                head.Apellidomaterno = am;
                head.ListaMateria = lm;
                return;
            }
            NodoAlumno h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == num)
                {
                    head.Nombre = n;
                   // head.Calificacion = c;
                    return;
                }
                h = h.Siguiente;
            }
            return;
        }
      
            public void Mostrar(ListBox lista)
        {
            NodoAlumno h = head;
            lista.Items.Clear();
            while (h != null)
            {
                lista.Items.Add(h.ToString());
                h = h.Siguiente;
            }
        }
        public void MostrarMateria(ListView lista,int numeroAlumno)
        {
            NodoAlumno h = head;
            lista.Items.Clear();
            while (h != null)
            {
                if (h.Numero==numeroAlumno)
                {
                    h.ListaMateria.Mostrar(lista);
                }
                h = h.Siguiente;
            }
        }
        public void Mostrar(ListView lista)
        {
            NodoAlumno h = head;
            lista.Items.Clear();
            while (h != null)
            {
                //string informacion = h.ToString();
                ListViewItem renglon = new ListViewItem(h.Numero.ToString());
                renglon.SubItems.Add(h.Matricula);
                renglon.SubItems.Add(h.Nombre + " "+ h.Apellidopaterno + " " + h.Apellidomaterno);
                lista.Items.Add(renglon);
                h = h.Siguiente;
            }
        }
        public override string ToString()
        {
            string listaEnTexto = "";
            NodoAlumno h = head;
            while (h != null)
            {
                listaEnTexto += h.Numero + " ";
                h = h.Siguiente;
            }
            return listaEnTexto;
        }
    }
}
