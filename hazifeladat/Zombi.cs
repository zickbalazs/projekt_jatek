using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace hazifeladat
{
    class Zombi
    {
        public string HaladasiIrany;
        public int fast = 2;
        PictureBox zomb = new PictureBox();
        Timer t = new Timer();
        public int zombiFugg, zombiViz;
        public string type;
        public void Teremt(Form form)
        {
            zomb.SizeMode = PictureBoxSizeMode.StretchImage;
            zomb.BackColor = Color.Transparent;
            zomb.Name = type;
            zomb.Size = new Size(100, 100);
            zomb.Left = zombiViz;
            zomb.Top = zombiFugg;
            if (HaladasiIrany == "fent")
            {
                zomb.Image = Properties.Resources.zombD;
            }
            else if (HaladasiIrany == "lent")
            {
                zomb.Image = Properties.Resources.zombU;
            }
            else if (HaladasiIrany == "balrol")
            {
                zomb.Image = Properties.Resources.zombR;
            }
            else if (HaladasiIrany == "jobbrol")
            {
                zomb.Image = Properties.Resources.zombL;
            }
            form.Controls.Add(zomb);
            t.Interval = 100;
            t.Tick += tick;
            t.Start();
            
        }
        public void tick(object sender, EventArgs e)
        {
            switch (HaladasiIrany)
            {
                case "fent":
                    zomb.Top += fast;
                    break;
                case "lent":
                    zomb.Top -= fast;
                    break;
                case "balrol":
                    zomb.Left += fast;
                    break;
                case "jobbrol":
                    zomb.Left -= fast;
                    break;
            }
        }
    }
}
