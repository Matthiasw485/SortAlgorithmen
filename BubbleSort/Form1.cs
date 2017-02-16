using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSort
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Clear();
            int anzahl = Int32.Parse(textBox1.Text);

            for (int i = 0; i < anzahl; i++)
            {
                Random rnd = new Random();
                list.Add(rnd.Next(1, 1000));
            }
            
            /*
            for (int i = 0; i < list.Max(); i++)
            {
                textBox2.Text = list[i].ToString();
            } */
        }
    }
}
