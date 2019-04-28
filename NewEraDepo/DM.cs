using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using NewEraDepo.Models;
using System.Windows.Forms;

namespace NewEraDepo
{

    public static class DM
    {
        public static string KodAdmin { get=>"admin";  }

        public static void DisableControls(Form form, FormNesnesi ID)
        {
           
            foreach (Control item in form.Controls)
            {
                try
                {
                    int kontrol = 0;
                    kontrol = Convert.ToInt32(item.Tag);
                    if (kontrol == ID.To<int>())
                    {
                        item.Enabled = false;
                    }
                }
                catch (Exception)
                {

                }
            }
        }
        public static void ClearFormText(Form form, FormNesnesi ID)
        {
            foreach (Control item in form.Controls)
            {
                try
                {
                    int kontrol = 0;
                    kontrol = Convert.ToInt32(item.Tag);
                    if (kontrol == ID.To<int>())
                    {
                        item.Text = "";
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        public static string ProjectName = "NewEra";
        public static Kullanici kullanici;
        public static string ConnectionString { get; set; }
        public static SqlConnection Connection { get { return new SqlConnection(ConnectionString); } }

        static DM()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["NewEra"].ConnectionString;

            if (String.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("ConnectionString");
            }
            ConnectionString = connectionString;
        }

        public static bool TextIsEmpty(this TextBox textBox)
        {
            string s = textBox.Text;
            bool result = ((s.RemoveWhitespaces()) == "");
            return result;
        }
    }
}

