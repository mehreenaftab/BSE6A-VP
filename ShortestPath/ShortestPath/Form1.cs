using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortestPath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics drawcircle;
        
        GraphicsPath p = new GraphicsPath();
        private void Form1_Load(object sender, EventArgs e)
        {
            string lab_text = "Enter No of Nodes";
            label1.Text = lab_text;                 //Assigning  Text to the label using its Text property through code
            string btn_text = "Generate Nodes";
            button1.Text = btn_text;               //Assigning  Text to the button using its Text proerty through code
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //string text = "Enter Number of Nodes";
            //label1.Text = text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          //  if(textBox1.Text ==)
        }

        private void Textbox_Leave(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(textBox1.Text);
            if (input > 10)
            {
                MessageBox.Show("You can not enter more than 10 nodes");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int input = Convert.ToInt32(textBox1.Text);
            if (input > 10)
            {
                MessageBox.Show("You can not enter more than 10 nodes");
            }
            else
            {
                for(int i = 1 ; i <= input ; i++)
                {
                    Button butn = new Button();
                    butn.width = 50;
                    butn.BackColor                 
                
                }
            
            }

            
            
            //Brush brush = new Brush();
            //drawcircle.FillEllipse(brush,10,20,30,40);

            //Graphics graphics = e.Graphics;
           // Graphics drawcircle = new Graphics();
            Pen myPen = new Pen(Color.Black);
            // Draw the button in the form of a circle
            //for()
            button2.Width = 45;
            button2.Height = 45;
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(4, 4, button2.Width - 8, button2.Height - 8);
            button1.Region = new Region(p);
           // drawcircle.DrawEllipse(myPen, 0, 0, 100, 100);
           // myPen.Dispose();
         
        }

    }
}
