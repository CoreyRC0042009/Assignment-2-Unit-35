using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces_Room_F6
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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Read from textboxes
                double Length = double.Parse(textBox1.Text);
                double Width = double.Parse(textBox2.Text);
                double Height = double.Parse(textBox3.Text);
                //Finds Volume 
                double Volume = Length * Width * Height;

                //Adds answer to lable
                label1.Text = "Volume =" + Volume;
             
            }

            //Using catch to output an error message
            catch
            {
                MessageBox.Show("Error not a number.");
            }

        }

    }
}
