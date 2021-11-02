using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace hazifeladat
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.heading;
            Spawner.Start();
            HitDetect.Start();
        }
        public bool elore, hatra, balra, jobbra;
        string irany="elore";
        int hp=100;
        int armor = 0;
        int penz = 0;
        int lsz = 50;
        Random random = new Random();
        Random zspeed = new Random();

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) balra = false;
            if (e.KeyCode == Keys.D) jobbra = false;
            if (e.KeyCode == Keys.W) elore = false;
            if (e.KeyCode == Keys.S) hatra = false;
        }

        private void Spawner_Tick(object sender, EventArgs e)
        {
            Zombi z = new Zombi();
            z.HaladasiIrany = "balrol";
            z.zombiViz = -100;
            z.zombiFugg = pictureBox1.Top;
            z.fast += zspeed.Next(1, 10);
            if (z.fast < 4) z.type = "Zombi_Slow";
            else if (z.fast > 4 && z.fast < 8) z.type = "Zombi_Medium";
            else z.type = "Zombi_Fast";
            z.Teremt(this);
        }

        private void HitDetect_Tick(object sender, EventArgs e)
        {
            HPLbl.Text = $"+: {hp}";
            ArmLbl.Text = $"Arm: {hp}";
            CashLbl.Text = $"$: {penz}";
            foreach (Control i in Controls)
            {
                foreach (Control j in Controls)
                {
                    if ((i is Panel && i.Name == "bull") && (j is PictureBox && j.Name.Contains("Zombi")))
                    {
                        if (i.Bounds.IntersectsWith(j.Bounds))
                        {
                            if (j.Name == "Zombi_Fast") penz += 40;
                            if (j.Name == "Zombi_Medium") penz += 20;
                            if (j.Name == "Zombi_Slow") penz += 10;
                            Controls.Remove(i);
                            Controls.Remove(j);
                            i.Dispose();
                            j.Dispose();
                        }
                    }
                }
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                balra = true;
                irany = "balra";
                pictureBox1.Image = Properties.Resources.headingL;
            }
            if (e.KeyCode==Keys.D)
            {
                jobbra = true;
                irany = "jobbra";
                pictureBox1.Image = Properties.Resources.headingR;
            }
            if (e.KeyCode==Keys.W)
            {
                elore = true;
                irany = "elore";
                pictureBox1.Image = Properties.Resources.heading;
            }
            if (e.KeyCode==Keys.S)
            {
                hatra = true;
                irany = "hatra";
                pictureBox1.Image = Properties.Resources.headingD;
            }
            if (e.KeyCode == Keys.Space) Lo(irany);
        }
        private void Lo(string ir)
        {
            if (lsz > 0)
            {
                Bull b = new Bull();
                b.iranya = ir;
                b.bullViz = pictureBox1.Left + (pictureBox1.Width / 2);
                b.bullFugg = pictureBox1.Top + (pictureBox1.Height / 2);
                b.bullSpawn(this);
                lsz--;
            }
        }
    }
}
