using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GopiVengasesanPROJECT
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Hook up button click event to function
            button1.Click += new EventHandler(button1_Click);
        }

        // Event handler for button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the input from the TextBox and display it in the Label
            string userInput = textBox1.Text;
            label1.Text = "You entered: " + userInput;
        }
    }
}

