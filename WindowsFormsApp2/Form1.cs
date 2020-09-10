using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private string i;
        private string j;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i = textBox1.Text;
            j = textBox2.Text;

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                i = textBox1.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 1)
            {
                i = textBox2.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 2)
            {
                i = textBox3.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 3)
            {
                i = textBox4.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 4)
            {
                i = textBox5.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 5)
            {
                i = textBox6.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 6)
            {
                i = textBox7.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 7)
            {
                i = textBox8.Text.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = "";
            j = "";

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                MessageBox.Show("Register error. Choose diffrent registers.");
            }

            if (comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = i;
            }

            if (comboBox2.SelectedIndex == 1)
            {
                textBox2.Text = i;
            }

            if (comboBox2.SelectedIndex == 2)
            {
                textBox3.Text = i;
            }

            if (comboBox2.SelectedIndex == 3)
            {
                textBox4.Text = i;
            }

            if (comboBox2.SelectedIndex == 4)
            {
                textBox5.Text = i;
            }

            if (comboBox2.SelectedIndex == 5)
            {
                textBox6.Text = i;
            }

            if (comboBox2.SelectedIndex == 6)
            {
                textBox7.Text = i;
            }

            if (comboBox2.SelectedIndex == 7)
            {
                textBox8.Text = i;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                j = textBox1.Text.ToString();
            }

            if (comboBox2.SelectedIndex == 1)
            {
                j = textBox2.Text.ToString();
            }

            if (comboBox2.SelectedIndex == 2)
            {
                j = textBox3.Text.ToString();
            }

            if (comboBox2.SelectedIndex == 3)
            {
                j = textBox4.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 4)
            {
                j = textBox5.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 5)
            {
                j = textBox6.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 6)
            {
                j = textBox7.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 7)
            {
                j = textBox8.Text.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
