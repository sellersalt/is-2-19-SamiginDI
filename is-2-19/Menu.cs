using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_2_19
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 From1 = new Form1();
            From1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 From2 = new Form2();
            From2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Z3 From3 = new Z3();
            From3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Z4 From4 = new Z4();
            From4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Z5 From5 = new Z5();
            From5.ShowDialog();
        }
    }
}
