using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        private SoundPlayer _soundPlayer;
        public Form2()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("BrBa.wav");
            _soundPlayer.Play();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Visible = false;
            _soundPlayer.Stop();
        }

private void Form2_FormClosing(object sender, FormClosingEventArgs e) 
{ 
Other closed = new Other(); 
if (closed.exit() == false) 
e.Cancel = true; 
}

private void label2_Click(object sender, EventArgs e)
{

}
       

        }
    }


