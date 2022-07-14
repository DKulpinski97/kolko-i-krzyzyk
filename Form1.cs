using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolko_i_krzyżyk
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void PlayerVsPlayer_Click(object sender, EventArgs e)
        {
            Plansza plansza = new Plansza(true);
            this.Hide();
            plansza.Show();
            

        }

        private void PlayerVsComputer_Click(object sender, EventArgs e)
        {
            Plansza plansza = new Plansza(false);
            this.Hide();
            plansza.Show();
            
        }

        private void Close_it_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
