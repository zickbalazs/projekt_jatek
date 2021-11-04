
namespace hazifeladat
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wave = new System.Windows.Forms.Timer(this.components);
            this.Spawner = new System.Windows.Forms.Timer(this.components);
            this.HitDetect = new System.Windows.Forms.Timer(this.components);
            this.CashLbl = new System.Windows.Forms.Label();
            this.HPLbl = new System.Windows.Forms.Label();
            this.ArmLbl = new System.Windows.Forms.Label();
            this.WaveTimer = new System.Windows.Forms.Timer(this.components);
            this.waveLbl = new System.Windows.Forms.Label();
            this.waveTimeLbl = new System.Windows.Forms.Label();
            this.ammoLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(345, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Spawner
            // 
            this.Spawner.Interval = 1000;
            this.Spawner.Tick += new System.EventHandler(this.Spawner_Tick);
            // 
            // HitDetect
            // 
            this.HitDetect.Interval = 20;
            this.HitDetect.Tick += new System.EventHandler(this.HitDetect_Tick);
            // 
            // CashLbl
            // 
            this.CashLbl.AutoSize = true;
            this.CashLbl.BackColor = System.Drawing.Color.White;
            this.CashLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CashLbl.ForeColor = System.Drawing.Color.Green;
            this.CashLbl.Location = new System.Drawing.Point(12, 78);
            this.CashLbl.Name = "CashLbl";
            this.CashLbl.Size = new System.Drawing.Size(24, 16);
            this.CashLbl.TabIndex = 2;
            this.CashLbl.Text = "$: ";
            // 
            // HPLbl
            // 
            this.HPLbl.AutoSize = true;
            this.HPLbl.BackColor = System.Drawing.Color.White;
            this.HPLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HPLbl.ForeColor = System.Drawing.Color.Red;
            this.HPLbl.Location = new System.Drawing.Point(10, 9);
            this.HPLbl.Name = "HPLbl";
            this.HPLbl.Size = new System.Drawing.Size(39, 25);
            this.HPLbl.TabIndex = 3;
            this.HPLbl.Text = "+: ";
            // 
            // ArmLbl
            // 
            this.ArmLbl.AutoSize = true;
            this.ArmLbl.BackColor = System.Drawing.Color.White;
            this.ArmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArmLbl.ForeColor = System.Drawing.Color.Navy;
            this.ArmLbl.Location = new System.Drawing.Point(11, 46);
            this.ArmLbl.Name = "ArmLbl";
            this.ArmLbl.Size = new System.Drawing.Size(51, 20);
            this.ArmLbl.TabIndex = 4;
            this.ArmLbl.Text = "Arm: ";
            // 
            // WaveTimer
            // 
            this.WaveTimer.Interval = 1000;
            this.WaveTimer.Tick += new System.EventHandler(this.WaveTimer_Tick);
            // 
            // waveLbl
            // 
            this.waveLbl.AutoSize = true;
            this.waveLbl.BackColor = System.Drawing.Color.FloralWhite;
            this.waveLbl.Location = new System.Drawing.Point(716, 9);
            this.waveLbl.Name = "waveLbl";
            this.waveLbl.Size = new System.Drawing.Size(45, 13);
            this.waveLbl.TabIndex = 5;
            this.waveLbl.Text = "Hullám: ";
            // 
            // waveTimeLbl
            // 
            this.waveTimeLbl.AutoSize = true;
            this.waveTimeLbl.BackColor = System.Drawing.Color.White;
            this.waveTimeLbl.Location = new System.Drawing.Point(716, 33);
            this.waveTimeLbl.Name = "waveTimeLbl";
            this.waveTimeLbl.Size = new System.Drawing.Size(0, 13);
            this.waveTimeLbl.TabIndex = 6;
            // 
            // ammoLbl
            // 
            this.ammoLbl.AutoSize = true;
            this.ammoLbl.BackColor = System.Drawing.Color.White;
            this.ammoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ammoLbl.ForeColor = System.Drawing.Color.Green;
            this.ammoLbl.Location = new System.Drawing.Point(12, 107);
            this.ammoLbl.Name = "ammoLbl";
            this.ammoLbl.Size = new System.Drawing.Size(26, 16);
            this.ammoLbl.TabIndex = 7;
            this.ammoLbl.Text = "A: ";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ammoLbl);
            this.Controls.Add(this.waveTimeLbl);
            this.Controls.Add(this.waveLbl);
            this.Controls.Add(this.ArmLbl);
            this.Controls.Add(this.HPLbl);
            this.Controls.Add(this.CashLbl);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Wave;
        private System.Windows.Forms.Timer Spawner;
        private System.Windows.Forms.Timer HitDetect;
        private System.Windows.Forms.Label CashLbl;
        private System.Windows.Forms.Label HPLbl;
        private System.Windows.Forms.Label ArmLbl;
        private System.Windows.Forms.Timer WaveTimer;
        private System.Windows.Forms.Label waveLbl;
        private System.Windows.Forms.Label waveTimeLbl;
        private System.Windows.Forms.Label ammoLbl;
    }
}