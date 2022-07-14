using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kolko_i_krzyżyk
{
    public partial class Plansza : Form
    {
        public Plansza()
        {
            InitializeComponent();
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

        private void DoMovement(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
