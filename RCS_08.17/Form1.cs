using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCS_08._17
{
    public partial class Form1 : Form
    {
        int clickCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (tBoxName.Text != "")
            {
                lblCongrats.Text = "Hello, " + tBoxName.Text;
                clickCounter++;
                lblClicks.Text = "Number of clicks : " + clickCounter.ToString();
                tBoxName.Text = "";
                tBoxName.Focus();
            }
        }
    }
}
