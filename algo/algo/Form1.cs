using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algo
{
    
    public partial class Form1 : Form
    {
        public static int[] numberArray = new int[10];//Array for integers
        public static int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(textBox1.Text);
                addNumber(temp);
            }
            catch (Exception h)
            {
                MessageBox.Show("Please provide number only");
            }
        }
        private void addNumber(int number)
        {
            int sum = 0;
            if(index >= 10)
            {
                for (int i = 0; i < numberArray.Length; i++)
                {
                    sum += numberArray[i];
                }
                MessageBox.Show("The sum of all array elements are: " + sum.ToString());
            }
            else
            {
                numberArray[index++] = number;
                MessageBox.Show("Number " + number.ToString() + " is added to array at " + index.ToString() + " place." );
            }
        }
        private void resetArray()
        {
            index = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetArray();
            MessageBox.Show("The number array has been reset.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drawTree();
        }
        private void drawTree()
        {
            try
            {
                int tree = Convert.ToInt32(richTextBox1.Text);
                richTextBox1.Clear();
                int NumOfLines = tree;
                for (int i = 0; i < NumOfLines; i++)
                {
                    for (int j = 0; j < NumOfLines - i; j++)
                    {
                        richTextBox1.Text += " ";
                    }
                    for (int k = 0; k <= i; k++)
                    {
                        richTextBox1.Text += "* ";
                    }
                    richTextBox1.Text += Environment.NewLine;
                }
            }
            catch (Exception h)
            {
                MessageBox.Show("Please provide number only");
            }
        }
    }
}
