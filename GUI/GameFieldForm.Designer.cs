using System.Drawing;

namespace Object_oriented_programming_project.GUI
{
    partial class GameFieldForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameFieldForm));
            this.ButtonMain = new System.Windows.Forms.Button();
            this.ButtonContinue = new System.Windows.Forms.Button();
            this.LabelPreview = new System.Windows.Forms.Label();
            this.LabelButtonExit = new System.Windows.Forms.Label();
            this.LabelButtonPause = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicturePreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonMain
            // 
            this.ButtonMain.AutoSize = true;
            this.ButtonMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonMain.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ButtonMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMain.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonMain.Location = new System.Drawing.Point(276, 721);
            this.ButtonMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonMain.Name = "ButtonMain";
            this.ButtonMain.Size = new System.Drawing.Size(208, 70);
            this.ButtonMain.TabIndex = 5;
            this.ButtonMain.Text = "Головна";
            this.ButtonMain.UseVisualStyleBackColor = false;
            this.ButtonMain.Visible = false;
            this.ButtonMain.Click += new System.EventHandler(this.ButtonMain_Click);
            this.ButtonMain.MouseEnter += new System.EventHandler(this.ButtonMain_MouseEnter);
            this.ButtonMain.MouseLeave += new System.EventHandler(this.ButtonMain_MouseLeave);
            // 
            // ButtonContinue
            // 
            this.ButtonContinue.AutoSize = true;
            this.ButtonContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonContinue.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ButtonContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonContinue.Font = new System.Drawing.Font("Comic Sans MS", 26F);
            this.ButtonContinue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonContinue.Location = new System.Drawing.Point(781, 721);
            this.ButtonContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonContinue.Name = "ButtonContinue";
            this.ButtonContinue.Size = new System.Drawing.Size(308, 71);
            this.ButtonContinue.TabIndex = 3;
            this.ButtonContinue.Text = "Продовжити";
            this.ButtonContinue.UseVisualStyleBackColor = false;
            this.ButtonContinue.Visible = false;
            this.ButtonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            this.ButtonContinue.MouseEnter += new System.EventHandler(this.ButtonContinue_MouseEnter);
            this.ButtonContinue.MouseLeave += new System.EventHandler(this.ButtonContinue_MouseLeave);
            // 
            // LabelPreview
            // 
            this.LabelPreview.Font = new System.Drawing.Font("Comic Sans MS", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPreview.ForeColor = System.Drawing.Color.Teal;
            this.LabelPreview.Location = new System.Drawing.Point(437, -2);
            this.LabelPreview.Name = "LabelPreview";
            this.LabelPreview.Size = new System.Drawing.Size(499, 100);
            this.LabelPreview.TabIndex = 6;
            this.LabelPreview.Text = "Fight or run!";
            this.LabelPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelPreview_MouseDown);
            this.LabelPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelPreview_MouseMove);
            // 
            // LabelButtonExit
            // 
            this.LabelButtonExit.AutoSize = true;
            this.LabelButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelButtonExit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LabelButtonExit.Location = new System.Drawing.Point(1330, 14);
            this.LabelButtonExit.Name = "LabelButtonExit";
            this.LabelButtonExit.Size = new System.Drawing.Size(21, 20);
            this.LabelButtonExit.TabIndex = 8;
            this.LabelButtonExit.Text = "X";
            this.LabelButtonExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LabelButtonExit.Click += new System.EventHandler(this.LabelButtonExit_Click);
            // 
            // LabelButtonPause
            // 
            this.LabelButtonPause.AutoSize = true;
            this.LabelButtonPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelButtonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelButtonPause.Location = new System.Drawing.Point(1292, 10);
            this.LabelButtonPause.Name = "LabelButtonPause";
            this.LabelButtonPause.Size = new System.Drawing.Size(22, 25);
            this.LabelButtonPause.TabIndex = 9;
            this.LabelButtonPause.Text = "||";
            this.LabelButtonPause.Click += new System.EventHandler(this.LabelButtonPause_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Object_oriented_programming_project.Properties.Resources.ManiacIMG_3;
            this.pictureBox3.Location = new System.Drawing.Point(985, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Object_oriented_programming_project.Properties.Resources.ArmourTwoIMG_2;
            this.pictureBox2.Location = new System.Drawing.Point(985, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Object_oriented_programming_project.Properties.Resources.LifeIMG;
            this.pictureBox1.Location = new System.Drawing.Point(985, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PicturePreview
            // 
            this.PicturePreview.BackColor = System.Drawing.Color.Transparent;
            this.PicturePreview.Image = global::Object_oriented_programming_project.Properties.Resources.GunIMG;
            this.PicturePreview.Location = new System.Drawing.Point(839, 14);
            this.PicturePreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicturePreview.Name = "PicturePreview";
            this.PicturePreview.Size = new System.Drawing.Size(57, 59);
            this.PicturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicturePreview.TabIndex = 7;
            this.PicturePreview.TabStop = false;
            // 
            // GameFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1372, 1072);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelButtonPause);
            this.Controls.Add(this.LabelButtonExit);
            this.Controls.Add(this.PicturePreview);
            this.Controls.Add(this.LabelPreview);
            this.Controls.Add(this.ButtonMain);
            this.Controls.Add(this.ButtonContinue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameFieldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameFieldWindow";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameFieldWindow_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonMain;
        private System.Windows.Forms.Button ButtonContinue;
        private System.Windows.Forms.Label LabelPreview;
        private System.Windows.Forms.PictureBox PicturePreview;
        private System.Windows.Forms.Label LabelButtonExit;
        private System.Windows.Forms.Label LabelButtonPause;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}