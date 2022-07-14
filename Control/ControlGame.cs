using Kolko_i_krzyżyk.Check;
using Kolko_i_krzyżyk.ObiectGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Kolko_i_krzyżyk.Control
{
    public class ControlGame
    {
        public void GameType(Game game, int field, PictureBox pictureBox, VisibleObjects visibleObjects)
        {
            
            if(game.computer==false)
            {
                ControlPlayerVSPlayer(game, field, pictureBox, visibleObjects);
            }
        }
        public void ControlPlayerVSPlayer(Game game, int field, PictureBox pictureBox, VisibleObjects visibleObjects)
        {
            CheckTheFields checkTheFields = new CheckTheFields();
            ChangeField changeField = new ChangeField();
            if (game.board[field - 1] == '\0')
            {
                changeField.ChangeImage(pictureBox, game);
                changeField.ChangeInformationInBoardOfFields(field, game);
                checkTheFields.CheckColumns(game, visibleObjects);
                checkTheFields.CheckRow(game, visibleObjects);
            }
            else
            {
                MessageBox.Show("Nie można urzyć tego pola poniewarz jest one już zajęte");
            }
                
            
        }
    }
}
