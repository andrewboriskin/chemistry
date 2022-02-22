using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    class Other
    {
        public bool exit()
        {
            DialogResult result;
            result = MessageBox.Show("Закрыть программу?", "Закрытие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
 

    
