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
        public void CargarCboNombre(ComboBox cboNombre)
        {
            try
            {
                miComando = new OleDbCommand();
                miComando.CommandType = System.Data.CommandType.TableDirect;
                miComando.CommandText = "SOCIOS";

                miLector = miComando.ExecuteReader();
                cboNombre.Items.Clear();
                DataTable dt = new DataTable();

                if (miLector.HasRows)
                {
                    dt.Load(miLector);
                    cboNombre.DataSource = dt;
                    cboNombre.ValueMember = "IdVendedor";
                    cboNombre.DisplayMember = "NomVendedor";
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
        public void CargarCboApellido(ComboBox cboApellido)
        {
            try
            {
                miComando = new OleDbCommand();
                miComando.CommandType = System.Data.CommandType.TableDirect;
                miComando.CommandText = "SOCIOS";

                miLector = miComando.ExecuteReader();
                cboApellido.Items.Clear();
                DataTable dt = new DataTable();

                if (miLector.HasRows)
                {
                    dt.Load(miLector);
                    cboApellido.DataSource = dt;
                    cboApellido.ValueMember = "IdVendedor";
                    cboApellido.DisplayMember = "NomVendedor";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            miLector.Close();
        }
        public void CargarCboEdad(ComboBox cboEdad)
        {

            try
            {
                miComando = new OleDbCommand();
                miComando.CommandType = System.Data.CommandType.TableDirect;
                miComando.CommandText = "SOCIOS";

                miLector = miComando.ExecuteReader();
                cboEdad.Items.Clear();
                DataTable dt = new DataTable();

                if (miLector.HasRows)
                {
                    dt.Load(miLector);
                    cboEdad.DataSource = dt;
                    cboEdad.ValueMember = "IdVendedor";
                    cboEdad.DisplayMember = "NomVendedor";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            miLector.Close();
        }
        public void CargarCboPais(ComboBox cboPais)
        {
            try
            {
                miComando = new OleDbCommand();
                miComando.CommandType = System.Data.CommandType.TableDirect;
                miComando.CommandText = "SOCIOS";

                miLector = miComando.ExecuteReader();
                cboPais.Items.Clear();
                DataTable dt = new DataTable();

                if (miLector.HasRows)
                {
                    dt.Load(miLector);
                    cboPais.DataSource = dt;
                    cboPais.ValueMember = "IdVendedor";
                    cboPais.DisplayMember = "NomVendedor";
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
