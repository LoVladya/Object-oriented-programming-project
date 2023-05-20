using System.Drawing;

namespace Object_oriented_programming_project.GUI
{
    partial class LosingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LosingForm));
            this.ButtonMain = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.LabelButtonExit = new System.Windows.Forms.Label();
            this.LabelPreview = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicturePreview = new System.Windows.Forms.PictureBox();
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
            this.ButtonMain.Font = new System.Drawing.Font("Comic Sans MS", 17F);
            this.ButtonMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonMain.Location = new System.Drawing.Point(107, 355);
            this.ButtonMain.Name = "ButtonMain";
            this.ButtonMain.Size = new System.Drawing.Size(144, 50);
            this.ButtonMain.TabIndex = 3;
            this.ButtonMain.Text = "Головна";
            this.ButtonMain.UseVisualStyleBackColor = false;
            this.ButtonMain.Click += new System.EventHandler(this.ButtonMain_Click);
            this.ButtonMain.MouseEnter += new System.EventHandler(this.ButtonMain_MouseEnter);
            this.ButtonMain.MouseLeave += new System.EventHandler(this.ButtonMain_MouseLeave);
            // 
            // ButtonStart
            // 
            this.ButtonStart.AutoSize = true;
            this.ButtonStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonStart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStart.Font = new System.Drawing.Font("Comic Sans MS", 17F);
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonStart.Location = new System.Drawing.Point(494, 355);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(153, 50);
            this.ButtonStart.TabIndex = 4;
            this.ButtonStart.Text = "Спочатку";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            this.ButtonStart.MouseEnter += new System.EventHandler(this.ButtonStart_MouseEnter);
            this.ButtonStart.MouseLeave += new System.EventHandler(this.ButtonStart_MouseLeave);
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
            this.LabelButtonExit.TabIndex = 5;
            this.LabelButtonExit.Text = "X";
            this.LabelButtonExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LabelButtonExit.Click += new System.EventHandler(this.LabelButtonExit_Click);
            // 
            // LabelPreview
            // 
            this.LabelPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelPreview.Font = new System.Drawing.Font("Comic Sans MS", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPreview.ForeColor = System.Drawing.Color.Teal;
            this.LabelPreview.Location = new System.Drawing.Point(0, 0);
            this.LabelPreview.Name = "LabelPreview";
            this.LabelPreview.Size = new System.Drawing.Size(757, 100);
            this.LabelPreview.TabIndex = 7;
            this.LabelPreview.Text = "Fight or run!";
            this.LabelPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelPreview_MouseDown);
            this.LabelPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelPreview_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            this.label1.Location = new System.Drawing.Point(82, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "Нажаль, ви програли ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Object_oriented_programming_project.Properties.Resources.SadIMG;
            this.pictureBox1.Location = new System.Drawing.Point(613, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PicturePreview
            // 
            this.PicturePreview.BackColor = System.Drawing.Color.Transparent;
            this.PicturePreview.Image = global::Object_oriented_programming_project.Properties.Resources.GunIMG;
            this.PicturePreview.Location = new System.Drawing.Point(535, 24);
            this.PicturePreview.Name = "PicturePreview";
            this.PicturePreview.Size = new System.Drawing.Size(57, 59);
            this.PicturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicturePreview.TabIndex = 6;
            this.PicturePreview.TabStop = false;
            // 
            // LosingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelButtonExit);
            this.Controls.Add(this.PicturePreview);
            this.Controls.Add(this.ButtonMain);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.LabelPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LosingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LosingWindow";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LosingWindow_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonMain;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.PictureBox PicturePreview;
        private System.Windows.Forms.Label LabelButtonExit;
        private System.Windows.Forms.Label LabelPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}