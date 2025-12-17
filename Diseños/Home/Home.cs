using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void lbl_logout_Click(object sender, EventArgs e)
        {
            lbl_logout.Cursor = Cursors.Hand;
            DialogResult result = MessageBox.Show("¿Deseas Cerrar Sesion?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
              this.Close();
            }
                
        }

    }
}
