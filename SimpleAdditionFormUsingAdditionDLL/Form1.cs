using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GirubaSumDLL;

namespace SimpleAdditionFormUsingAdditionDLL
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {                
                Class1 girubaSumDLL = new Class1();
                int num1 = 0;
                try
                {
                    num1 = int.Parse(textBox1.Text);
                } catch (Exception ex) {
                    if (string.IsNullOrEmpty(textBox1.Text))
                    {
                        num1 = 0;
                    }
                    else {
                        MessageBox.Show(ex.Message);
                    }
                }
                int num2 = 0;

                try
                {
                    num2 = int.Parse(textBox2.Text);
                } catch (Exception ex) {
                    if (string.IsNullOrEmpty(textBox2.Text))
                    {
                        num2 = 0;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                int sum = girubaSumDLL.AddTwoNumbers(num1, num2);
                textBox5.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Class1 girubaSumDLL = new Class1();
                if (string.IsNullOrEmpty(textBox1.Text)) {
                    textBox1.Text = "0";
                }
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    textBox2.Text = "0";
                }
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    textBox3.Text = "0";
                }
                int sum = girubaSumDLL.AddThreeNumbers(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                textBox5.Text = sum.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Class1 girubaSumDLL = new Class1();
                if (string.IsNullOrEmpty(textBox4.Text))
                {
                    textBox4.Text = "0";
                }
                int sum = girubaSumDLL.AddNumbersInRange(int.Parse(textBox4.Text));
                textBox5.Text = sum.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
