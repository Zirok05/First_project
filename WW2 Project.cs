using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (radioButton3.Checked) k++;
            if (radioButton5.Checked) k++;
            string a = (textBox1.Text);
            if (a == "Странная") k++;
            if (radioButton8.Checked) k++;
            string b = (textBox2.Text);
            if (b == "Шарль") k++;
            string c = (textBox3.Text);
            if (c == "Вон") k++;
            if (radioButton12.Checked) k++;
            string d = (textBox4.Text);
            if (d == "Барбаросса") k++;
            if (radioButton13.Checked) k++;
            if (radioButton18.Checked) k++;
            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true) k++;
            if (radioButton21.Checked) k++;
            string f = (textBox5.Text);
            if (f == "Квантунская") k++;
            string g = (textBox6.Text);
            if (g == "Китая") k++;
            string m = (textBox7.Text);
            if (m == "1945") k++;
            string n = (textBox8.Text);
            if (n == "Франклин") k++;
            if (radioButton23.Checked) k++;
            if (radioButton27.Checked) k++;
            string y = (textBox9.Text);
            if (y == "Индустриализация") k++;
            if (radioButton29.Checked) k++;
            if (k <= 10) MessageBox.Show("Ужасно");
            if (k > 10 && k < 20) MessageBox.Show("Неплохо");
            if (k == 20) MessageBox.Show("Отлично");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
