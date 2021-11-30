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
    public partial class Form1 : Form
    {
        abstract class  Komplekt <T>
        {
            public double Tsena;
            public string Year;
            public T Articul;


            public Komplekt(double tsena, string year, T articul)
            {
                Tsena = tsena;
                Year = year;
                Articul = articul;
            }
            public abstract void Display();
            
                
            
        }
        class CPU <T> : Komplekt<T>
        {
            public double Chastota { get; set; }
            public double KolYder { get; set; }
            public double KolPoto { get; set; }

            public CPU(double chastota, double kolyder, double kolpoto, double tsena, string year, T articul) : base(tsena, year, articul)
            {
                Chastota = chastota;
                KolYder = kolyder;
                KolPoto = kolpoto;
            }

            

            public override void Display()
            {
                MessageBox.Show($"Частота = {Chastota}, Количество ядер = {KolYder}, Количество потоков {KolPoto}");
            } 
           
        }
        class GPU<T> : CPU<T>
        {
            public double ChastotaGPU { get; set; }
            public string Proizv { get; set; }
            public double Obeim { get; set; }

            public GPU(double chastotagpu, string proizv, double obeim, double chastota, double kolyder, double kolpoto, double tsena, string year, T articul) : base(chastota, kolyder, kolpoto, tsena, year, articul)
            {
                ChastotaGPU = chastotagpu;
                Proizv = proizv;
                Obeim = obeim;
            }

            public override void Display()
            {
                base.Display();
                MessageBox.Show($"Цена данного предмета{Tsena}, год выпуска {Year}, Частота = {Chastota}, Количество ядер = {KolYder}, Количество потоков {KolPoto}, Частота видеокарты{ChastotaGPU}, Производитель{Proizv}, Объем памяти{Obeim}, артикул {Articul}");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GPU<string> gpu = new GPU<string>(Convert.ToDouble(textBox6.Text), textBox7.Text, Convert.ToDouble(textBox8.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox1.Text), textBox2.Text, textBox9.Text);
            gpu.Display();
            listBox1.Items.Add("dsfsdfds" + Convert.ToDouble(textBox6.Text) + textBox7.Text + Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox5.Text) + Convert.ToDouble(textBox1.Text) + textBox2.Text + textBox9.Text );
        }
    }
}
