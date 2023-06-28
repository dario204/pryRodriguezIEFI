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
    public partial class frmCarga : Form
    {
        clsMetodos objManejoBd = new clsMetodos();
        public frmCarga()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm1= new frmLogin();
            frm1.Show();
        }

        private void frmCarga_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            objManejoBd.RegistrarPais(txtAgregarPais.Text, Convert.ToInt32(txtCodPais.Text));

            txtAgregarPais.Clear();
            txtCodPais.Clear();

        }

        private void txtCodPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //Permite ingresar solo numeros enteros
            }
        }

        private void txtAgregarPais_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAgregarPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true; //Permite ingresar solo letras

            }
        }
    }
}
