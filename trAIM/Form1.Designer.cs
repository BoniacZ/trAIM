
using System;

namespace trAIM
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnPrzerwij = new System.Windows.Forms.Button();
            this.panelStaty = new System.Windows.Forms.Panel();
            this.btnStaty2 = new System.Windows.Forms.Button();
            this.btnStaty1 = new System.Windows.Forms.Button();
            this.btnStaty = new System.Windows.Forms.Button();
            this.panelTryby = new System.Windows.Forms.Panel();
            this.btnTryb3 = new System.Windows.Forms.Button();
            this.btnTryb2 = new System.Windows.Forms.Button();
            this.btnTryb1 = new System.Windows.Forms.Button();
            this.btnTryby = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panelGameInfo = new System.Windows.Forms.Panel();
            this.lblTrafienia = new System.Windows.Forms.Label();
            this.lblCzas = new System.Windows.Forms.Label();
            this.lblCelnosc = new System.Windows.Forms.Label();
            this.lblPunkty = new System.Windows.Forms.Label();
            this.lblLicznikObiektow = new System.Windows.Forms.Label();
            this.panelGame = new System.Windows.Forms.Panel();
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelStaty.SuspendLayout();
            this.panelTryby.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelGameInfo.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.panelSideMenu.Controls.Add(this.btnPrzerwij);
            this.panelSideMenu.Controls.Add(this.panelStaty);
            this.panelSideMenu.Controls.Add(this.btnStaty);
            this.panelSideMenu.Controls.Add(this.panelTryby);
            this.panelSideMenu.Controls.Add(this.btnTryby);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(220, 673);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnPrzerwij
            // 
            this.btnPrzerwij.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrzerwij.FlatAppearance.BorderSize = 0;
            this.btnPrzerwij.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.btnPrzerwij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrzerwij.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzerwij.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrzerwij.Location = new System.Drawing.Point(0, 419);
            this.btnPrzerwij.Name = "btnPrzerwij";
            this.btnPrzerwij.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrzerwij.Size = new System.Drawing.Size(220, 45);
            this.btnPrzerwij.TabIndex = 5;
            this.btnPrzerwij.Text = "Przerwij grę";
            this.btnPrzerwij.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrzerwij.UseVisualStyleBackColor = true;
            this.btnPrzerwij.Click += new System.EventHandler(this.btnPrzerwij_Click);
            // 
            // panelStaty
            // 
            this.panelStaty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(91)))), ((int)(((byte)(191)))));
            this.panelStaty.Controls.Add(this.btnStaty2);
            this.panelStaty.Controls.Add(this.btnStaty1);
            this.panelStaty.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStaty.Location = new System.Drawing.Point(0, 327);
            this.panelStaty.Name = "panelStaty";
            this.panelStaty.Size = new System.Drawing.Size(220, 92);
            this.panelStaty.TabIndex = 4;
            // 
            // btnStaty2
            // 
            this.btnStaty2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaty2.FlatAppearance.BorderSize = 0;
            this.btnStaty2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(97)))));
            this.btnStaty2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaty2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStaty2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStaty2.Location = new System.Drawing.Point(0, 45);
            this.btnStaty2.Name = "btnStaty2";
            this.btnStaty2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStaty2.Size = new System.Drawing.Size(220, 45);
            this.btnStaty2.TabIndex = 1;
            this.btnStaty2.Text = "Zresetuj";
            this.btnStaty2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaty2.UseVisualStyleBackColor = true;
            this.btnStaty2.Click += new System.EventHandler(this.btnStaty2_Click);
            // 
            // btnStaty1
            // 
            this.btnStaty1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaty1.FlatAppearance.BorderSize = 0;
            this.btnStaty1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(97)))));
            this.btnStaty1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaty1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStaty1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStaty1.Location = new System.Drawing.Point(0, 0);
            this.btnStaty1.Name = "btnStaty1";
            this.btnStaty1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStaty1.Size = new System.Drawing.Size(220, 45);
            this.btnStaty1.TabIndex = 0;
            this.btnStaty1.Text = "Wyświetl plik";
            this.btnStaty1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaty1.UseVisualStyleBackColor = true;
            this.btnStaty1.Click += new System.EventHandler(this.btnStaty1_Click);
            // 
            // btnStaty
            // 
            this.btnStaty.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaty.FlatAppearance.BorderSize = 0;
            this.btnStaty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.btnStaty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStaty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStaty.Location = new System.Drawing.Point(0, 282);
            this.btnStaty.Name = "btnStaty";
            this.btnStaty.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStaty.Size = new System.Drawing.Size(220, 45);
            this.btnStaty.TabIndex = 3;
            this.btnStaty.Text = "Statystyki";
            this.btnStaty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaty.UseVisualStyleBackColor = true;
            this.btnStaty.Click += new System.EventHandler(this.btnStaty_Click);
            // 
            // panelTryby
            // 
            this.panelTryby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(91)))), ((int)(((byte)(191)))));
            this.panelTryby.Controls.Add(this.btnTryb3);
            this.panelTryby.Controls.Add(this.btnTryb2);
            this.panelTryby.Controls.Add(this.btnTryb1);
            this.panelTryby.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTryby.Location = new System.Drawing.Point(0, 145);
            this.panelTryby.Name = "panelTryby";
            this.panelTryby.Size = new System.Drawing.Size(220, 137);
            this.panelTryby.TabIndex = 2;
            // 
            // btnTryb3
            // 
            this.btnTryb3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTryb3.FlatAppearance.BorderSize = 0;
            this.btnTryb3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(97)))));
            this.btnTryb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTryb3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTryb3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTryb3.Location = new System.Drawing.Point(0, 90);
            this.btnTryb3.Name = "btnTryb3";
            this.btnTryb3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTryb3.Size = new System.Drawing.Size(220, 45);
            this.btnTryb3.TabIndex = 2;
            this.btnTryb3.Text = "Tryb3";
            this.btnTryb3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTryb3.UseVisualStyleBackColor = true;
            this.btnTryb3.Click += new System.EventHandler(this.btnTryb3_Click);
            // 
            // btnTryb2
            // 
            this.btnTryb2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTryb2.FlatAppearance.BorderSize = 0;
            this.btnTryb2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(97)))));
            this.btnTryb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTryb2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTryb2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTryb2.Location = new System.Drawing.Point(0, 45);
            this.btnTryb2.Name = "btnTryb2";
            this.btnTryb2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTryb2.Size = new System.Drawing.Size(220, 45);
            this.btnTryb2.TabIndex = 1;
            this.btnTryb2.Text = "Tryb2";
            this.btnTryb2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTryb2.UseVisualStyleBackColor = true;
            this.btnTryb2.Click += new System.EventHandler(this.btnTryb2_Click);
            // 
            // btnTryb1
            // 
            this.btnTryb1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTryb1.FlatAppearance.BorderSize = 0;
            this.btnTryb1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(97)))));
            this.btnTryb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTryb1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTryb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTryb1.Location = new System.Drawing.Point(0, 0);
            this.btnTryb1.Name = "btnTryb1";
            this.btnTryb1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTryb1.Size = new System.Drawing.Size(220, 45);
            this.btnTryb1.TabIndex = 0;
            this.btnTryb1.Text = "Tryb1";
            this.btnTryb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTryb1.UseVisualStyleBackColor = true;
            this.btnTryb1.Click += new System.EventHandler(this.btnTryb1_Click);
            // 
            // btnTryby
            // 
            this.btnTryby.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTryby.FlatAppearance.BorderSize = 0;
            this.btnTryby.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.btnTryby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTryby.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTryby.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTryby.Location = new System.Drawing.Point(0, 100);
            this.btnTryby.Name = "btnTryby";
            this.btnTryby.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTryby.Size = new System.Drawing.Size(220, 45);
            this.btnTryby.TabIndex = 1;
            this.btnTryby.Text = "Tryby gry";
            this.btnTryby.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTryby.UseVisualStyleBackColor = true;
            this.btnTryby.Click += new System.EventHandler(this.btnTryby_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Freestyle Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(240)))));
            this.lblLogo.Location = new System.Drawing.Point(21, 18);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(183, 95);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "trAIM";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // panelGameInfo
            // 
            this.panelGameInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(132)))), ((int)(((byte)(240)))));
            this.panelGameInfo.Controls.Add(this.lblTrafienia);
            this.panelGameInfo.Controls.Add(this.lblCzas);
            this.panelGameInfo.Controls.Add(this.lblCelnosc);
            this.panelGameInfo.Controls.Add(this.lblPunkty);
            this.panelGameInfo.Controls.Add(this.lblLicznikObiektow);
            this.panelGameInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGameInfo.Location = new System.Drawing.Point(220, 0);
            this.panelGameInfo.Name = "panelGameInfo";
            this.panelGameInfo.Size = new System.Drawing.Size(1042, 100);
            this.panelGameInfo.TabIndex = 1;
            // 
            // lblTrafienia
            // 
            this.lblTrafienia.AutoSize = true;
            this.lblTrafienia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrafienia.Location = new System.Drawing.Point(858, 55);
            this.lblTrafienia.Name = "lblTrafienia";
            this.lblTrafienia.Size = new System.Drawing.Size(133, 24);
            this.lblTrafienia.TabIndex = 4;
            this.lblTrafienia.Text = "Trafienia: 0%";
            // 
            // lblCzas
            // 
            this.lblCzas.AutoSize = true;
            this.lblCzas.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzas.Location = new System.Drawing.Point(454, 20);
            this.lblCzas.Name = "lblCzas";
            this.lblCzas.Size = new System.Drawing.Size(149, 70);
            this.lblCzas.TabIndex = 3;
            this.lblCzas.Text = "0:00";
            // 
            // lblCelnosc
            // 
            this.lblCelnosc.AutoSize = true;
            this.lblCelnosc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCelnosc.Location = new System.Drawing.Point(858, 18);
            this.lblCelnosc.Name = "lblCelnosc";
            this.lblCelnosc.Size = new System.Drawing.Size(127, 24);
            this.lblCelnosc.TabIndex = 2;
            this.lblCelnosc.Text = "Celność: 0%";
            // 
            // lblPunkty
            // 
            this.lblPunkty.AutoSize = true;
            this.lblPunkty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPunkty.Location = new System.Drawing.Point(22, 57);
            this.lblPunkty.Name = "lblPunkty";
            this.lblPunkty.Size = new System.Drawing.Size(100, 24);
            this.lblPunkty.TabIndex = 1;
            this.lblPunkty.Text = "Punkty: 0";
            // 
            // lblLicznikObiektow
            // 
            this.lblLicznikObiektow.AutoSize = true;
            this.lblLicznikObiektow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLicznikObiektow.Location = new System.Drawing.Point(22, 18);
            this.lblLicznikObiektow.Name = "lblLicznikObiektow";
            this.lblLicznikObiektow.Size = new System.Drawing.Size(107, 24);
            this.lblLicznikObiektow.TabIndex = 0;
            this.lblLicznikObiektow.Text = "Obiekty: 0";
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.lblOpis);
            this.panelGame.Controls.Add(this.btnStart);
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelGame.Location = new System.Drawing.Point(220, 100);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1042, 573);
            this.panelGame.TabIndex = 2;
            this.panelGame.Click += new System.EventHandler(this.panelGame_Click);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(298, 243);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(398, 45);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.Text = "kliknij aby rozpocząć";
            this.lblOpis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(1042, 573);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelGameInfo);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trAIM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelStaty.ResumeLayout(false);
            this.panelTryby.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelGameInfo.ResumeLayout(false);
            this.panelGameInfo.PerformLayout();
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelTryby;
        private System.Windows.Forms.Button btnTryb2;
        private System.Windows.Forms.Button btnTryb1;
        private System.Windows.Forms.Button btnTryby;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrzerwij;
        private System.Windows.Forms.Panel panelStaty;
        private System.Windows.Forms.Button btnStaty2;
        private System.Windows.Forms.Button btnStaty1;
        private System.Windows.Forms.Button btnStaty;
        private System.Windows.Forms.Button btnTryb3;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel panelGameInfo;
        private System.Windows.Forms.Label lblLicznikObiektow;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label lblCelnosc;
        private System.Windows.Forms.Label lblPunkty;
        private System.Windows.Forms.Label lblCzas;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblTrafienia;
        private System.Windows.Forms.Label lblLogo;
    }
}

