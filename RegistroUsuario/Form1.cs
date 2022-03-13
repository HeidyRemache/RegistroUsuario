using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroUsuario
{
    public partial class Form1 : Form
    {
        ListaUsuarios listaUsuarios = new ListaUsuarios();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Cedula = txtCedula.Text;
                usuario.Nombre = mtxtNombre.Text;
                usuario.Apellido = mtxtApellido.Text;
                usuario.Edad = Convert.ToInt32(txtEdad.Text);
                usuario.Genero = Genero();
                usuario.Nacionalidad = cmbNacionalidad.Text;
                usuario.FechaNacimiento = dtpNacimiento.Text;
                usuario.Descripcion = txtDescripcion.Text;
                usuario.Preferencias = lbPreferencias.Text;
                listaUsuarios.AgregarUsuario(usuario);
                MessageBox.Show("Datos guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string Genero()
        {
            string aux = "";
            if (rbtnMasculino.Checked)
                aux = "Masculino";
            if (rbtnFemenino.Checked)
                aux = "Femenino";
            return aux;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            try
            {
                txtCedula.Text = "";
                mtxtNombre.Text = "";
                mtxtApellido.Text = "";
                txtEdad.Text = "0";
                rbtnMasculino.Checked = false;
                rbtnFemenino.Checked = false;
                cmbNacionalidad.Text = "";
                dtpNacimiento.Value = DateTime.Now;
                txtDescripcion.Text = "";
                lbPreferencias.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.listaUsuarios2 = listaUsuarios;
        }
    }
}
