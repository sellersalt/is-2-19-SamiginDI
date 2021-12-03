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
    public partial class Z4 : Form
    {
        MySqlConnection conn = new MySqlConnection(Pod.DV());
        public Z4()
        {
            InitializeComponent();
        }
        string id_rows5 = "0";
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];

                dataGridView1.CurrentRow.Selected = true;

                string index_rows5;

                index_rows5 = dataGridView1.SelectedCells[0].RowIndex.ToString();

                id_rows5 = dataGridView1.Rows[Convert.ToInt32(index_rows5)].Cells[2].Value.ToString();
                DateTime todays_date = DateTime.Today;
                DateTime Date_of_Birth = Convert.ToDateTime(dataGridView1.Rows[Convert.ToInt32(index_rows5)].Cells[2].Value.ToString());
                string result = (todays_date - Date_of_Birth).ToString(); //Тут хранится значение, которое соотвутствует прошедшим дням
                MessageBox.Show("Со дня рождения прошло " + result.Substring(0, result.Length - 9) + " дней"); //Тут это значение приводится в презентабельный вид и выводится пользователю
            }
        }

        private void Z4_Load(object sender, EventArgs e)
        {
            string sql = $"SELECT idStud, fioStud, drStud FROM t_datetime";
            try
            {
                conn.Open();

                MySqlDataAdapter IDataAdapter = new MySqlDataAdapter(sql, conn);

                DataSet dataset = new DataSet();

                IDataAdapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch
            {
                MessageBox.Show("Ошибка подключения");
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
