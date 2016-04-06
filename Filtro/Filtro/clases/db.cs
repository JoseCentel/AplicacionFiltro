using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Filtro.clases
{
    public class db
    {
        private MySqlConnection connection;
        private string database;
        private string password;
        private string server;
        private string uid;
        private MySqlDataAdapter adapter;

        public void conect()
        {
            server = "//";
            database = "//";
            uid = "//";
            password = "//";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                               database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }


        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }


        public string nombre_Emp(string no_emp)
        {
            string query = "SELECT nombre FROM empleado where no_emp_asig ='" + no_emp + "'";
            if (OpenConnection())
            {
                var cmd = new MySqlCommand(query, connection);
                string Count;
                Count = Convert.ToString(cmd.ExecuteScalar() + "");
                CloseConnection();
                return Count;
            }
            return "Incorrecto";
        }


        public void insertarRegistro(string nombre_resp, string nombre_registrado, string mochila, string lonche,
            string otro, string bolsa, string celular, string coment,string gorra,string laptop,string no_emp,string lentes,string tel2)
        {
            string query =
                "INSERT INTO registro_filtro(nombre_resp,nombre_registrado,mochila,lonche,otro,bolsa,celular,hora_reg,fecha_reg,comentario,gorra,laptop,no_emp,lentes,tel2) values('" +
                nombre_resp + "','" + nombre_registrado + "','" + mochila + "','" + lonche + "','" + otro + "','" +
                bolsa + "','" + celular + "',curtime(),curdate(),'" + coment + "','"+gorra+"','"+laptop+"','"+no_emp+"','"+lentes+"','"+tel2+"')";
            if (OpenConnection())
            {
                var cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }



        public string nu_reg()
        {
            string query = "select count(id_reg) from registro_filtro where fecha_reg=curdate()";
            if (OpenConnection())
            {
                var cmd = new MySqlCommand(query, connection);
                string Count;
                Count = Convert.ToString(cmd.ExecuteScalar() + "");
                CloseConnection();
                return Count;
            }
            return "Incorrecto";
        }



        public DataTable registros(DateTimePicker dt)
        {
            string query;
            try
            {
                 query =
                   "SELECT registro_filtro.nombre_resp, registro_filtro.nombre_registrado, registro_filtro.mochila, registro_filtro.lonche, registro_filtro.otro,registro_filtro.bolsa, registro_filtro.celular,registro_filtro.hora_reg,registro_filtro.fecha_reg,registro_filtro.comentario FROM registro_filtro where fecha_reg='" +
                   dt.Value.ToString("yyyy-MM-dd") + "'";
                
                adapter = new MySqlDataAdapter(query, connection);
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                adapter.SelectCommand.Connection = connection;
                return DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }










        
    }
}