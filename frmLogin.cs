using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezIEFI
{
    public partial class frmLogin : Form
    {
        clsMetodos objManejoBD = new clsMetodos();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            objManejoBD.ConectarBaseDatos();

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text != "")
            {
                txtEdad.Enabled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

            if (txtNombre.Text != "")
            {
                txtApellido.Enabled = true;
            }
        }





        private void cboLugarNacimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLugarNacimiento.SelectedIndex != -1)
            {
                txtPuntaje.Enabled = true;
            }

        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMasculino.Checked == true)
            {
                btnRegistar.Enabled = true;

            }
        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemenino.Checked == true)
            {
                btnRegistar.Enabled = true;

            }
        }

        private void mcrSexo_Enter(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (txtEdad.Text != "")
            {
                cboLugarNacimiento.Enabled = true;
            }
        }

        private void txtPuntaje_TextChanged(object sender, EventArgs e)
        {
            if (txtPuntaje.Text != "")
            {
                rbFemenino.Enabled = true;
                rbMasculino.Enabled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //Permite ingresar solo numeros enteros
            }
        }

        private void txtPuntaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //Permite ingresar solo numeros enteros
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true; //Permite ingresar solo letras

            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }   
        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtPuntaje.Clear();
            cboLugarNacimiento.SelectedIndex = -1;
            rbFemenino.Checked = false;
            rbMasculino.Checked = true;
            txtApellido.Enabled = false;
            txtEdad.Enabled = false;
            txtPuntaje.Enabled = false;
            rbMasculino.Checked = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            frmCarga frmDos= new frmCarga();
            frmDos.Show();
        }
    }
}

