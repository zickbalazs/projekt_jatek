using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace hazifeladat
{
    public partial class Game : Form
    {
        public bool elore, hatra, balra, jobbra;
        string irany = "elore";
        public int hp;
        public int armor;
        int wave, wavetime;
        public int penz = 0;
        public int lsz = 50; 
        public Game(int health, int a, int wv, int wvT, int ammo, int p)
        {
            InitializeComponent();
            BackColor = Color.FromArgb(0, 161, 5);
            wave = wv;
            hp = health;
            armor = a;
            wave = wv;
            wavetime = wvT;
            penz = p;
            lsz = ammo;
            pictureBox1.Image = Properties.Resources.turretU;
            Spawner.Start();
            HitDetect.Start();
            WaveTimer.Start();
            waveLbl.Text = $"Hullám: {wave}";
        }
        Random random = new Random();
        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) balra = false;
            if (e.KeyCode == Keys.D) jobbra = false;
            if (e.KeyCode == Keys.W) elore = false;
            if (e.KeyCode == Keys.S) hatra = false;
        }

        private void Spawner_Tick(object sender, EventArgs e)
        {
            if (wave < 3)
            {
                Zombi z = new Zombi();
                z.fast = random.Next(1, 10);
                if (z.fast < 4) z.type = "Zombi_Slow";
                else if (z.fast > 4 && z.fast < 8) z.type = "Zombi_Medium";
                else z.type = "Zombi_Fast";
                switch (random.Next(1, 5))
                {
                    case 1:
                        z.HaladasiIrany = "balrol";
                        z.zombiViz = -100;
                        z.zombiFugg = pictureBox1.Location.Y;
                        break;
                    case 2:
                        z.HaladasiIrany = "jobbrol";
                        z.zombiViz = 900;
                        z.zombiFugg = pictureBox1.Location.Y;
                        break;
                    case 3:
                        z.HaladasiIrany = "fent";
                        z.zombiFugg = -100;
                        z.zombiViz = pictureBox1.Location.X;
                        break;
                    case 4:
                        z.HaladasiIrany = "lent";
                        z.zombiFugg = 900;
                        z.zombiViz = pictureBox1.Location.X;
                        break;
                }
                z.Teremt(this);
                Spawner.Interval = random.Next(2000, 8001);
            }
            else if (wave > 3 && wave < 10)
            {
                for (int i = 1; i < 3; i++)
                {
                    Zombi z = new Zombi();
                    z.fast = random.Next(10, 16);
                    if (z.fast < 4) z.type = "Zombi_Slow";
                    else if (z.fast > 4 && z.fast < 8) z.type = "Zombi_Medium";
                    else z.type = "Zombi_Fast";
                    switch (random.Next(1, 5))
                    {
                        case 1:
                            z.HaladasiIrany = "balrol";
                            z.zombiViz = -100;
                            z.zombiFugg = pictureBox1.Location.Y;
                            break;
                        case 2:
                            z.HaladasiIrany = "jobbrol";
                            z.zombiViz = 900;
                            z.zombiFugg = pictureBox1.Location.Y;
                            break;
                        case 3:
                            z.HaladasiIrany = "lent";
                            z.zombiFugg = 900;
                            z.zombiViz = pictureBox1.Location.X;
                            break;
                        case 4:
                            z.HaladasiIrany = "fent";
                            z.zombiFugg = -100;
                            z.zombiViz = pictureBox1.Location.X;
                            break;
                    }
                    z.Teremt(this);
                    Spawner.Interval = random.Next(2000, 4001);
                }
            }
            else
            {
                for (int i = 1; i < 4; i++)
                {
                    Zombi z = new Zombi();
                    z.fast = random.Next(10, 16);
                    if (z.fast < 4) z.type = "Zombi_Slow";
                    else if (z.fast > 4 && z.fast < 8) z.type = "Zombi_Medium";
                    else z.type = "Zombi_Fast";
                    switch (random.Next(1, 5))
                    {
                        case 1:
                            z.HaladasiIrany = "balrol";
                            z.zombiViz = -100;
                            z.zombiFugg = pictureBox1.Location.Y;
                            break;
                        case 2:
                            z.HaladasiIrany = "jobbrol";
                            z.zombiViz = 900;
                            z.zombiFugg = pictureBox1.Location.Y;
                            break;
                        case 3:
                            z.HaladasiIrany = "lent";
                            z.zombiFugg = -100;
                            z.zombiViz = pictureBox1.Location.X;
                            break;
                        case 4:
                            z.HaladasiIrany = "fent";
                            z.zombiFugg = 900;
                            z.zombiViz = pictureBox1.Location.X;
                            break;
                    }
                    z.Teremt(this);
                }
                Spawner.Interval = random.Next(1000, 4001);
            }
        }
        private void WaveTimer_Tick(object sender, EventArgs e)
        {
            if (wavetime == 0)
            {
                wave++;
                Shop shop = new Shop(hp, armor, lsz, penz, wave, ((wave * 60) / 2));
                shop.money = penz;
                shop.health = hp;
                shop.arm = armor;
                shop.Activate();
                shop.Show();
                Close();
            }
            else
            {
                waveTimeLbl.Text = $"{wavetime}s";
                wavetime--;
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void HitDetect_Tick(object sender, EventArgs e)
        {
            HPLbl.Text = $"+: {hp}";
            ArmLbl.Text = $"Arm: {hp}";
            CashLbl.Text = $"$: {penz}";
            ammoLbl.Text = $"iii: {lsz}";
            if (hp<=0)
            {
                WaveTimer.Stop();
                HitDetect.Stop();
                MessageBox.Show("A játéknak vége!");
                Application.Exit();
            }
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
                    if ((i is PictureBox && i.Name=="pictureBox1") && (j is PictureBox && j.Name.Contains("Zombi")))
                    {
                        if (i.Bounds.IntersectsWith(j.Bounds))
                        {
                            int damage = random.Next(1, 16);
                            if (armor > (damage / 2) + 1)
                            {
                                hp -= damage / 2;
                                armor -= damage / 2;
                            }
                            else hp -= damage;
                            Controls.Remove(j);
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
                pictureBox1.Image = Properties.Resources.turretL;
            }
            if (e.KeyCode==Keys.D)
            {
                jobbra = true;
                irany = "jobbra";
                pictureBox1.Image = Properties.Resources.turretR;
            }
            if (e.KeyCode==Keys.W)
            {
                elore = true;
                irany = "elore";
                pictureBox1.Image = Properties.Resources.turretU;
            }
            if (e.KeyCode==Keys.S)
            {
                hatra = true;
                irany = "hatra";
                pictureBox1.Image = Properties.Resources.turretD;
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
            ammoLbl.Text = $"A: {lsz}";
        }
    }
}
