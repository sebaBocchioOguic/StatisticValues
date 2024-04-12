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


        /// <summary>
        /// This function adds the new number in the TextField to the main group of numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            // It adds a separator only if it is not the first number
            if(txtOriginalValues.Text != "")
            {
                txtOriginalValues.Text += " - ";
            }
            
            // Adds the number to the main set
            txtOriginalValues.Text += txtAddNumber.Text;

            // Clear the input TextField of new number
            txtAddNumber.Text = "";
            
            // Set the input focus again in the AddNumber TextField, to continue the numbers input
            txtAddNumber.Focus();
        }

        /// <summary>
        /// This clears the TextFields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddNumber.Text = "";
            txtOriginalValues.Text = "";
        }
    }
}
