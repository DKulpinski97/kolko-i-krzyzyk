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
        public Plansza(bool computer)
        {
            InitializeComponent();
            //SumaryPlayerOne.Text = game.result[0].ToString();
            //SumaryPlayerTwo.Text = game.result[1].ToString();
            game.computer = computer;
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

        private void Field1_Click(object sender, EventArgs e)
        {
            controlGame.GameType(game, 1, Field1);

        }

        private void Field2_Click(object sender, EventArgs e)
        {
            controlGame.GameType(game, 2, Field2);
        }

        private void Field3_Click(object sender, EventArgs e)
        {
            controlGame.GameType(game, 3, Field3);
        }

        private void Field4_Click(object sender, EventArgs e)
        {
            controlGame.GameType(game, 4, Field4);
        }

        private void Field5_Click(object sender, EventArgs e)
        {
            controlGame.GameType(game, 5, Field5);
        }

        private void Field6_Click(object sender, EventArgs e)
        {
            controlGame.GameType(game, 6, Field6);
        }

        private void Field7_Click(object sender, EventArgs e)
        {
            controlGame.GameType(game, 7, Field7);
        }

        private void Field8_Click(object sender, EventArgs e)
        {
            controlGame.GameType(game, 8, Field8);
        }

        private void Field9_Click(object sender, EventArgs e)
        {
            controlGame.GameType(game, 9, Field9);
        }
    }
}
