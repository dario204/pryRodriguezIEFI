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
        string CadenaConexion= "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\El_Club.accdb;";
        public void ConectarBaseDatos()
        {
            
            try
            {
                miConexion = new OleDbConnection();
                miConexion.ConnectionString = CadenaConexion;
                miConexion.Open();
                MessageBox.Show("BD conectada");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void CargarCboPais(ComboBox cboLugarNacimiento)
        {
            string CargarCbo = "SELECT DISTINCT Pais From Paises";
            try
            {
                //llamo los objetos conexion y comando para manipular la base de datos 
                miComando = new OleDbCommand();
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = CargarCbo;
                //reader para leer los datos que contiene
                miLector=miComando.ExecuteReader();
                while (miLector.Read())
                {
                    //Agrego la tabla paises al cboLugarNacimiento
                    cboLugarNacimiento.Items.Add(miLector["Pais"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            miLector.Close();
        }
        public void Registrarsocio(string Nombre, string Apellido, string Pais, int Edad,bool Sexo, decimal Ingreso, int Puntaje)
        {
            string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=El_Club.accdb;";
            using (OleDbConnection miConexion= new OleDbConnection(CadenaConexion)) //Conexion a la base de datos
                                                                                    //Se utiliza el bloque using garantizar que la conexión se cierre adecuadamente
            {
                miConexion.Open();//abre la conexion
                string AgregarBD = "INSERT INTO SOCIOS (NOMBRE,APELLIDO,LUGAR_NACIMIENTO,EDAD,SEXO,INGRESO,PUNTAJE) " +
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
                    miComando.Parameters.AddWithValue("@Ingreso", Ingreso);
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
        //Registrar paises nuevos a la base de datos
        public void RegistrarPais(string Pais, int CodigoPais)
        {
            string AgregarBD = "INSERT INTO PAISES(Paises, Codigo_Pais) VALUES (@Paises, @CodigoPais)";
            try
            {
                miConexion = new OleDbConnection(CadenaConexion);
                miComando = new OleDbCommand();
                miComando.Connection = miConexion;
                miComando.Connection.Open();
                miComando.CommandType = CommandType.Text;

                //Verifica que el pais no exista en la base de datos
                string verificacionsql = "SELECT COUNT(*) FROM PAISES WHERE Paises= @Paises";
                miComando.CommandText = verificacionsql;
                miComando.Parameters.AddWithValue("@Paises", Pais);
                int count = (int)miComando.ExecuteScalar();
                if (count > 0 )
                {
                    MessageBox.Show("el pais ya fue registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Si no existe lo agrega
                    miComando.Parameters.Clear(); //Limpia los anteriores parametros
                    miComando.CommandText= AgregarBD;
                    miComando.Parameters.AddWithValue("@Paises", Pais);
                    miComando.Parameters.AddWithValue("@CodigoPais", CodigoPais);
                    miComando.ExecuteNonQuery();

                    MessageBox.Show("El País fue registrado con exito", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
                
            }
        }
    }
}
