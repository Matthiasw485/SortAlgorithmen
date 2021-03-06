﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace BubbleSort
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();
        Stopwatch watch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Clear();
            listBox1.DataSource = null;

            int val = 0;
            bool res = Int32.TryParse(textBox1.Text, out val);

            if (!String.IsNullOrEmpty(textBox1.Text) && val > 0 && val < 100000)
            {
                int anzahl = Int32.Parse(textBox1.Text);
                for (int i = 0; i < anzahl; i++)
                {
                    Random rnd = new Random();
                    int curValue = rnd.Next(1, 100000);
                    while (list.Contains(curValue))
                    {
                        curValue = rnd.Next(1, 100000);
                    }
                    list.Add(curValue);
                }
                listBox1.DataSource = list;
                button3.Enabled = true;
                button1.Enabled = true;
            } else if (String.IsNullOrEmpty(textBox1.Text) || val < 1 || val >= 100000 ) { //Here add check for textbox1.text greater than 0(number)
                MessageBox.Show("Your input is not valid.", "An error occured...");
            }

            /*foreach (var all in list)
            {
                textBox2.Text = all.ToString();
            }
            for (int i = 0; i < list.Max(); i++)
            {
                textBox2.Text = list[i].ToString();
            } */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool PaarSortiert;
            int sizeOfList = list.Count;

            watch.Start();
            do
            {
                PaarSortiert = true;

                for (int i = 0; i < sizeOfList - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {

                        int temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;

                        PaarSortiert = false;
                    }
                }

            } while (!PaarSortiert);
            watch.Stop();
            label2.Text = watch.Elapsed.ToString();
            watch.Reset();
            listBox1.DataSource = null;
            listBox1.DataSource = list;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            watch.Start();
            list.Sort();
            watch.Stop();
            listBox1.DataSource = list;
            label2.Text = watch.Elapsed.ToString();
            watch.Reset();
        }
    }
  }

