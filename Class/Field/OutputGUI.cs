using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Object_oriented_programming_project.GUI;
using System.Windows.Input;
using System.Diagnostics.PerformanceData;

namespace Object_oriented_programming_project
{
    internal class OutputGUI
    {
        Label labelHealthPlayer = new Label();
        Label labelHealthManiac = new Label();
        Label labelArmour = new Label();
        public PictureBox playerPictureBox = new PictureBox();
        public PictureBox maniacPictureBox = new PictureBox();
        public PictureBox lifePictureBox = new PictureBox();
        public PictureBox trapPictureBox = new PictureBox();
        public PictureBox armourOnePictureBox = new PictureBox();
        public PictureBox armourTwoPictureBox = new PictureBox();
        GameFieldForm gameFieldForm;

        public OutputGUI(GameFieldForm gameFieldForm)
        {
            playerPictureBox.Image = Image.FromFile("../../Images/PlayerIMG.png");
            maniacPictureBox.Image = Image.FromFile("../../Images/ManiacIMG.png");
            lifePictureBox.Image = Image.FromFile("../../Images/LifeIMG.png");
            trapPictureBox.Image = Image.FromFile("../../Images/TrapIMG.png");
            armourOnePictureBox.Image = Image.FromFile("../../Images/ArmourOneIMG.png");
            armourTwoPictureBox.Image = Image.FromFile("../../Images/ArmourTwoIMG.png");
            this.gameFieldForm = gameFieldForm;
        }
        public void PrintInfo(Player player, Maniac maniac) // Друк ігрового поля
        {
            labelHealthPlayer.Text = "Життя гравця:" + player.Health;
            labelHealthManiac.Text = "Життя маніяка:" + maniac.Health;
            labelArmour.Text = "Броня:" + player.inventory.Armour;
        }
        public void SetPrintInfoAndField(Player player, Maniac maniac, Element[,] map) // Друк ігрового поля
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    switch (map[x, y])
                    {
                        case Player:
                            PictureBoxSetter(playerPictureBox, x, y);
                            break;
                        case Maniac:
                            PictureBoxSetter(maniacPictureBox, x, y);
                            break;
                        case Life:
                            PictureBoxSetter(lifePictureBox, x, y);
                            break;
                        case Trap:
                            PictureBoxSetter(trapPictureBox, x, y);
                            break;
                        case ArmourOne:
                            PictureBoxSetter(armourOnePictureBox, x, y);
                            break;
                        case ArmourTwo:
                            PictureBoxSetter(armourTwoPictureBox, x, y);
                            break;
                        case Wall:
                            PictureBox pictureBox = new PictureBox();
                            PictureBoxSetter(pictureBox, x, y);
                            pictureBox.Image = Image.FromFile("../../Images/WallIMG.png");
                            break;
                    }
                }
            }
            
            LabelSetter(labelHealthPlayer, 762, 3, "Життя гравця:", player.Health);
            LabelSetter(labelHealthManiac, 762, 25, "Життя маніяка:", maniac.Health);
            LabelSetter(labelArmour, 762, 47, "Броня:", player.inventory.Armour);
            maniacPictureBox.BringToFront();

            void LabelSetter(Label label, int x, int y, string counterText, int value)
            {
                label.AutoSize = true;
                label.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
                label.Location = new Point(x, y);
                label.Text = counterText + value;
                gameFieldForm.Controls.Add(label);
            }
            void PictureBoxSetter(PictureBox pictureBox, int x, int y)
            {
                pictureBox.Size = new Size(28, 28);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Location = new Point(y * 28 + gameFieldForm.sizeForm, x * 28 + gameFieldForm.sizeForm);
                gameFieldForm.Controls.Add(pictureBox);
            }
        }
    }
}
