using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace hazifeladat
{
    class Bull
    {
        public string iranya;
        public int fast = 10;
        Panel bull = new Panel();
        Timer t = new Timer();
        public int bullViz;
        public int bullFugg;
        public void bullSpawn(Form form)
        {
            bull.BackColor = Color.Black;
            bull.Size = new Size(10, 10);
            bull.Name = "bull";
            bull.Left = bullViz;
            bull.Top = bullFugg;
            bull.BringToFront();
            form.Controls.Add(bull);
            t.Interval = fast;
            t.Tick += megy;
            t.Start();
        }
        public void megy(object sender, EventArgs e)
        {
            switch (iranya)
            {
                case "elore":
                    bull.Top -= fast;
                    break;
                case "hatra":
                    bull.Top += fast;
                    break;
                case "jobbra":
                    bull.Left += fast;
                    break;
                case "balra":
                    bull.Left -= fast;
                    break;
            }
            if (bull.Top > 580 || bull.Top < 20 || bull.Left < 20 || bull.Left > 780)
            {
                t.Stop();
                bull.Dispose();
                t.Dispose();
                t = null;
                bull = null;
            }
        }
    }
}
