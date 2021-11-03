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
        public bool opened = true;
        public Shop()
        {
            InitializeComponent();
        }
        //vásárlási funkciókat megcsinálni!
        private void button9_Click(object sender, EventArgs e)
        {
            opened = false;
            Close();
        }
    }
}
