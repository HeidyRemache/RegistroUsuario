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
    public partial class Form2 : Form
    {
        public ListaUsuarios listaUsuarios2 = new ListaUsuarios();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = listaUsuarios2.Usuarios;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnApellido.Checked)
            {
                dgvUsuarios.DataSource = listaUsuarios2.BuscarApellido(mtxtBuscarApellido.Text);
            }
            else
            {
                dgvUsuarios.DataSource = listaUsuarios2.BuscarCedula(txtBuscarCedula.Text);
            }
        }
    }
}
