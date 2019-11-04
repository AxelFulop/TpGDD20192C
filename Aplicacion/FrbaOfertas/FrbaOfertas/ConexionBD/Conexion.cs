using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FrbaOfertas.Utils;


namespace FrbaOfertas.ConexionBD
{
    public partial class Conexion: Form
    {
        private Conexion conexion;
        private StringBuilder errorMessages = new StringBuilder();

        public Conexion getInstance()
        {
            if (this.conexion == null)
            {
                this.conexion = new Conexion();
            }
            return this.conexion;
        }

        public static SqlConnection GetDBConnection(string datasource, string database, string username, string password)
        {
            // Data Source=NBK033170\SQLSERVER201;Initial Catalog=testBd;Integrated Security=True
            //
            string connString;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                connString = @"Data Source=" + datasource + ";Initial Catalog="
                          + database + ";Persist Security Info=True";
            }
            else
            {
                connString = @"Data Source=" + datasource + ";Initial Catalog="
                       + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            }

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }


        public static SqlConnection configDBConnection()
        {
            string datasource = @"localhost\SQLSERVER2012";

            string database = "GD2C2019";
            string username = "gdCupon2019";
            string password = "gd2019";

            return GetDBConnection(datasource, database, username, password);
        }


        public void openConnection(SqlConnection conn)
        {
            try
            {
                conn.Open();
            }

            catch (SqlException ex)
            {

                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }

        public void closeConnection(SqlConnection conn)
        {
            try
            {
                conn.Close();
            }

            catch (SqlException ex)
            {

                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }


        //Param 1 nombre de la funcion, los restantes serian parametros propios de la funcion
        public Object executeScalarFunction(String nomFunct, params Object[] parametros)
        {
            SqlConnection conn = Conexion.configDBConnection();
            openConnection(conn);
            string split = "";
            for (int i = 0; i < parametros.Length; i++)
            {
                if (parametros[i] is string)
                    split += "'" + Convert.ToString(parametros[i]) + "'" + ",";
                else
                    split += Convert.ToString(parametros[i]) + ",";
            }
            split = split.TrimEnd(',');
            String query = "SELECT " + Properties.Settings.Default.Schema + "." + nomFunct + '(' + split + ')';
            SqlCommand cmd = new SqlCommand(query, conn);
            Object result = null;
            try
            {
                cmd.CommandType = System.Data.CommandType.Text;
                result = cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }

            closeConnection(conn);
            return result; 
        }

        public void executeProcedure(String nomProcedure, List<String> values, params Object[] parametros)
        {
            SqlConnection conn = Conexion.configDBConnection();
            using (SqlCommand cmd = new SqlCommand(nomProcedure, conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                for (int i = 0; i < parametros.Length; i++)
                {
                    cmd.Parameters.AddWithValue(values[i], parametros[i]);

                }
                openConnection(conn);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                closeConnection(conn);
            }
        }



        //Params pueden ser las columnas a retornar como una funcion de sql 
        //Le mando la cant de parametros necesarios y el ultimo elemento es otra query
        //Si no quiero un where u otra le mando null como ultimo
        //tambien puede ser un where o un order
        //por ejemplo select("usuario",2,"username","password","where username = pepito")
        public List<Object> selectReturnList(String nomTabla, int numParametros, params Object[] parametros)
        {
            List<Object> resultQuery = new List<Object>();
            String query = "SELECT ";
            SqlConnection conn = Conexion.configDBConnection();
            for (int i = 0; i < numParametros; i++)
            {
                query = query + parametros[i];
            }
            if (parametros[parametros.Length - 1] == null)
            {
                query = query + "from " + Properties.Settings.Default.Schema + "." + nomTabla + " " + parametros[parametros.Length];
            }
            query = query + "from " + Properties.Settings.Default.Schema + "." + nomTabla;
            openConnection(conn);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
         
                        while (reader.Read())
                        {
                            resultQuery.Add(Convert.ToString(reader[0]));
                        }
                    
                
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
            closeConnection(conn);
            return resultQuery;
        }




        public Object selectReturnOnlyObject(String nomTabla, String param, String parametros)
        {
            string query = "SELECT " + param + "FROM " + Properties.Settings.Default.Schema + "." + nomTabla + " " + parametros;
            SqlConnection conn = configDBConnection();
            Object result = null;
            openConnection(conn);
            try
            {
                SqlCommand myCommand = new SqlCommand(query, conn);
                result = myCommand.ExecuteScalar(); // returns the first column of the first row
                
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
            closeConnection(conn);
            return result;
        }

        public DataTable selectReturnMultiplyRows(String nomTabla, params Object[] parametros)
        {
            string query = "SELECT ";
            SqlConnection conn = Conexion.configDBConnection();
            DataTable dtResult = null;
            for (int i = 0; i < parametros.Length; i++)
            {
                query = query + parametros[i] + ",";
            }
            query = query.TrimEnd(',');
            query = query + " from " + Properties.Settings.Default.Schema + "." + nomTabla;
            openConnection(conn);
            try
            {
                SqlDataAdapter myDataAdapter = new SqlDataAdapter(query, conn);
                dtResult = new DataTable();
                myDataAdapter.Fill(dtResult);
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
            closeConnection(conn);
            return dtResult;
        }

        public List<Object> executeAdvancedSelectQuery(string query)
        {
            List<Object> resultQuery = new List<Object>();
            SqlConnection conn = Conexion.configDBConnection();

            openConnection(conn);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    resultQuery.Add(Convert.ToString(reader[0]));
                }
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
            closeConnection(conn);
            return resultQuery;
        }

        public int executeQuery(String query)
        {
            SqlConnection conn = Conexion.configDBConnection();
            int ret = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                openConnection(conn);
                ret = (int)cmd.ExecuteNonQuery();
                closeConnection(conn);
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }

            return ret;
            
        }


        /*SqlConnection conn = ConexionBD.configDBConnection();
        SqlCommand cmd = new SqlCommand(nomProcedure, conn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        try
        {
            Object split = parametros.Aggregate((i, j) => '@' + Convert.ToString(i) + ',' + '@' + Convert.ToString(j));
            String[] splitAux = Convert.ToString(split).Split(',');
            for (int i = 0; i < parametros.Length; i++)
            {
          
                cmd.Parameters.AddWithValue(splitAux[i], parametros[i]);
            }
            openConnection(conn);
            cmd.ExecuteNonQuery();
        }

        catch (SqlException ex)
        {
            for (int i = 0; i < ex.Errors.Count; i++)
            {
                errorMessages.Append("Index #" + i + "\n" +
                    "Message: " + ex.Errors[i].Message + "\n" +
                    "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                    "Source: " + ex.Errors[i].Source + "\n");
            }
            Console.WriteLine(errorMessages.ToString());
        }
        closeConnection(conn);*/
    }
}





