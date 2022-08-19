using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox5.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(textBox4.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox6.Items.Add(comboBox2.Text);
            listBox7.Items.Add(comboBox3.Text);
            listBox8.Items.Add(label10.Text + "," + label11.Text + "," + label12.Text + "," + label13.Text + "," + label14.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = checkBox1.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = checkBox2.Text;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = checkBox3.Text;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = checkBox4.Text;

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label14.Text = checkBox5.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox5.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox2.Text = " ";
            comboBox1.Text = " ";
            comboBox3.Text = " ";
            label10.Text = " ";
            label11.Text = " ";
            label12.Text = " ";
            label13.Text = " ";
            label14.Text = " ";

        }
    }
}
