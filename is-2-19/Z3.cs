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
    public partial class Z3 : Form
    {
        string id_selected_rows = "0";
        public Z3()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection(Pod.DV());
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataTable table = new DataTable();
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
        

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                MessageBox.Show("Dobro");
            }
            catch
            {
                MessageBox.Show("Zlo");
            }
        }
        public void GetSelectedIDString()
        {
            //Переменная для индекс выбранной строки в гриде
            string index_selected_rows;
            //Индекс выбранной строки
            index_selected_rows = dataGridView1.SelectedCells[0].RowIndex.ToString();
            //ID конкретной записи в Базе данных, на основании индекса строки
            id_selected_rows = dataGridView1.Rows[Convert.ToInt32(index_selected_rows)].Cells[1].Value.ToString();
            //Указываем ID выделенной строки в метке
            MessageBox.Show(id_selected_rows);

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
            dataGridView1.CurrentRow.Selected = true;
            GetSelectedIDString();
        }
     

        private void Z3_Load(object sender, EventArgs e)
        {
         
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // запрос
                string sql = $"SELECT id, fio, theme_kurs FROM t_stud";
                //Объявляем команду, которая выполнить запрос в соединении conn
                MyDA.SelectCommand = new MySqlCommand(sql, conn);
                //Заполняем таблицу записями из БД
                MyDA.Fill(table);
                //Указываем, что источником данных в bindingsource является заполненная выше таблица
                bSource.DataSource = table;
                //Указываем, что источником данных ДатаГрида является bindingsource 
                dataGridView1.DataSource = bSource;
                //Закрываем соединение
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка подключения");
            }
        }
    }
}
