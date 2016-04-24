namespace HalloweenGame
{
    partial class Form1
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
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblEnemy2 = new System.Windows.Forms.Label();
            this.lblEnemy1 = new System.Windows.Forms.Label();
            this.playerAttackInput = new System.Windows.Forms.ListBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblStory = new System.Windows.Forms.Label();
            this.lblcombatRound = new System.Windows.Forms.Label();
            this.lblAtkPrompt = new System.Windows.Forms.Label();
            this.lblUserAttack = new System.Windows.Forms.Label();
            this.lblEnemyAttack = new System.Windows.Forms.Label();
            this.btnHealChocBar = new System.Windows.Forms.Button();
            this.btnHealPix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(12, 464);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(0, 25);
            this.lblPlayer.TabIndex = 1;
            // 
            // lblEnemy2
            // 
            this.lblEnemy2.AutoSize = true;
            this.lblEnemy2.Location = new System.Drawing.Point(905, 161);
            this.lblEnemy2.Name = "lblEnemy2";
            this.lblEnemy2.Size = new System.Drawing.Size(0, 25);
            this.lblEnemy2.TabIndex = 2;
            // 
            // lblEnemy1
            // 
            this.lblEnemy1.AutoSize = true;
            this.lblEnemy1.Location = new System.Drawing.Point(12, 161);
            this.lblEnemy1.Name = "lblEnemy1";
            this.lblEnemy1.Size = new System.Drawing.Size(0, 25);
            this.lblEnemy1.TabIndex = 3;
            // 
            // playerAttackInput
            // 
            this.playerAttackInput.Enabled = false;
            this.playerAttackInput.FormattingEnabled = true;
            this.playerAttackInput.ItemHeight = 25;
            this.playerAttackInput.Location = new System.Drawing.Point(644, 399);
            this.playerAttackInput.Name = "playerAttackInput";
            this.playerAttackInput.Size = new System.Drawing.Size(202, 204);
            this.playerAttackInput.TabIndex = 4;
            this.playerAttackInput.SelectedIndexChanged += new System.EventHandler(this.playerAttackInput_SelectedIndexChanged);
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(367, 261);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(146, 96);
            this.btnBegin.TabIndex = 5;
            this.btnBegin.Text = "Open the Book";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(892, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 135);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 307);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 154);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(17, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(123, 135);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.lblStory);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(231, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 393);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.ForeColor = System.Drawing.Color.Orange;
            this.btnNext.Location = new System.Drawing.Point(678, 355);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 35);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblStory
            // 
            this.lblStory.BackColor = System.Drawing.Color.Black;
            this.lblStory.ForeColor = System.Drawing.Color.Orange;
            this.lblStory.Location = new System.Drawing.Point(14, 25);
            this.lblStory.Name = "lblStory";
            this.lblStory.Size = new System.Drawing.Size(751, 311);
            this.lblStory.TabIndex = 9;
            // 
            // lblcombatRound
            // 
            this.lblcombatRound.AutoSize = true;
            this.lblcombatRound.Location = new System.Drawing.Point(402, 12);
            this.lblcombatRound.Name = "lblcombatRound";
            this.lblcombatRound.Size = new System.Drawing.Size(0, 25);
            this.lblcombatRound.TabIndex = 10;
            // 
            // lblAtkPrompt
            // 
            this.lblAtkPrompt.AutoSize = true;
            this.lblAtkPrompt.Location = new System.Drawing.Point(639, 360);
            this.lblAtkPrompt.Name = "lblAtkPrompt";
            this.lblAtkPrompt.Size = new System.Drawing.Size(0, 25);
            this.lblAtkPrompt.TabIndex = 11;
            // 
            // lblUserAttack
            // 
            this.lblUserAttack.AutoSize = true;
            this.lblUserAttack.Location = new System.Drawing.Point(376, 58);
            this.lblUserAttack.Name = "lblUserAttack";
            this.lblUserAttack.Size = new System.Drawing.Size(0, 25);
            this.lblUserAttack.TabIndex = 12;
            // 
            // lblEnemyAttack
            // 
            this.lblEnemyAttack.AutoSize = true;
            this.lblEnemyAttack.Location = new System.Drawing.Point(376, 112);
            this.lblEnemyAttack.Name = "lblEnemyAttack";
            this.lblEnemyAttack.Size = new System.Drawing.Size(0, 25);
            this.lblEnemyAttack.TabIndex = 13;
            // 
            // btnHealChocBar
            // 
            this.btnHealChocBar.AutoSize = true;
            this.btnHealChocBar.Enabled = false;
            this.btnHealChocBar.Location = new System.Drawing.Point(250, 656);
            this.btnHealChocBar.Name = "btnHealChocBar";
            this.btnHealChocBar.Size = new System.Drawing.Size(230, 35);
            this.btnHealChocBar.TabIndex = 14;
            this.btnHealChocBar.Text = "Heal with Chocolate Bar";
            this.btnHealChocBar.UseVisualStyleBackColor = true;
            this.btnHealChocBar.Visible = false;
            this.btnHealChocBar.Click += new System.EventHandler(this.btnHealChocBar_Click);
            // 
            // btnHealPix
            // 
            this.btnHealPix.AutoSize = true;
            this.btnHealPix.Enabled = false;
            this.btnHealPix.Location = new System.Drawing.Point(531, 656);
            this.btnHealPix.Name = "btnHealPix";
            this.btnHealPix.Size = new System.Drawing.Size(230, 35);
            this.btnHealPix.TabIndex = 15;
            this.btnHealPix.Text = "Heal with Pixie Stick";
            this.btnHealPix.UseVisualStyleBackColor = true;
            this.btnHealPix.Visible = false;
            this.btnHealPix.Click += new System.EventHandler(this.btnHealPix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 703);
            this.Controls.Add(this.btnHealPix);
            this.Controls.Add(this.btnHealChocBar);
            this.Controls.Add(this.lblEnemyAttack);
            this.Controls.Add(this.lblUserAttack);
            this.Controls.Add(this.lblAtkPrompt);
            this.Controls.Add(this.lblcombatRound);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.playerAttackInput);
            this.Controls.Add(this.lblEnemy1);
            this.Controls.Add(this.lblEnemy2);
            this.Controls.Add(this.lblPlayer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halloween: A Story Game - David Palermo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblEnemy2;
        private System.Windows.Forms.Label lblEnemy1;
        private System.Windows.Forms.ListBox playerAttackInput;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblStory;
        private System.Windows.Forms.Label lblcombatRound;
        private System.Windows.Forms.Label lblAtkPrompt;
        private System.Windows.Forms.Label lblUserAttack;
        private System.Windows.Forms.Label lblEnemyAttack;
        private System.Windows.Forms.Button btnHealChocBar;
        private System.Windows.Forms.Button btnHealPix;
    }
}

