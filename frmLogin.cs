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
            if (txtNombre.Text != "" && txtApellido.Text!= "" && 
                mtbEdad.Text!= "" && cboPais.SelectedIndex!= -1 && mtbPuntaje.Text!= "" && Text!="")
            {
                btnRegistar.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            objManejoBD.ConectarBaseDatos();
            
        }
    }
}
