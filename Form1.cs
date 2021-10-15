using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace appListaSimple2021
{
    public partial class Form1 : Form
    {
        Lista milista;
        Graphics graficos;
        public Form1()
        {
            InitializeComponent();
            milista = new Lista();
            this.WindowState = FormWindowState.Maximized;
            graficos = this.CreateGraphics();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            Nodo n = new Nodo(numero,nombre,telefono);
            milista.Agregar(n);
            txtNumero.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtNumero.Focus();
            milista.Mostrar(lstDatos);
            for (int i = 0; i < lstDatos.Items.Count; i++)
            {
                DibujarRectangulo(i);

            }
            milista.Cargar("testListaSimple");
            milista.Agregar(n);
            milista.Guardar("testListaSimple");
        }
        public void DibujarRectangulo(int x)
        {
            Pen pluma = new  Pen(Color.Black, 3);
            Rectangle rectángulo = new  Rectangle(10 + (x * 120), 400, 100, 50);
            graficos.DrawRectangle(pluma, rectángulo);
            graficos.DrawLine(pluma, 80 + (x * 120), 400, 80 + (x * 120), 450);
            graficos.DrawLine(pluma, 95 + (x * 120), 425, 130 + (x * 120), 425);

        }
        public void EliminarRectangulo(int y)
        {
            Pen plumas = new  Pen(BackColor, 3);
            Rectangle rectangulos = new  Rectangle(10 + (y * 120), 400, 100, 50);
            graficos.DrawRectangle(plumas, rectangulos);
            graficos.DrawLine(plumas, 80 + (y * 120), 400, 80 + (y * 120), 450);
            graficos.DrawLine(plumas, 95 + (y * 120), 425, 130 + (y * 120), 425);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                milista.Eliminar(numero);
                txtNumero.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();
                txtNumero.Focus();
                milista.Mostrar(lstDatos);
                for (int i = 0; i < lstDatos.Items.Count; i++)
                {
                    EliminarRectangulo(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            Nodo b = new Nodo();
            if (milista.Buscar(numero,ref b))
            {
                txtNombre.Text = b.Nombre;
                txtTelefono.Text = b.Telefono;
                //MessageBox.Show("Existe");
            }
            else
            {
                txtNombre.Clear();
                txtTelefono.Clear();
               MessageBox.Show("No Existe");
            }
            txtNumero.Focus();         
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                milista.Modificar(numero,txtNombre.Text,txtTelefono.Text);
                txtNumero.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();
                txtNumero.Focus();
                milista.Mostrar(lstDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
