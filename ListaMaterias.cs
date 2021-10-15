using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appListaSimple2021
{
    class ListaMaterias
    {
        private NodoMateria head;

        public NodoMateria Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaMaterias()
        {
            head = null;
        }
        //operaciones
        //agregar
        public void Agregar(NodoMateria n)
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
            NodoMateria h = head;
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
            NodoMateria h = head;
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
        public bool Buscar(int d, ref NodoMateria b)
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
            NodoMateria h = head;
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
        public void Modificar(int d, string n, double c)
        {
            //revisar que la lista no este vacia!!!
            if (head == null)
            {
                return;
            }
            //si el nodo a modificar es el primero (head)
            if (head.Numero == d)
            {
                head.Nombre = n;
                head.Calificacion = c;
                return;
            }
            NodoMateria h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == d)
                {
                    head.Nombre = n;
                    head.Calificacion = c;
                    return;
                }
                h = h.Siguiente;
            }
            return;
        }
        public void Mostrar(ListBox lista)
        {
            NodoMateria h = head;
            lista.Items.Clear();
            while (h != null)
            {
                lista.Items.Add(h.ToString());
                h = h.Siguiente;
            }
        }
        public void Mostrar(ListView lista)
        {
            NodoMateria h = head;
            lista.Items.Clear();
            while (h != null)
            {
                //string informacion = h.ToString();
                ListViewItem renglon = new ListViewItem(h.Numero.ToString());
                renglon.SubItems.Add(h.Nombre);
                renglon.SubItems.Add(h.Calificacion.ToString());
                lista.Items.Add(renglon);
                h = h.Siguiente;
            }
        }
        public override string ToString()
        {
            string listaEnTexto = "";
            NodoMateria h = head;
            while (h != null)
            {
                listaEnTexto += h.Numero + " " + h.Nombre + " " + h.Calificacion;
                h = h.Siguiente;
            }
            return listaEnTexto;
        }
    }
}
