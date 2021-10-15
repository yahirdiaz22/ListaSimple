using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appListaSimple2021
{
    public partial class frmAlumnos : Form
    {
        ListaAlumnos miLista;
        public frmAlumnos()
        {
            InitializeComponent();
            miLista = new ListaAlumnos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            string matricula = txtMatricula.Text;
            string nombre = txtNombre.Text;
            string apellidoPaterno = txtApellidoPaterno.Text;
            string apellidoMaterno = txtApellidoMaterno.Text;
            NodoAlumno n = new NodoAlumno(numero, matricula,nombre, apellidoPaterno,apellidoMaterno);
            miLista.Agregar(n);
            txtNumero.Clear();
            txtNombre.Clear();
            txtMatricula.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtNumero.Focus();
            //miLista.Mostrar(lstDatos);
            miLista.Mostrar(lstvAlumnos);
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumeroMateria.Text);
            string nombre = txtNombreMateria.Text;
            double calificacion = double.Parse(txtCalificacionMateria.Text);
            NodoMateria n = new NodoMateria(numero, nombre, calificacion);
            miLista.AgregarMateria(n, numero);
            txtNumeroMateria.Clear();
            txtNombreMateria.Clear();
            txtCalificacionMateria.Clear();
            txtNumero.Focus();
            // miLista.Mostrar(lstDatos);
            miLista.Mostrar(lstvAlumnos);
        }
        private void lstvAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvAlumnos.SelectedItems.Count==0)
            {
                return;
            }
            int numeroAlumno = int.Parse(lstvAlumnos.SelectedItems[0].SubItems[0].Text);
            miLista.MostrarMateria(lstvMateria, numeroAlumno);
        }
    }
}
