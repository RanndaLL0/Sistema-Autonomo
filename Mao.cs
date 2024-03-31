using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPI
{
    public partial class Mao : Form
    {
        public Mao()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {      
           this.Close();
        }
    }
}
