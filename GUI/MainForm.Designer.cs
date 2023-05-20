using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Drawing;

namespace Object_oriented_programming_project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonStart = new System.Windows.Forms.Button();
            this.LabelPreview = new System.Windows.Forms.Label();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.setElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelButtonExit = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.PicturePreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.setElementBindingSource)).BeginInit();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.AutoSize = true;
            this.ButtonStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonStart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStart.Font = new System.Drawing.Font("Comic Sans MS", 17F);
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonStart.Location = new System.Drawing.Point(486, 369);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(186, 50);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Почати гру";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            this.ButtonStart.MouseEnter += new System.EventHandler(this.ButtonStart_MouseEnter);
            this.ButtonStart.MouseLeave += new System.EventHandler(this.ButtonStart_MouseLeave);
            // 
            // LabelPreview
            // 
            this.LabelPreview.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelPreview.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPreview.ForeColor = System.Drawing.Color.Teal;
            this.LabelPreview.Location = new System.Drawing.Point(-23, 138);
            this.LabelPreview.Name = "LabelPreview";
            this.LabelPreview.Size = new System.Drawing.Size(757, 100);
            this.LabelPreview.TabIndex = 0;
            this.LabelPreview.Text = "Fight or run!";
            this.LabelPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.AutoSize = true;
            this.ButtonSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSettings.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ButtonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSettings.Font = new System.Drawing.Font("Comic Sans MS", 17F);
            this.ButtonSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonSettings.Location = new System.Drawing.Point(78, 369);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(226, 50);
            this.ButtonSettings.TabIndex = 0;
            this.ButtonSettings.Text = "Налаштування";
            this.ButtonSettings.UseVisualStyleBackColor = false;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            this.ButtonSettings.MouseEnter += new System.EventHandler(this.ButtonSettings_MouseEnter);
            this.ButtonSettings.MouseLeave += new System.EventHandler(this.ButtonSettings_MouseLeave);
            // 
            // setElementBindingSource
            // 
            this.setElementBindingSource.DataSource = typeof(Object_oriented_programming_project.Map.SetElement);
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
            this.LabelButtonExit.TabIndex = 1;
            this.LabelButtonExit.Text = "X";
            this.LabelButtonExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LabelButtonExit.Click += new System.EventHandler(this.LabelButton_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.LabelButtonExit);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(757, 100);
            this.PanelHeader.TabIndex = 3;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.PanelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            // 
            // PicturePreview
            // 
            this.PicturePreview.BackColor = System.Drawing.Color.Transparent;
            this.PicturePreview.Image = global::Object_oriented_programming_project.Properties.Resources.GunIMG;
            this.PicturePreview.Location = new System.Drawing.Point(567, 142);
            this.PicturePreview.Name = "PicturePreview";
            this.PicturePreview.Size = new System.Drawing.Size(79, 80);
            this.PicturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicturePreview.TabIndex = 7;
            this.PicturePreview.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 458);
            this.Controls.Add(this.PicturePreview);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.LabelPreview);
            this.Controls.Add(this.ButtonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight or run";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.setElementBindingSource)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label LabelPreview;
        private System.Windows.Forms.Button ButtonSettings;
        private BindingSource setElementBindingSource;
        private Label LabelButtonExit;
        private Panel PanelHeader;
        private PictureBox PicturePreview;
    }
}