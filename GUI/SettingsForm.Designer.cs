using System.Drawing;

namespace Object_oriented_programming_project.GUI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.ButtonMain = new System.Windows.Forms.Button();
            this.LabelPreview = new System.Windows.Forms.Label();
            this.LabelButtonExit = new System.Windows.Forms.Label();
            this.ButtonEasy = new System.Windows.Forms.Button();
            this.ButtonMedium = new System.Windows.Forms.Button();
            this.ButtonHard = new System.Windows.Forms.Button();
            this.LabelDifficulty = new System.Windows.Forms.Label();
            this.PicturePreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonMain
            // 
            this.ButtonMain.AutoSize = true;
            this.ButtonMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonMain.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ButtonMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMain.Font = new System.Drawing.Font("Comic Sans MS", 17F);
            this.ButtonMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonMain.Location = new System.Drawing.Point(307, 369);
            this.ButtonMain.Name = "ButtonMain";
            this.ButtonMain.Size = new System.Drawing.Size(144, 50);
            this.ButtonMain.TabIndex = 5;
            this.ButtonMain.Text = "Головна";
            this.ButtonMain.UseVisualStyleBackColor = false;
            this.ButtonMain.Click += new System.EventHandler(this.ButtonMain_Click);
            this.ButtonMain.MouseEnter += new System.EventHandler(this.ButtonMain_MouseEnter);
            this.ButtonMain.MouseLeave += new System.EventHandler(this.ButtonMain_MouseLeave);
            // 
            // LabelPreview
            // 
            this.LabelPreview.Font = new System.Drawing.Font("Comic Sans MS", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPreview.ForeColor = System.Drawing.Color.Teal;
            this.LabelPreview.Location = new System.Drawing.Point(-12, -5);
            this.LabelPreview.Name = "LabelPreview";
            this.LabelPreview.Size = new System.Drawing.Size(757, 100);
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
            this.LabelButtonExit.Location = new System.Drawing.Point(724, 9);
            this.LabelButtonExit.Name = "LabelButtonExit";
            this.LabelButtonExit.Size = new System.Drawing.Size(21, 20);
            this.LabelButtonExit.TabIndex = 8;
            this.LabelButtonExit.Text = "X";
            this.LabelButtonExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LabelButtonExit.Click += new System.EventHandler(this.LabelButtonExit_Click);
            // 
            // ButtonEasy
            // 
            this.ButtonEasy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(213)))), ((int)(((byte)(147)))));
            this.ButtonEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEasy.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.ButtonEasy.ForeColor = System.Drawing.Color.Black;
            this.ButtonEasy.Location = new System.Drawing.Point(67, 245);
            this.ButtonEasy.Name = "ButtonEasy";
            this.ButtonEasy.Size = new System.Drawing.Size(153, 44);
            this.ButtonEasy.TabIndex = 9;
            this.ButtonEasy.Text = "Легкий";
            this.ButtonEasy.UseVisualStyleBackColor = false;
            this.ButtonEasy.Click += new System.EventHandler(this.ButtonEasy_Click);
            this.ButtonEasy.MouseEnter += new System.EventHandler(this.ButtonEasy_MouseEnter);
            this.ButtonEasy.MouseLeave += new System.EventHandler(this.ButtonEasy_MouseLeave);
            // 
            // ButtonMedium
            // 
            this.ButtonMedium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMedium.AutoSize = true;
            this.ButtonMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(61)))));
            this.ButtonMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMedium.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.ButtonMedium.ForeColor = System.Drawing.Color.Black;
            this.ButtonMedium.Location = new System.Drawing.Point(301, 245);
            this.ButtonMedium.Name = "ButtonMedium";
            this.ButtonMedium.Size = new System.Drawing.Size(157, 44);
            this.ButtonMedium.TabIndex = 10;
            this.ButtonMedium.Text = "Нормальний";
            this.ButtonMedium.UseVisualStyleBackColor = false;
            this.ButtonMedium.Click += new System.EventHandler(this.ButtonMedium_Click);
            this.ButtonMedium.MouseEnter += new System.EventHandler(this.ButtonMedium_MouseEnter);
            this.ButtonMedium.MouseLeave += new System.EventHandler(this.ButtonMedium_MouseLeave);
            // 
            // ButtonHard
            // 
            this.ButtonHard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ButtonHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHard.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.ButtonHard.ForeColor = System.Drawing.Color.Black;
            this.ButtonHard.Location = new System.Drawing.Point(538, 245);
            this.ButtonHard.Name = "ButtonHard";
            this.ButtonHard.Size = new System.Drawing.Size(153, 44);
            this.ButtonHard.TabIndex = 11;
            this.ButtonHard.Text = "Складний";
            this.ButtonHard.UseVisualStyleBackColor = false;
            this.ButtonHard.Click += new System.EventHandler(this.ButtonHard_Click);
            this.ButtonHard.MouseEnter += new System.EventHandler(this.ButtonHard_MouseEnter);
            this.ButtonHard.MouseLeave += new System.EventHandler(this.ButtonHard_MouseLeave);
            // 
            // LabelDifficulty
            // 
            this.LabelDifficulty.AutoSize = true;
            this.LabelDifficulty.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelDifficulty.Font = new System.Drawing.Font("Comic Sans MS", 17F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.LabelDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(95)))));
            this.LabelDifficulty.Location = new System.Drawing.Point(191, 175);
            this.LabelDifficulty.Name = "LabelDifficulty";
            this.LabelDifficulty.Size = new System.Drawing.Size(377, 41);
            this.LabelDifficulty.TabIndex = 12;
            this.LabelDifficulty.Text = "Оберіть тип складності";
            // 
            // PicturePreview
            // 
            this.PicturePreview.BackColor = System.Drawing.Color.Transparent;
            this.PicturePreview.Image = global::Object_oriented_programming_project.Properties.Resources.GunIMG;
            this.PicturePreview.Location = new System.Drawing.Point(521, 12);
            this.PicturePreview.Name = "PicturePreview";
            this.PicturePreview.Size = new System.Drawing.Size(57, 59);
            this.PicturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicturePreview.TabIndex = 13;
            this.PicturePreview.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 458);
            this.Controls.Add(this.PicturePreview);
            this.Controls.Add(this.LabelDifficulty);
            this.Controls.Add(this.ButtonHard);
            this.Controls.Add(this.ButtonMedium);
            this.Controls.Add(this.ButtonEasy);
            this.Controls.Add(this.LabelButtonExit);
            this.Controls.Add(this.LabelPreview);
            this.Controls.Add(this.ButtonMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsWindow";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsWindow_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonMain;
        private System.Windows.Forms.Label LabelPreview;
        private System.Windows.Forms.Label LabelButtonExit;
        private System.Windows.Forms.Button ButtonEasy;
        private System.Windows.Forms.Button ButtonMedium;
        private System.Windows.Forms.Button ButtonHard;
        private System.Windows.Forms.Label LabelDifficulty;
        private System.Windows.Forms.PictureBox PicturePreview;
    }
}