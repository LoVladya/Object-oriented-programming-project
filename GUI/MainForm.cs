using Object_oriented_programming_project.Class.GUI;
using Object_oriented_programming_project.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_oriented_programming_project
{
    public partial class MainForm : Form
    {
        Point lastPoint;
        public SettingsForm settingsForm;
        public MainForm(SettingsForm settingsForm)
        {
            InitializeComponent();
            this.settingsForm = settingsForm;
        }

        private void LabelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonStart_MouseEnter(object sender, EventArgs e)
        {
            ButtonStart.ForeColor = Color.FromArgb(1, 1, 1);
        }

        private void ButtonStart_MouseLeave(object sender, EventArgs e)
        {
            ButtonStart.ForeColor = Color.White;
        }

        private void ButtonSettings_MouseEnter(object sender, EventArgs e)
        {
            ButtonSettings.ForeColor = Color.FromArgb(1, 1, 1);
        }

        private void ButtonSettings_MouseLeave(object sender, EventArgs e)
        {
            ButtonSettings.ForeColor = Color.White;
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            settingsForm.Show();
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameFieldForm gameFieldForm = new GameFieldForm(this);
            gameFieldForm.Show();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
