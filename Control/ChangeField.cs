using Kolko_i_krzyżyk.ObiectGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Kolko_i_krzyżyk;

namespace Kolko_i_krzyżyk.Control
{
    class ChangeField
    {

        public void ChangeImage(PictureBox pictureBox, Game game)
        {
            if (game.player == false)
            {
                pictureBox.Image = System.Drawing.Image.FromFile(@"..\..\..\Picture\Cross.png");
            }
            else
            {
                pictureBox.Image = System.Drawing.Image.FromFile(@"..\..\..\Picture\Circle.png");
            }

        }
        public void ChangeInformationInBoardOfFields(int Field, Game game)
        {
            if (game.player == false)
            {
                game.board[Field - 1] = 'X';
                game.player = true;
            }
            else
            {
                game.board[Field - 1] = 'O';
                game.player = false;
            }

        }
        public void RestartFields()
        {

        }
    }
}
