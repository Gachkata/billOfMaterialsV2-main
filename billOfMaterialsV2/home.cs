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
    public partial class home : MetroFramework.Forms.MetroForm
        
    {
        //private Rectangle titleOriginalRectangle;
        //private Rectangle titleOriginalRectangle2;
        //private Rectangle titleOriginalRectangle3;
        //private Rectangle originalFormSize;
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            //originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            //titleOriginalRectangle = new Rectangle(metroTile1.Location.X, metroTile1.Location.Y, metroTile1.Width, metroTile1.Height);
            //titleOriginalRectangle2 = new Rectangle(metroTile2.Location.X, metroTile2.Location.Y, metroTile2.Width, metroTile2.Height);
            //titleOriginalRectangle3 = new Rectangle(metroTile3.Location.X, metroTile3.Location.Y, metroTile3.Width, metroTile3.Height);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            new Products().Show();
            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            new Materials().Show();
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            new Expenses().Show();
        }
        /*private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }*/
    }
}
