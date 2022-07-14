using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Kolko_i_krzyżyk.ObiectGame;


namespace Kolko_i_krzyżyk
{
    public partial class Plansza : Form
    {
        Game game= new Game();
        public Plansza()
        {
            InitializeComponent();
            SumaryPlayerOne.Text = game.Result[0].ToString();
            SumaryPlayerTwo.Text = game.Result[1].ToString();

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
            Field1.Image = Image.FromFile(@"..\..\..\Picture\Cross.png");
        }

        private void Field2_Click(object sender, EventArgs e)
        {

        }

        private void Field3_Click(object sender, EventArgs e)
        {

        }

        private void Field4_Click(object sender, EventArgs e)
        {

        }

        private void Field5_Click(object sender, EventArgs e)
        {

        }

        private void Field6_Click(object sender, EventArgs e)
        {

        }

        private void Field7_Click(object sender, EventArgs e)
        {

        }

        private void Field8_Click(object sender, EventArgs e)
        {

        }

        private void Field9_Click(object sender, EventArgs e)
        {

        }
    }
}
