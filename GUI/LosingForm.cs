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
    public partial class LosingForm : Form
    {
        Point lastPoint;
        MainForm mainForm;
        public LosingForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void ButtonMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void LosingWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            GameFieldForm gameFieldForm = new GameFieldForm(mainForm);
            this.Hide();
            gameFieldForm.Show();
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

        private void ButtonStart_MouseEnter(object sender, EventArgs e)
        {
            ButtonStart.ForeColor = Color.FromArgb(1, 1, 1);
        }

        private void ButtonStart_MouseLeave(object sender, EventArgs e)
        {
            ButtonStart.ForeColor = Color.White;
        }
    }
}
