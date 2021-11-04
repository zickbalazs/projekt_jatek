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
