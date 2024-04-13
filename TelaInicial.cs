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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
