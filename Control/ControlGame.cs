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
            
            if(game.computer==false)
            {
                ControlPlayerVSPlayer(game, field, pictureBox);
            }
        }
        public void ControlPlayerVSPlayer(Game game, int field, PictureBox pictureBox)
        {
            ChangeField changeField = new ChangeField();
            if (game.board[field - 1] == '\0')
            {
                changeField.ChangeImage(pictureBox, game);
                changeField.ChangeInformationInBoardOffields(field, game);
            }
            else
            {
                MessageBox.Show("Nie można urzyć tego pola poniewarz jest one już zajęte");
            }
                
            
        }
    }
}
