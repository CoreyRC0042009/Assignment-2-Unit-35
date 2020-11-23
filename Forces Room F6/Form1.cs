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
                // Read from textboxes, finds volume of the cuboid
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

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Reads whats in the textboxes finds volume of the sphere
                double Radius = double.Parse(textBox4.Text);
                double Volume = 4 * Radius * Radius * Radius * 3.14159 / 3;
                label7.Text = "Volume =" + Volume;
            }
            //using try catch in case there are any letters or words being typed
            catch
            {
                MessageBox.Show("Error not a number.");
            }
          
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                //This button works out surface area for the cuboid
                double Length = double.Parse(textBox1.Text);
                double Width = double.Parse(textBox2.Text);
                double Height = double.Parse(textBox3.Text);
                //Finds Surface Area
                double SurfaceArea = 2.0 * (Length * Height + Length * Width + Width * Height);

                //Adds answer to lable
                label5.Text = "SurfaceArea =" + SurfaceArea;

            }
            //Using try catch to output an error message if words/ letters are typed in 
            catch
            {
                MessageBox.Show("Error not a number");
            }
        }


       

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                //Reads whats in the textboxes
                //This code works out the Surface Area when a number is typed in the radius textbox 
                double Radius = double.Parse(textBox4.Text);
                double SurfaceArea = 4 * 3.1415 * Radius * Radius;
                label8.Text = ("SurfaceArea =") + SurfaceArea;
            }
            catch
            {
                //ensures no words/ letters are typed into the textboxs, will display an error message if there is
                MessageBox.Show("Error not a number");
            }
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                //Finds the volume of the cone when values are typed into the radius and height textbox
                double Radius = double.Parse(textBox5.Text);
                double Height = double.Parse(textBox6.Text);
                double Volume = 1 * 3.14159 * Radius * Radius * Height / 3;
                label11.Text = ("Volume =") + Volume;
            }
            catch
            {
                // this ensures that letters/ words arent typed in the textboxes and will display an eroor message if there is
                MessageBox.Show("Error not a number");
            }
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                //finds the surface area of the cone when values are typed into the radius and height textbox
                double Radius = double.Parse(textBox5.Text);
                double Height = double.Parse(textBox6.Text);
                double SurfaceArea = 3.14159 * Radius * (Radius * Math.Sqrt(Radius * Radius * Height * Height));
            }
            catch
            {
                //This try catch method is in place to ensure words/ letters arent typed in the textboxes
                MessageBox.Show("Error not a number");
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            //this is the image of the sphere
        }
    }
}
