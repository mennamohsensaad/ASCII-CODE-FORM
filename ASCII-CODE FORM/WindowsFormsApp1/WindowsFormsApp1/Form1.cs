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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char x;
            for (int i = 0; i <= 255; i++)
            {
                x = (char)i;
                listBox1.Items.Add(i + "=" + x);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            int x = e.KeyChar;
            textBox2.Text = x.ToString();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string y1 = textBox3.Text;
                char c1 = y1[0];
                int i1 = (int)c1;
                string y2 = textBox4.Text;
                char c2 = y2[0];
                int i2 = (int)c2;




                int result = i1 + i2;

                MessageBox.Show("Add result =" + result.ToString());
            }
            catch (Exception ex)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string y1 = textBox3.Text;
                char c1 = y1[0];
                int i1 = (int)c1;
                string y2 = textBox4.Text;
                char c2 = y2[0];
                int i2 = (int)c2;

                int result = i1 *i2;

                MessageBox.Show("Multiplication result =" + result.ToString());
            }
            catch (Exception ex)
            {
            }
        }
private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                string y1 = textBox3.Text;
                char c1 = y1[0];
                int i1 = (int)c1;
                string y2 = textBox4.Text;
                char c2 = y2[0];
                int i2 = (int)c2;

                int result = i1 - i2;

                MessageBox.Show("Substraction result =" + result.ToString());
            }
            catch (Exception ex)
            {
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                string y1 = textBox3.Text;
                char c1 = y1[0];
                double i1 = (int)c1;
                string y2 = textBox4.Text;
                char c2 = y2[0];
               double i2 = (int)c2;

              double result = i1 / i2;

                MessageBox.Show("Division result =" + result.ToString());
            }
            catch (Exception ex)
            {
            }
        }
    

}
   
}