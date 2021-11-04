using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hazifeladat
{
    public partial class Shop : Form
    {
        public int money;
        public int health;
        public int arm;
        public int lsz;
        int wave, wavetime;
        public Shop(int hp, int arm, int lsz, int cash,  int wv, int wvT)
        {
            health = hp;
            this.arm = arm;
            this.lsz = lsz;
            money = cash;
            wave = wv;
            wavetime = wvT;
            InitializeComponent();
            label1.Text = $"$: {money}";
            hpPbx.Image = Properties.Resources.medkit;
            armPbx.Image = Properties.Resources.armor;
            ammPbx.Image = Properties.Resources.ammo;
            if (money <= 40) ammBtn.Enabled = false;
            if (money <= 250) hpBtn.Enabled = false;
            if (money <= 500) armBtn.Enabled = false;
            if (money <= 195) ammlgBtn.Enabled = false;
        }

        private void hpBtn_Click(object sender, EventArgs e)
        {
            if (money >= 250)
            {
                health = 100;
                money -= 250;
                hpBtn.Enabled = false;
            }
            else hpBtn.Enabled = false;
            label1.Text = $"$: {money}";
        }

        private void armBtn_Click(object sender, EventArgs e)
        {
            if (money >= 500)
            {
                arm = 100;
                money -= 500;
                armBtn.Enabled = false;
            }
            else armBtn.Enabled = false;
            label1.Text = $"$: {money}";

        }

        private void ammBtn_Click(object sender, EventArgs e)
        {
            if (money >= 40)
            {
                lsz += 10;
                money -= 40;
            }
            else ammBtn.Enabled = false;
            label1.Text = $"$: {money}";

        }

        private void ammlgBtn_Click(object sender, EventArgs e)
        {
            if (money >= 195)
            {
                lsz += 50;
                money -= 195;
            }
            else ammlgBtn.Enabled = false;
            label1.Text = $"$: {money}";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Game game = new Game(health, arm, wave, wavetime, lsz, money);
            game.Show();
            game.Activate();
            Close();
        }
    }
}
