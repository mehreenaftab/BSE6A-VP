using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Location = new Point(30, 40);
            btn.Width = 100;
            btn.Height = 20;
            btn.Text = "btn make";
            this.Controls.Add(btn);
            btn.Visible = true;




        }
    }
}
