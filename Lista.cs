using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace appListaSimple2021
{
    class Lista
    {
        private Nodo head;

        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }
        public Lista ()
        {
            head = null;
        }
        //operaciones
        //agregar
        public void Agregar(Nodo n)
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
            Nodo h = head;
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
        
        public void Eliminar (int d)
        {
            //revisar que la lista no este vacia!!!
            if (head == null)
            {
                return;
            }
            //si el nodo a eliminar es el primero (head)
            if (head.Numero==d)
            {
                head = head.Siguiente;
                return;
            }
            Nodo h = head;
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
        public bool Buscar(int d,ref Nodo b)
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
            Nodo h = head;
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
        public void Guardar(string nombreArchivo)
        {
            Nodo h = head;
            if(head != null)
      {
                return;
            }
            nombreArchivo = "testListaSimple";
            string path =  @"C: " + nombreArchivo + " .txt ";
            using(StreamWriter  sw = File.CreateText(path))
      {
                do
        {
                    sw.WriteLine(h.Numero + " - " + h.Nombre);
                    h = h.Siguiente;
                }
                while(h != head);
            }
            return;
        }
        public void Cargar(string nombreArchivo)
        {
            nombreArchivo = "ListaSimple";
            string[] lineas = File.ReadAllLines( @"c:" + nombreArchivo + ".txt ");
            foreach (string linea in lineas)
            {
                if (linea.Length == 0)
                {
                    continue;
                }
                string[] datos = linea.Split('-');
                int numero = int.Parse(datos[0]);
                string nombre =  datos[1];
                string telefono = datos[2];
                Nodo n = new Nodo(numero, nombre, telefono);
                Agregar(n);
            }
        }
            public void Modificar(int d, string n, string t)
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
                head.Telefono = t;
                return;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == d)
                {
                    head.Nombre = n;
                    head.Telefono = t;
                    return;
                }
                h = h.Siguiente;
            }
            return;
        }
        public void Mostrar(ListBox lista)
        {
            Nodo h = head;
            lista.Items.Clear();
            while (h != null)
            {
                lista.Items.Add(h.ToString());
                h = h.Siguiente;
            }
        }
        public override string ToString()
        {
            string listaEnTexto = "";
            Nodo h = head;
            while (h != null)
            {
                listaEnTexto += h.Numero + " ";
                h = h.Siguiente;
            }
            return listaEnTexto;
        }
    }
}
