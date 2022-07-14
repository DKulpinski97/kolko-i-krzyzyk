using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Kolko_i_krzyżyk.Control;
using Kolko_i_krzyżyk.ObiectGame;


namespace Kolko_i_krzyżyk
{
    public partial class Plansza : Form
    {
        Game game = new Game();
        ControlGame controlGame = new ControlGame();
        VisibleObjects visibleObjects = new VisibleObjects();
        public Plansza(bool computer)
        {
            InitializeComponent();
            priperVisibleObjects();
            game.computer = computer;
        }
        private void priperVisibleObjects()
        {
            PictureBox[] allPictureBoxes = { Field1, Field2, Field3, Field4, Field5, Field6, Field7, Field8, Field9 };
            visibleObjects.pictureBoxes = allPictureBoxes;
            Label[] labels = { SumaryPlayerOne, SumaryPlayerTwo };
            visibleObjects.label = labels;
        }
        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void CloseIt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            
            string tmp = ((PictureBox)sender).Name;
            controlGame.GameType(game, Convert.ToInt32(tmp[tmp.Length - 1]) - 49, (PictureBox)sender, visibleObjects);

        }
        private void Restart_Click(object sender, EventArgs e)
        {
            ChangeField changeField = new ChangeField();
            changeField.RestartFields(visibleObjects, game);
        }
    }
}
