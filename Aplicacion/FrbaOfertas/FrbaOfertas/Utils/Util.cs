using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using FrbaOfertas.ConexionBD;



namespace FrbaOfertas.Utils
{


   public partial class Util: Form
    {

        private Util utils;

        public Util getInstance()
        {
            if (this.utils == null)
            {
                this.utils = new Util();
            }
            return this.utils;
        }



        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        public bool isAnyEmpty(Control.ControlCollection ctrlCollection)
        {
            bool aux = false;
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase && string.IsNullOrWhiteSpace(ctrl.Text))
                {
                    aux = true;
                }

            }

            return aux;
        }

        public object[] StringToArray(string input, string separator, Type type)
        {
            string[] stringList = input.Split(separator.ToCharArray(),
                                              StringSplitOptions.RemoveEmptyEntries);
            object[] list = new object[stringList.Length];

            for (int i = 0; i < stringList.Length; i++)
            {
                list[i] = Convert.ChangeType(stringList[i], type);
            }

            return list;
        }


        public BindingSource showSelect(DataGridView data, String nomTabla, params String[] parametros)
        {
            SqlConnection conn = ConexionBD.Conexion.configDBConnection();
            BindingSource bindingSource1 = new BindingSource();
            String query;
            if (parametros.Length == 1)
            {
                query = parametros[0];
            }
            else
            {
                query = parametros.Aggregate((s1, s2) => s1 + "," + s2);
            }
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT " + query + " FROM gdd." + nomTabla,conn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                //DataSet ds = new DataSet();  
                dataAdapter.Fill(table);
                // data.DataSource = ds.Tables[nomTabla].DefaultView;
                bindingSource1.DataSource = table;
                // Resize the DataGridView columns to fit the newly loaded content.
                data.AutoResizeColumns(
               DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }

            return bindingSource1;
        }


        public static long ConvertToUnixTime(DateTime datetime)
        {
            DateTime sTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            return (long)(datetime - sTime).TotalSeconds;
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        } 

    }

    }