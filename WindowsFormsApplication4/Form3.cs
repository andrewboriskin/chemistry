using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string l = textBox1.Text;
            Metal mainclass = new Metal();
            textBox2.Text = mainclass.element(l);
        }

      private void Form3_FormClosing(object sender, FormClosingEventArgs e) 
{ 
Other closed = new Other(); 
if (closed.exit() == false) 
e.Cancel = true; 
}

     

       



        }
    }

