
namespace Shotgun
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.lbPlayerAmmo = new System.Windows.Forms.Label();
            this.lbCPUAmmo = new System.Windows.Forms.Label();
            this.btnReStart = new System.Windows.Forms.Button();
            this.lbCPUChoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShoot
            // 
            this.btnShoot.Enabled = false;
            this.btnShoot.Location = new System.Drawing.Point(379, 404);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(112, 34);
            this.btnShoot.TabIndex = 0;
            this.btnShoot.Text = "Skjut";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Location = new System.Drawing.Point(497, 404);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(112, 34);
            this.btnReLoad.TabIndex = 1;
            this.btnReLoad.Text = "Ladda";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(615, 404);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(112, 34);
            this.btnBlock.TabIndex = 2;
            this.btnBlock.Text = "Blockera";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnShotgun
            // 
            this.btnShotgun.Enabled = false;
            this.btnShotgun.Location = new System.Drawing.Point(258, 404);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(115, 33);
            this.btnShotgun.TabIndex = 3;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // lbPlayerAmmo
            // 
            this.lbPlayerAmmo.AutoSize = true;
            this.lbPlayerAmmo.Location = new System.Drawing.Point(403, 344);
            this.lbPlayerAmmo.Name = "lbPlayerAmmo";
            this.lbPlayerAmmo.Size = new System.Drawing.Size(120, 25);
            this.lbPlayerAmmo.TabIndex = 4;
            this.lbPlayerAmmo.Text = "Player ammo:";
            // 
            // lbCPUAmmo
            // 
            this.lbCPUAmmo.AutoSize = true;
            this.lbCPUAmmo.Location = new System.Drawing.Point(403, 25);
            this.lbCPUAmmo.Name = "lbCPUAmmo";
            this.lbCPUAmmo.Size = new System.Drawing.Size(106, 25);
            this.lbCPUAmmo.TabIndex = 5;
            this.lbCPUAmmo.Text = "CPU ammo:";
            // 
            // btnReStart
            // 
            this.btnReStart.Location = new System.Drawing.Point(12, 404);
            this.btnReStart.Name = "btnReStart";
            this.btnReStart.Size = new System.Drawing.Size(154, 34);
            this.btnReStart.TabIndex = 6;
            this.btnReStart.Text = "Starta om spelet";
            this.btnReStart.UseVisualStyleBackColor = true;
            this.btnReStart.Click += new System.EventHandler(this.btnReStart_Click);
            // 
            // lbCPUChoice
            // 
            this.lbCPUChoice.AutoSize = true;
            this.lbCPUChoice.Location = new System.Drawing.Point(379, 81);
            this.lbCPUChoice.Name = "lbCPUChoice";
            this.lbCPUChoice.Size = new System.Drawing.Size(0, 25);
            this.lbCPUChoice.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCPUChoice);
            this.Controls.Add(this.btnReStart);
            this.Controls.Add(this.lbCPUAmmo);
            this.Controls.Add(this.lbPlayerAmmo);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.btnShoot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.Label lbPlayerAmmo;
        private System.Windows.Forms.Label lbCPUAmmo;
        private System.Windows.Forms.Button btnReStart;
        private System.Windows.Forms.Label lbCPUChoice;
    }
}

