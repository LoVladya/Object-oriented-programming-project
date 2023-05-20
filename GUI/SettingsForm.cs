using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_oriented_programming_project.GUI
{
    public partial class SettingsForm : Form
    {
        Point lastPoint;
        public string level;

        MainForm mainForm;
        public SettingsForm(ref string level)
        {
            InitializeComponent();
            mainForm = new MainForm(this);
            this.level = level;
        }

        private void SettingsWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void ButtonMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void LabelButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LabelPreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LabelPreview_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ButtonMain_MouseEnter(object sender, EventArgs e)
        {
            ButtonMain.ForeColor = Color.FromArgb(1, 1, 1);
        }

        private void ButtonMain_MouseLeave(object sender, EventArgs e)
        {
            ButtonMain.ForeColor = Color.White;
        }

        private void ButtonEasy_MouseEnter(object sender, EventArgs e)
        {
            ButtonEasy.BackColor = Color.SeaGreen;
        }

        private void ButtonEasy_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonEasy.Enabled)
            {
                ButtonEasy.BackColor = Color.FromArgb(58, 213, 147);
            }
        }

        private void ButtonMedium_MouseEnter(object sender, EventArgs e)
        {
            ButtonMedium.BackColor = Color.FromArgb(145, 126, 22);
        }

        private void ButtonMedium_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonMedium.Enabled)
            {
                ButtonMedium.BackColor = Color.FromArgb(255, 225, 61);
            }
        }

        private void ButtonHard_MouseEnter(object sender, EventArgs e)
        {
            ButtonHard.BackColor = Color.FromArgb(162, 27, 27);
        }

        private void ButtonHard_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonHard.Enabled)
            {
                ButtonHard.BackColor = Color.FromArgb(255, 62, 62);
            }
        }

        private void ButtonEasy_Click(object sender, EventArgs e)
        {
            DifficultySetter("easy");
        }

        private void ButtonMedium_Click(object sender, EventArgs e)
        {
            DifficultySetter("medium");
        }

        private void ButtonHard_Click(object sender, EventArgs e)
        {
            DifficultySetter("hard");
        }
        private void DifficultySetter(string selectedLevel)
        {
            level = selectedLevel;
            ButtonEasy.Enabled = (selectedLevel != "easy");
            ButtonMedium.Enabled = (selectedLevel != "medium");
            ButtonHard.Enabled = (selectedLevel != "hard");

            if (selectedLevel != "easy")
            {
                ButtonEasy_MouseLeave(this, EventArgs.Empty);
            }    

            if (selectedLevel != "medium")
            {
                ButtonMedium_MouseLeave(this, EventArgs.Empty);
            }
            
            if (selectedLevel != "hard")
            {
                ButtonHard_MouseLeave(this, EventArgs.Empty);
            }
        }
    }
}
