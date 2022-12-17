using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billOfMaterialsV2
{
    public partial class Products : MetroFramework.Forms.MetroForm
    {
        public Products()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            new home().Show();
        }
    }
}
