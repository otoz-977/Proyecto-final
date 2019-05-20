using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.control;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int C = 0;
        int S = 0;
        bool special;  
        public Form1()
        {
            InitializeComponent();
        }
        private void Cont_Click(object sender, EventArgs e)
        {        
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                if(textBox1.Text == "*")
                {
                    S = 0;
                   
                }
                else 
                {
                    S = Int32.Parse(textBox1.Text);
                }   
            }
            Master ms = new Master();
            Diag.Text = ms.Scenery(C,S);
            C++;
            string res = Diag.Text;
            if(Diag.Text == "...")
            {
                S++;
                C = 0;
            }
            special = ms.GS;
            if (special == true)
            {
                Questions.Visible = true;
                Diag.Text = ms.Quest();
            }
            else
            {
                Questions.Visible = false;
            }
           
          
    }
    }
}
