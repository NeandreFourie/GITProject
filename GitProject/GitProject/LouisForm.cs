using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitProject
{
    public partial class LouisForm : Form
    {
        GenerateNumber GTEngine = new GenerateNumber();
        Test tn = new Test();
       int[] RandomNR;

        public LouisForm()
        {
            InitializeComponent();
        }

        private void LouisForm_Load(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Loading Info.....\n");
            richTextBox1.AppendText("First Name: Louis Hosia\n");
            richTextBox1.AppendText("Surname: Jordaan\n");
            richTextBox1.AppendText("Student Number: 24916773\n");
            richTextBox1.AppendText("Info\n");
            richTextBox1.AppendText(".................\n");
            richTextBox1.AppendText("Info Follows\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            RandomNR = new int[n];
            for(int i=0;i<=n-1;i++)
            {
                RandomNR[i] =GTEngine.Generate();
                richTextBox1.AppendText(RandomNR[i] + ", ");
            }
            richTextBox1.AppendText("\n");
            if(tn.Testn(n)== true)
            {
                MessageBox.Show(Convert.ToString("The Standard Deviation is:" + GTEngine.CalculateSD(RandomNR)));
            }
            else
                {
                MessageBox.Show("Number not between 5 or 20");
                }
         
        }

    }
}
