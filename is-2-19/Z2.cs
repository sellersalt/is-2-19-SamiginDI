using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace is_2_19
{
    public partial class Form2 : Form
    {
        
        
        public Form2()
        {
            InitializeComponent();
        }
        class Pod
        {
            public static string DV()
            {
             const string Host = "caseum.ru";
             const int Port = 33333;
             const string Polz = "test_user";
             const string DB = "db_test";
             const string Pass = "test_pass";

            string connStr = $"server={Host};port={Port};user={Polz};" + $"database={DB};password={Pass};";
            return connStr;
            }
        }
        MySqlConnection conn new MySqlConnection(Pod.DV());

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                conn = Open();
                MessageBox.Show("Dobro");
            }
            catch
            {
                MessageBox.Show("Zlo");
            }
        }
    }
}
