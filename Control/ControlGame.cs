using Kolko_i_krzyżyk.ObiectGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Kolko_i_krzyżyk.Control
{
    public class ControlGame
    {
        public void GameType(Game game, int field, PictureBox pictureBox)
        {
            ChangeField changeField = new ChangeField();
            changeField.ChangeImage(pictureBox, game);
        }
    }
}
