using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstadistico
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            /* This function adds the new number in the TextField to the main group of numbers */

            // It adds a separator only if it is not the first number
            if(txtOriginalValues.Text != "")
            {
                txtOriginalValues.Text += " - ";
            }
            
            // Adds the number to the main set
            txtOriginalValues.Text += txtAddNumber.Text;

            // Clear the input TextField of new number
            txtAddNumber.Text = "";
        }
    }
}
