using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;


namespace pryRodriguezIEFI
{
    internal class clsMetodos
    {
        OleDbCommand miComando;
        OleDbConnection miConexion;
        OleDbDataReader miLector;
        OleDbCommand miComandoPais;
        string CadenaConexion= "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=El_Club.accdb;";
        public void ConectarBaseDatos()
        {
            
            try
            {
                miConexion = new OleDbConnection();
                miConexion.ConnectionString = CadenaConexion;
                miConexion.Open();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void CargarCboPais(ComboBox cboPais)
        {
            string Conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=El_Club.accdb;";
            try
            {
                miConexion = new OleDbConnection(Conexion);
                miComandoPais.Connection= miConexion;
                miComandoPais.CommandType = CommandType.Text;
                miComandoPais.CommandText = "PAISES";
                miConexion.Open();

                miLector = miComandoPais.ExecuteReader();
                cboPais.Items.Clear();
                DataTable dt = new DataTable();


                if (miLector.HasRows)
                {
                    dt.Load(miLector);
                    cboPais.DataSource = dt;
                    cboPais.ValueMember = "Id";
                    cboPais.DisplayMember = "Pais";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            miLector.Close();
        }
    }
}
