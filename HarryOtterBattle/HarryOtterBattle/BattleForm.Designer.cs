namespace HarryOtterBattle
{
    partial class BattleForm
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
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnContinueBattle = new System.Windows.Forms.Button();
            this.lblHowToPlay = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tmrLoop = new System.Windows.Forms.Timer(this.components);
            this.lblAllyHealth = new System.Windows.Forms.Label();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.picHarry = new System.Windows.Forms.PictureBox();
            this.picHaremione = new System.Windows.Forms.PictureBox();
            this.picRon = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picLose = new System.Windows.Forms.PictureBox();
            this.picWin = new System.Windows.Forms.PictureBox();
            this.btnContinueShop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHarry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHaremione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Red;
            this.btnAttack.Font = new System.Drawing.Font("Castellar", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(429, 556);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(205, 60);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.BackColor = System.Drawing.Color.Lime;
            this.btnHeal.Font = new System.Drawing.Font("Castellar", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeal.Location = new System.Drawing.Point(652, 556);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(200, 60);
            this.btnHeal.TabIndex = 1;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = false;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Gold;
            this.btnPlay.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(170, 403);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(263, 74);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnContinueBattle
            // 
            this.btnContinueBattle.BackColor = System.Drawing.Color.Gold;
            this.btnContinueBattle.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueBattle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContinueBattle.Location = new System.Drawing.Point(267, 483);
            this.btnContinueBattle.Name = "btnContinueBattle";
            this.btnContinueBattle.Size = new System.Drawing.Size(379, 89);
            this.btnContinueBattle.TabIndex = 6;
            this.btnContinueBattle.Text = "Continue";
            this.btnContinueBattle.UseVisualStyleBackColor = false;
            this.btnContinueBattle.Click += new System.EventHandler(this.btnContinueBattle_Click);
            // 
            // lblHowToPlay
            // 
            this.lblHowToPlay.AutoSize = true;
            this.lblHowToPlay.Font = new System.Drawing.Font("Castellar", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToPlay.Location = new System.Drawing.Point(175, 9);
            this.lblHowToPlay.Name = "lblHowToPlay";
            this.lblHowToPlay.Size = new System.Drawing.Size(577, 42);
            this.lblHowToPlay.TabIndex = 7;
            this.lblHowToPlay.Text = "Choose Your Character";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 134);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(108, 29);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "label1";
            // 
            // tmrLoop
            // 
            this.tmrLoop.Interval = 1;
            this.tmrLoop.Tick += new System.EventHandler(this.tmrLoop_Tick);
            // 
            // lblAllyHealth
            // 
            this.lblAllyHealth.AutoSize = true;
            this.lblAllyHealth.BackColor = System.Drawing.Color.Cyan;
            this.lblAllyHealth.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllyHealth.Location = new System.Drawing.Point(99, 54);
            this.lblAllyHealth.Name = "lblAllyHealth";
            this.lblAllyHealth.Size = new System.Drawing.Size(74, 19);
            this.lblAllyHealth.TabIndex = 10;
            this.lblAllyHealth.Text = "label1";
            // 
            // lblEnemyHealth
            // 
            this.lblEnemyHealth.AutoSize = true;
            this.lblEnemyHealth.BackColor = System.Drawing.Color.Red;
            this.lblEnemyHealth.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealth.Location = new System.Drawing.Point(572, 51);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(74, 19);
            this.lblEnemyHealth.TabIndex = 11;
            this.lblEnemyHealth.Text = "label1";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Gold;
            this.btnRestart.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(641, 403);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(211, 59);
            this.btnRestart.TabIndex = 14;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Gold;
            this.btnQuit.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(701, 473);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(151, 59);
            this.btnQuit.TabIndex = 15;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Visible = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Gold;
            this.btnLoad.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(458, 403);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(263, 74);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gold;
            this.btnSave.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 622);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 27);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save Progress";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picHarry
            // 
            this.picHarry.Image = global::HarryOtterBattle.Properties.Resources.HarryOtter;
            this.picHarry.Location = new System.Drawing.Point(360, 54);
            this.picHarry.Name = "picHarry";
            this.picHarry.Size = new System.Drawing.Size(172, 276);
            this.picHarry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHarry.TabIndex = 2;
            this.picHarry.TabStop = false;
            this.picHarry.Visible = false;
            this.picHarry.Click += new System.EventHandler(this.picHarry_Click);
            // 
            // picHaremione
            // 
            this.picHaremione.Image = global::HarryOtterBattle.Properties.Resources.HaremioneGranger;
            this.picHaremione.Location = new System.Drawing.Point(546, 340);
            this.picHaremione.Name = "picHaremione";
            this.picHaremione.Size = new System.Drawing.Size(250, 276);
            this.picHaremione.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHaremione.TabIndex = 4;
            this.picHaremione.TabStop = false;
            this.picHaremione.Visible = false;
            this.picHaremione.Click += new System.EventHandler(this.picHaremione_Click);
            // 
            // picRon
            // 
            this.picRon.Image = global::HarryOtterBattle.Properties.Resources.RonWeasel;
            this.picRon.Location = new System.Drawing.Point(159, 331);
            this.picRon.Name = "picRon";
            this.picRon.Size = new System.Drawing.Size(130, 285);
            this.picRon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRon.TabIndex = 3;
            this.picRon.TabStop = false;
            this.picRon.Visible = false;
            this.picRon.Click += new System.EventHandler(this.picRon_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::HarryOtterBattle.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(89, 120);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(690, 166);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // picLose
            // 
            this.picLose.Image = global::HarryOtterBattle.Properties.Resources.LoseScreen;
            this.picLose.Location = new System.Drawing.Point(-11, -23);
            this.picLose.Name = "picLose";
            this.picLose.Size = new System.Drawing.Size(900, 700);
            this.picLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLose.TabIndex = 13;
            this.picLose.TabStop = false;
            // 
            // picWin
            // 
            this.picWin.Image = global::HarryOtterBattle.Properties.Resources.WinScreen;
            this.picWin.Location = new System.Drawing.Point(-11, -23);
            this.picWin.Name = "picWin";
            this.picWin.Size = new System.Drawing.Size(900, 700);
            this.picWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWin.TabIndex = 12;
            this.picWin.TabStop = false;
            // 
            // btnContinueShop
            // 
            this.btnContinueShop.BackColor = System.Drawing.Color.Gold;
            this.btnContinueShop.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueShop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContinueShop.Location = new System.Drawing.Point(267, 483);
            this.btnContinueShop.Name = "btnContinueShop";
            this.btnContinueShop.Size = new System.Drawing.Size(379, 89);
            this.btnContinueShop.TabIndex = 18;
            this.btnContinueShop.Text = "Continue";
            this.btnContinueShop.UseVisualStyleBackColor = false;
            this.btnContinueShop.Click += new System.EventHandler(this.btnContinueShop_Click);
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnContinueShop);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblEnemyHealth);
            this.Controls.Add(this.lblAllyHealth);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblHowToPlay);
            this.Controls.Add(this.btnContinueBattle);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picHarry);
            this.Controls.Add(this.picHaremione);
            this.Controls.Add(this.picRon);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picLose);
            this.Controls.Add(this.picWin);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "BattleForm";
            this.Text = "HarryOtter";
            ((System.ComponentModel.ISupportInitialize)(this.picHarry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHaremione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.PictureBox picHarry;
        private System.Windows.Forms.PictureBox picRon;
        private System.Windows.Forms.PictureBox picHaremione;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnContinueBattle;
        private System.Windows.Forms.Label lblHowToPlay;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer tmrLoop;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblAllyHealth;
        private System.Windows.Forms.Label lblEnemyHealth;
        private System.Windows.Forms.PictureBox picWin;
        private System.Windows.Forms.PictureBox picLose;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnContinueShop;
    }
}

