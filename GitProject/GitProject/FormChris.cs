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
    public partial class FormChris : Form
    {
        public FormChris()
        {
            InitializeComponent();
        }

        private void btnGenRandNumbers_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateClass numObj = new GenerateClass(Convert.ToInt16(textBox1.Text), this);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

        public void showStat(double stat)
        {
            MessageBox.Show("The minimum of the random numbers is: " + stat);
        }
    }
}
