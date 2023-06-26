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
        public void Registrarsocio(string Nombre, string Apellido, string Edad, string Pais, int Puntaje,bool Sexo)
        {
            string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=El_Club.accdb;";
            using (OleDbConnection miConexion= new OleDbConnection(CadenaConexion)) //Conexion a la base de datos
                                                                                    //Se utiliza el bloque using garantizar que la conexión se cierre adecuadamente
            {
                miConexion.Open();//abre la conexion
                string AgregarBD = "INSERT INTO SOCIOS (NOMBRE,APELLIDO,LUGAR_NACIMIENTO,EDAD,SEXO,,PUNTAJE) " +
                    "VALUES (@Nombre,@Apellido,@Pais,@Edad,@Sexo,@Puntaje)"; //Crear la consulta SQL
                try
                {
                    miComando = new OleDbCommand();
                    miComando.Connection.Open();
                    miComando.CommandType = CommandType.Text;
                    miComando.CommandText=AgregarBD;
                    //Asignar valores a los parametros
                    miComando.Parameters.AddWithValue("@Nombre", Nombre);
                    miComando.Parameters.AddWithValue("@Apellido", Apellido);
                    miComando.Parameters.AddWithValue("@Pais",Pais);
                    miComando.Parameters.AddWithValue("@Edad", Edad);
                    miComando.Parameters.AddWithValue("@Sexo",Sexo);
                    miComando.Parameters.AddWithValue("@Puntaje", Puntaje);
                    miComando.ExecuteNonQuery(); //Ejecutar el comando
                    miConexion.Close(); //cerrar la conexion

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }
    }
}
