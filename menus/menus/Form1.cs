using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menus
{
    public partial class mMenuPrincipal : Form
    {
        public mMenuPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void mArchivoImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("imprimiendo");
        }

        private void mArchivoSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
