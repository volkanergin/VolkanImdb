using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5573_VolkanIMDB_Project
{
    public partial class RecoverPassword : Form
    {
        public RecoverPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recovery e-mail has been sent to your e-mail address. Please follow the instructions in the -e-mail to recover your password.");
        }
    }
}
