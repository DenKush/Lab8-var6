using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__8.Вариант_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            dataGridView1.RowCount = 15;
            dataGridView1.ColumnCount = 15;
            int[,] A = new int[15, 15];
            Random rnd = new Random();
            int i, j;
            for (i = 0; i < A.GetLength(0); i++)
                for (j = 0; j < A.GetLength(1); j++)
                    A[i, j] = rnd.Next(-100, 100);
            for (i = 0; i < A.GetLength(0); i++)
                for (j = 0; j < A.GetLength(1); j++)
                    dataGridView1.Rows[i].Cells[j].Value = A[i, j];
            int max = A[0,0];
            int imax = 0;
            for (i = 1; i < A.GetLength(0); i++)
                if (A[i, i] > max)
                {
                    max = A[i, i];
                    imax = i;
                }
            textBox1.Text = A[imax, imax].ToString();
            for (i = 0; i < A.GetLength(1); i++)
                textBox2.Text += A[imax, i].ToString() + " ";

        }
    }
}
