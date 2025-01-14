using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// IMPRTNG 
using System.Data.SqlClient;
using System.Configuration;

namespace Lap_5
{
    public partial class Form1 : Form
    {
        string ConnectionString = "Data Source=ZAKI_OMER_22\\SQLEXPRESS;Initial Catalog=Lps;Integrated Security=True;Trust Server Certificate=True";
        string AppConfgConnectionString = ConfigurationManager.ConnectionStrings["Lap_5.Properties.Settings.LpsConnectionString"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            //SqlConnection con = new SqlConnection(AppConfgConnectionString);
            //con.Open();
            CheckDB();
        }

        void CheckDB()
        {
            using (SqlConnection conn = new SqlConnection(AppConfgConnectionString))
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException error) {
                    MessageBox.Show(error.ToString());
                }

            }
        }
    }
}
