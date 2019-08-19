using System;

namespace WindowsFormsApp1
{
    partial class Formplaygame
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
            this.lvg = new System.Windows.Forms.Label();
            this.videoplayer = new System.Windows.Forms.PictureBox();
            this.btgunload = new System.Windows.Forms.Button();
            this.btgunshoot = new System.Windows.Forms.Button();
            this.Btshoot = new System.Windows.Forms.Button();
            this.btreload = new System.Windows.Forms.Button();
            this.btgunspin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lvg
            // 
            this.lvg.AutoSize = true;
            this.lvg.BackColor = System.Drawing.Color.Gold;
            this.lvg.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvg.Location = new System.Drawing.Point(66, 45);
            this.lvg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvg.Name = "lvg";
            this.lvg.Size = new System.Drawing.Size(435, 74);
            this.lvg.TabIndex = 0;
            this.lvg.Text = "Russian Roullete";
            // 
            // videoplayer
            // 
            this.videoplayer.Location = new System.Drawing.Point(555, 60);
            this.videoplayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.videoplayer.Name = "videoplayer";
            this.videoplayer.Size = new System.Drawing.Size(592, 460);
            this.videoplayer.TabIndex = 1;
            this.videoplayer.TabStop = false;
            // 
            // btgunload
            // 
            this.btgunload.BackColor = System.Drawing.Color.Gold;
            this.btgunload.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgunload.Location = new System.Drawing.Point(52, 168);
            this.btgunload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btgunload.Name = "btgunload";
            this.btgunload.Size = new System.Drawing.Size(159, 109);
            this.btgunload.TabIndex = 2;
            this.btgunload.Text = "Gun Load";
            this.btgunload.UseVisualStyleBackColor = false;
            this.btgunload.Click += new System.EventHandler(this.btgunload_Click);
            // 
            // btgunshoot
            // 
            this.btgunshoot.BackColor = System.Drawing.Color.Gold;
            this.btgunshoot.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgunshoot.Location = new System.Drawing.Point(298, 368);
            this.btgunshoot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btgunshoot.Name = "btgunshoot";
            this.btgunshoot.Size = new System.Drawing.Size(159, 109);
            this.btgunshoot.TabIndex = 4;
            this.btgunshoot.Text = "Shoot Away";
            this.btgunshoot.UseVisualStyleBackColor = false;
            this.btgunshoot.Click += new System.EventHandler(this.btgunshoot_Click);
            // 
            // Btshoot
            // 
            this.Btshoot.BackColor = System.Drawing.Color.Gold;
            this.Btshoot.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btshoot.Location = new System.Drawing.Point(52, 365);
            this.Btshoot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btshoot.Name = "Btshoot";
            this.Btshoot.Size = new System.Drawing.Size(203, 109);
            this.Btshoot.TabIndex = 5;
            this.Btshoot.Text = "Gunshoot";
            this.Btshoot.UseVisualStyleBackColor = false;
            this.Btshoot.Click += new System.EventHandler(this.Btshoot_Click);
            // 
            // btreload
            // 
            this.btreload.BackColor = System.Drawing.Color.Gold;
            this.btreload.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreload.Location = new System.Drawing.Point(154, 535);
            this.btreload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btreload.Name = "btreload";
            this.btreload.Size = new System.Drawing.Size(208, 109);
            this.btreload.TabIndex = 6;
            this.btreload.Text = "Game Reload";
            this.btreload.UseVisualStyleBackColor = false;
            this.btreload.Click += new System.EventHandler(this.btreload_Click);
            // 
            // btgunspin
            // 
            this.btgunspin.BackColor = System.Drawing.Color.Gold;
            this.btgunspin.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgunspin.Location = new System.Drawing.Point(298, 168);
            this.btgunspin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btgunspin.Name = "btgunspin";
            this.btgunspin.Size = new System.Drawing.Size(159, 109);
            this.btgunspin.TabIndex = 7;
            this.btgunspin.Text = "Gun Spin";
            this.btgunspin.UseVisualStyleBackColor = false;
            this.btgunspin.Click += new System.EventHandler(this.btgunspin_Click);
            // 
            // Formplaygame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.main;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btgunspin);
            this.Controls.Add(this.btreload);
            this.Controls.Add(this.Btshoot);
            this.Controls.Add(this.btgunshoot);
            this.Controls.Add(this.btgunload);
            this.Controls.Add(this.videoplayer);
            this.Controls.Add(this.lvg);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Formplaygame";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Formplaygame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btgunspin_Click(object sender, EventArgs e)
        {
            btgunspin.Enabled = false;
            btgunshoot.Enabled = true;
            Btshoot.Enabled = true;
            videoplayer.Image = WindowsFormsApp1.Properties.Resources._1;
            System.IO.Stream str = WindowsFormsApp1.Properties.Resources.shoot;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        #endregion

        private System.Windows.Forms.Label lvg;
        private System.Windows.Forms.PictureBox videoplayer;
        private System.Windows.Forms.Button btgunload;
        private System.Windows.Forms.Button btgunshoot;
        private System.Windows.Forms.Button Btshoot;
        private System.Windows.Forms.Button btreload;
        private System.Windows.Forms.Button btgunspin;
    }
}