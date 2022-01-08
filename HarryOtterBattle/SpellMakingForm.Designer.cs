namespace HarryOtterBattle
{
    partial class SpellMakingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpellMakingForm));
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblQuality = new System.Windows.Forms.Label();
            this.lblFreshness = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrDisplayTime = new System.Windows.Forms.Timer(this.components);
            this.lblSpellFailed = new System.Windows.Forms.Label();
            this.picIngredient2 = new System.Windows.Forms.PictureBox();
            this.picInventory = new System.Windows.Forms.PictureBox();
            this.lblSpellCreated = new System.Windows.Forms.Label();
            this.picFlame2 = new System.Windows.Forms.PictureBox();
            this.picLeaf2 = new System.Windows.Forms.PictureBox();
            this.picLeaf1 = new System.Windows.Forms.PictureBox();
            this.picAir2 = new System.Windows.Forms.PictureBox();
            this.picAir1 = new System.Windows.Forms.PictureBox();
            this.picWater2 = new System.Windows.Forms.PictureBox();
            this.picWater1 = new System.Windows.Forms.PictureBox();
            this.picFlame1 = new System.Windows.Forms.PictureBox();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblPlus2 = new System.Windows.Forms.Label();
            this.lblPlus3 = new System.Windows.Forms.Label();
            this.lblPlus4 = new System.Windows.Forms.Label();
            this.lblFlame = new System.Windows.Forms.Label();
            this.lblLeaf = new System.Windows.Forms.Label();
            this.lblAir = new System.Windows.Forms.Label();
            this.lblWater = new System.Windows.Forms.Label();
            this.lblComboSpell = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblElement = new System.Windows.Forms.Label();
            this.picBook = new System.Windows.Forms.PictureBox();
            this.btnBackToSpell = new System.Windows.Forms.Button();
            this.picIngredient1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIngredient2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeaf2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeaf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAir2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAir1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIngredient1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Centaur", 10F);
            this.btnCreate.Image = global::HarryOtterBattle.Properties.Resources.Button;
            this.btnCreate.Location = new System.Drawing.Point(709, 601);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 45);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::HarryOtterBattle.Properties.Resources.Button;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Centaur", 10F);
            this.btnNext.Location = new System.Drawing.Point(709, 534);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 45);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::HarryOtterBattle.Properties.Resources.Button;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Centaur", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(709, 465);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 45);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.BackColor = System.Drawing.Color.Transparent;
            this.lblQuality.Font = new System.Drawing.Font("Centaur", 18F);
            this.lblQuality.Location = new System.Drawing.Point(490, 482);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(65, 27);
            this.lblQuality.TabIndex = 4;
            this.lblQuality.Text = "label1";
            // 
            // lblFreshness
            // 
            this.lblFreshness.AutoSize = true;
            this.lblFreshness.BackColor = System.Drawing.Color.Transparent;
            this.lblFreshness.Font = new System.Drawing.Font("Centaur", 18F);
            this.lblFreshness.Location = new System.Drawing.Point(490, 427);
            this.lblFreshness.Name = "lblFreshness";
            this.lblFreshness.Size = new System.Drawing.Size(65, 27);
            this.lblFreshness.TabIndex = 5;
            this.lblFreshness.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Centaur", 18F);
            this.lblName.Location = new System.Drawing.Point(490, 375);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 27);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "label1";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(839, 30);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(54, 23);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "label1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrDisplayTime
            // 
            this.tmrDisplayTime.Interval = 1000;
            this.tmrDisplayTime.Tick += new System.EventHandler(this.tmrDisplayTime_Tick);
            // 
            // lblSpellFailed
            // 
            this.lblSpellFailed.AutoSize = true;
            this.lblSpellFailed.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpellFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblSpellFailed.Location = new System.Drawing.Point(356, 213);
            this.lblSpellFailed.Name = "lblSpellFailed";
            this.lblSpellFailed.Size = new System.Drawing.Size(0, 49);
            this.lblSpellFailed.TabIndex = 10;
            this.lblSpellFailed.UseCompatibleTextRendering = true;
            this.lblSpellFailed.Visible = false;
            // 
            // picIngredient2
            // 
            this.picIngredient2.BackColor = System.Drawing.Color.Transparent;
            this.picIngredient2.Location = new System.Drawing.Point(227, 482);
            this.picIngredient2.Margin = new System.Windows.Forms.Padding(2);
            this.picIngredient2.Name = "picIngredient2";
            this.picIngredient2.Size = new System.Drawing.Size(150, 150);
            this.picIngredient2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIngredient2.TabIndex = 8;
            this.picIngredient2.TabStop = false;
            // 
            // picInventory
            // 
            this.picInventory.BackColor = System.Drawing.Color.Transparent;
            this.picInventory.Location = new System.Drawing.Point(495, 43);
            this.picInventory.Name = "picInventory";
            this.picInventory.Size = new System.Drawing.Size(250, 250);
            this.picInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInventory.TabIndex = 1;
            this.picInventory.TabStop = false;
            this.picInventory.Click += new System.EventHandler(this.picInventory_Click);
            // 
            // lblSpellCreated
            // 
            this.lblSpellCreated.AutoSize = true;
            this.lblSpellCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblSpellCreated.Location = new System.Drawing.Point(210, 72);
            this.lblSpellCreated.Name = "lblSpellCreated";
            this.lblSpellCreated.Size = new System.Drawing.Size(0, 46);
            this.lblSpellCreated.TabIndex = 12;
            this.lblSpellCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFlame2
            // 
            this.picFlame2.BackColor = System.Drawing.Color.Transparent;
            this.picFlame2.Image = ((System.Drawing.Image)(resources.GetObject("picFlame2.Image")));
            this.picFlame2.Location = new System.Drawing.Point(427, 397);
            this.picFlame2.Name = "picFlame2";
            this.picFlame2.Size = new System.Drawing.Size(150, 150);
            this.picFlame2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlame2.TabIndex = 14;
            this.picFlame2.TabStop = false;
            this.picFlame2.Visible = false;
            // 
            // picLeaf2
            // 
            this.picLeaf2.BackColor = System.Drawing.Color.Transparent;
            this.picLeaf2.Image = ((System.Drawing.Image)(resources.GetObject("picLeaf2.Image")));
            this.picLeaf2.Location = new System.Drawing.Point(92, 105);
            this.picLeaf2.Name = "picLeaf2";
            this.picLeaf2.Size = new System.Drawing.Size(150, 150);
            this.picLeaf2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLeaf2.TabIndex = 16;
            this.picLeaf2.TabStop = false;
            this.picLeaf2.Visible = false;
            // 
            // picLeaf1
            // 
            this.picLeaf1.BackColor = System.Drawing.Color.Transparent;
            this.picLeaf1.Image = global::HarryOtterBattle.Properties.Resources.Earth;
            this.picLeaf1.Location = new System.Drawing.Point(92, 397);
            this.picLeaf1.Name = "picLeaf1";
            this.picLeaf1.Size = new System.Drawing.Size(150, 150);
            this.picLeaf1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLeaf1.TabIndex = 15;
            this.picLeaf1.TabStop = false;
            this.picLeaf1.Visible = false;
            // 
            // picAir2
            // 
            this.picAir2.BackColor = System.Drawing.Color.Transparent;
            this.picAir2.Image = global::HarryOtterBattle.Properties.Resources.Water;
            this.picAir2.Location = new System.Drawing.Point(612, 397);
            this.picAir2.Name = "picAir2";
            this.picAir2.Size = new System.Drawing.Size(150, 150);
            this.picAir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAir2.TabIndex = 18;
            this.picAir2.TabStop = false;
            this.picAir2.Visible = false;
            // 
            // picAir1
            // 
            this.picAir1.BackColor = System.Drawing.Color.Transparent;
            this.picAir1.Image = ((System.Drawing.Image)(resources.GetObject("picAir1.Image")));
            this.picAir1.Location = new System.Drawing.Point(271, 105);
            this.picAir1.Name = "picAir1";
            this.picAir1.Size = new System.Drawing.Size(150, 150);
            this.picAir1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAir1.TabIndex = 17;
            this.picAir1.TabStop = false;
            this.picAir1.Visible = false;
            // 
            // picWater2
            // 
            this.picWater2.BackColor = System.Drawing.Color.Transparent;
            this.picWater2.Image = global::HarryOtterBattle.Properties.Resources.Earth;
            this.picWater2.Location = new System.Drawing.Point(612, 105);
            this.picWater2.Name = "picWater2";
            this.picWater2.Size = new System.Drawing.Size(150, 150);
            this.picWater2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWater2.TabIndex = 20;
            this.picWater2.TabStop = false;
            this.picWater2.Visible = false;
            // 
            // picWater1
            // 
            this.picWater1.BackColor = System.Drawing.Color.Transparent;
            this.picWater1.Image = global::HarryOtterBattle.Properties.Resources.Water;
            this.picWater1.Location = new System.Drawing.Point(427, 105);
            this.picWater1.Name = "picWater1";
            this.picWater1.Size = new System.Drawing.Size(150, 150);
            this.picWater1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWater1.TabIndex = 19;
            this.picWater1.TabStop = false;
            this.picWater1.Visible = false;
            // 
            // picFlame1
            // 
            this.picFlame1.BackColor = System.Drawing.Color.Transparent;
            this.picFlame1.Image = ((System.Drawing.Image)(resources.GetObject("picFlame1.Image")));
            this.picFlame1.Location = new System.Drawing.Point(271, 397);
            this.picFlame1.Name = "picFlame1";
            this.picFlame1.Size = new System.Drawing.Size(150, 150);
            this.picFlame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlame1.TabIndex = 21;
            this.picFlame1.TabStop = false;
            this.picFlame1.Visible = false;
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.BackColor = System.Drawing.Color.Transparent;
            this.lblPlus.Font = new System.Drawing.Font("Centaur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.Location = new System.Drawing.Point(241, 167);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(32, 31);
            this.lblPlus.TabIndex = 22;
            this.lblPlus.Text = "+";
            this.lblPlus.Visible = false;
            // 
            // lblPlus2
            // 
            this.lblPlus2.AutoSize = true;
            this.lblPlus2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlus2.Font = new System.Drawing.Font("Centaur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus2.Location = new System.Drawing.Point(241, 450);
            this.lblPlus2.Name = "lblPlus2";
            this.lblPlus2.Size = new System.Drawing.Size(32, 31);
            this.lblPlus2.TabIndex = 23;
            this.lblPlus2.Text = "+";
            this.lblPlus2.Visible = false;
            // 
            // lblPlus3
            // 
            this.lblPlus3.AutoSize = true;
            this.lblPlus3.BackColor = System.Drawing.Color.Transparent;
            this.lblPlus3.Font = new System.Drawing.Font("Centaur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus3.Location = new System.Drawing.Point(581, 450);
            this.lblPlus3.Name = "lblPlus3";
            this.lblPlus3.Size = new System.Drawing.Size(32, 31);
            this.lblPlus3.TabIndex = 24;
            this.lblPlus3.Text = "+";
            this.lblPlus3.Visible = false;
            // 
            // lblPlus4
            // 
            this.lblPlus4.AutoSize = true;
            this.lblPlus4.BackColor = System.Drawing.Color.Transparent;
            this.lblPlus4.Font = new System.Drawing.Font("Centaur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus4.Location = new System.Drawing.Point(581, 167);
            this.lblPlus4.Name = "lblPlus4";
            this.lblPlus4.Size = new System.Drawing.Size(32, 31);
            this.lblPlus4.TabIndex = 25;
            this.lblPlus4.Text = "+";
            this.lblPlus4.Visible = false;
            // 
            // lblFlame
            // 
            this.lblFlame.AutoSize = true;
            this.lblFlame.BackColor = System.Drawing.Color.Transparent;
            this.lblFlame.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlame.Location = new System.Drawing.Point(99, 298);
            this.lblFlame.Name = "lblFlame";
            this.lblFlame.Size = new System.Drawing.Size(143, 23);
            this.lblFlame.TabIndex = 26;
            this.lblFlame.Text = "Claim to FLAME";
            this.lblFlame.Visible = false;
            // 
            // lblLeaf
            // 
            this.lblLeaf.AutoSize = true;
            this.lblLeaf.BackColor = System.Drawing.Color.Transparent;
            this.lblLeaf.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaf.Location = new System.Drawing.Point(99, 340);
            this.lblLeaf.Name = "lblLeaf";
            this.lblLeaf.Size = new System.Drawing.Size(124, 23);
            this.lblLeaf.TabIndex = 27;
            this.lblLeaf.Text = "LEAF me alone";
            this.lblLeaf.Visible = false;
            // 
            // lblAir
            // 
            this.lblAir.AutoSize = true;
            this.lblAir.BackColor = System.Drawing.Color.Transparent;
            this.lblAir.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAir.Location = new System.Drawing.Point(429, 340);
            this.lblAir.Name = "lblAir";
            this.lblAir.Size = new System.Drawing.Size(194, 23);
            this.lblAir.TabIndex = 28;
            this.lblAir.Text = "Get out of atmospHERE";
            this.lblAir.Visible = false;
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.BackColor = System.Drawing.Color.Transparent;
            this.lblWater.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWater.Location = new System.Drawing.Point(429, 296);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(157, 23);
            this.lblWater.TabIndex = 29;
            this.lblWater.Text = "WATER you doing";
            this.lblWater.Visible = false;
            // 
            // lblComboSpell
            // 
            this.lblComboSpell.AutoSize = true;
            this.lblComboSpell.BackColor = System.Drawing.Color.Transparent;
            this.lblComboSpell.Font = new System.Drawing.Font("Centaur", 50F);
            this.lblComboSpell.Location = new System.Drawing.Point(258, 273);
            this.lblComboSpell.Name = "lblComboSpell";
            this.lblComboSpell.Size = new System.Drawing.Size(369, 76);
            this.lblComboSpell.TabIndex = 30;
            this.lblComboSpell.Text = "Combo Spell?";
            this.lblComboSpell.Visible = false;
            // 
            // btnYes
            // 
            this.btnYes.BackgroundImage = global::HarryOtterBattle.Properties.Resources.Button;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnYes.Location = new System.Drawing.Point(256, 360);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(180, 41);
            this.btnYes.TabIndex = 31;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackgroundImage = global::HarryOtterBattle.Properties.Resources.Button;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnNo.Location = new System.Drawing.Point(447, 360);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(180, 41);
            this.btnNo.TabIndex = 32;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Centaur", 18F);
            this.lblQuantity.Location = new System.Drawing.Point(490, 541);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 27);
            this.lblQuantity.TabIndex = 33;
            this.lblQuantity.Text = "label1";
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.BackColor = System.Drawing.Color.Transparent;
            this.lblElement.Font = new System.Drawing.Font("Centaur", 18F);
            this.lblElement.Location = new System.Drawing.Point(490, 592);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(65, 27);
            this.lblElement.TabIndex = 34;
            this.lblElement.Text = "label1";
            // 
            // picBook
            // 
            this.picBook.BackColor = System.Drawing.Color.Transparent;
            this.picBook.Location = new System.Drawing.Point(55, 18);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(118, 122);
            this.picBook.TabIndex = 36;
            this.picBook.TabStop = false;
            this.picBook.Click += new System.EventHandler(this.picBook_Click);
            // 
            // btnBackToSpell
            // 
            this.btnBackToSpell.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToSpell.BackgroundImage = global::HarryOtterBattle.Properties.Resources.Button;
            this.btnBackToSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToSpell.Font = new System.Drawing.Font("Centaur", 10F);
            this.btnBackToSpell.Location = new System.Drawing.Point(783, 601);
            this.btnBackToSpell.Name = "btnBackToSpell";
            this.btnBackToSpell.Size = new System.Drawing.Size(89, 45);
            this.btnBackToSpell.TabIndex = 37;
            this.btnBackToSpell.Text = "Back";
            this.btnBackToSpell.UseVisualStyleBackColor = false;
            this.btnBackToSpell.Visible = false;
            this.btnBackToSpell.Click += new System.EventHandler(this.btnBackToSpell_Click);
            // 
            // picIngredient1
            // 
            this.picIngredient1.BackColor = System.Drawing.Color.Transparent;
            this.picIngredient1.Location = new System.Drawing.Point(86, 429);
            this.picIngredient1.Margin = new System.Windows.Forms.Padding(2);
            this.picIngredient1.Name = "picIngredient1";
            this.picIngredient1.Size = new System.Drawing.Size(150, 150);
            this.picIngredient1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIngredient1.TabIndex = 7;
            this.picIngredient1.TabStop = false;
            // 
            // SpellMakingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.ControlBox = false;
            this.Controls.Add(this.picLeaf2);
            this.Controls.Add(this.btnBackToSpell);
            this.Controls.Add(this.picBook);
            this.Controls.Add(this.lblElement);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblComboSpell);
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.lblAir);
            this.Controls.Add(this.lblLeaf);
            this.Controls.Add(this.lblFlame);
            this.Controls.Add(this.lblPlus4);
            this.Controls.Add(this.lblPlus3);
            this.Controls.Add(this.lblPlus2);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.picFlame1);
            this.Controls.Add(this.picWater2);
            this.Controls.Add(this.picWater1);
            this.Controls.Add(this.picAir2);
            this.Controls.Add(this.picAir1);
            this.Controls.Add(this.lblSpellCreated);
            this.Controls.Add(this.lblSpellFailed);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picIngredient2);
            this.Controls.Add(this.picIngredient1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFreshness);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picInventory);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.picLeaf1);
            this.Controls.Add(this.picFlame2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 678);
            this.Name = "SpellMakingForm";
            this.Text = "SpellMakingForm";
            ((System.ComponentModel.ISupportInitialize)(this.picIngredient2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeaf2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeaf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAir2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAir1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIngredient1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox picInventory;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Label lblFreshness;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picIngredient2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrDisplayTime;
        private System.Windows.Forms.Label lblSpellFailed;
        private System.Windows.Forms.Label lblSpellCreated;
        private System.Windows.Forms.PictureBox picFlame2;
        private System.Windows.Forms.PictureBox picLeaf2;
        private System.Windows.Forms.PictureBox picLeaf1;
        private System.Windows.Forms.PictureBox picAir2;
        private System.Windows.Forms.PictureBox picAir1;
        private System.Windows.Forms.PictureBox picWater2;
        private System.Windows.Forms.PictureBox picWater1;
        private System.Windows.Forms.PictureBox picFlame1;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblPlus2;
        private System.Windows.Forms.Label lblPlus3;
        private System.Windows.Forms.Label lblPlus4;
        private System.Windows.Forms.Label lblFlame;
        private System.Windows.Forms.Label lblLeaf;
        private System.Windows.Forms.Label lblAir;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Label lblComboSpell;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.PictureBox picBook;
        private System.Windows.Forms.Button btnBackToSpell;
        private System.Windows.Forms.PictureBox picIngredient1;
    }
}

