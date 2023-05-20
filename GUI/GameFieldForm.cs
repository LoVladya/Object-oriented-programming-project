using Object_oriented_programming_project.Class.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Object_oriented_programming_project.GUI
{
    public partial class GameFieldForm : Form
    {
        Point lastPoint;
        private bool isPaused = false;
        private Timer timer;
        public int sizeForm;
        MainForm mainForm;
        MotorGUI motorGUI = new MotorGUI();

        public GameFieldForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            string level = mainForm.settingsForm.level;
            InitializeComponent();
            Dictionary<string, Action> sizeKeys = new Dictionary<string, Action>()
            {
                { "easy", () => sizeForm = 250 },
                { "medium", () => sizeForm = 190 },
                { "hard", () => sizeForm = 80 }
            };
            sizeKeys[level]();

            motorGUI.fieldForPlayer.level = level;
            motorGUI.GameProcess(this);

            timer = new Timer();
            timer.Interval = 400;
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            timer.Interval = new Random().Next(100, 300);
            if (new Random().Next(6) < 4)
            {
                Step('*');
            }
        }
        private void Step(char keyChar)
        {
            if (!isPaused && motorGUI.Step(this, keyChar))
            {

                timer.Stop();
                this.Hide();
                LosingForm losingForm = new LosingForm(mainForm);
                losingForm.Show();

            }
        }
        private void GameFieldWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Application.Exit();
            }
            Step(e.KeyChar);
        }

        private void ButtonMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            ButtonMain.Visible = false;
            ButtonContinue.Visible = false;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            isPaused = false;
        }

        private void LabelButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LabelButtonPause_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                ButtonContinue_Click(sender, e);
            }
            else
            {
                this.BackColor = System.Drawing.SystemColors.AppWorkspace;
                ButtonMain.Visible = true;
                ButtonContinue.Visible = true;
                isPaused = true;
            }
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

        private void ButtonContinue_MouseEnter(object sender, EventArgs e)
        {
            ButtonContinue.ForeColor = Color.FromArgb(1, 1, 1);
        }

        private void ButtonContinue_MouseLeave(object sender, EventArgs e)
        {
            ButtonContinue.ForeColor = Color.White;
        }
    }
}
