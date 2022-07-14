﻿using Kolko_i_krzyżyk.ObiectGame;
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
        public void RestartFields(VisibleObjects visibleObjects, Game game)
        {
            for(int i=0;i<9;i++)
            {
                visibleObjects.pictureBoxes[i].Image= System.Drawing.Image.FromFile(@"..\..\..\Picture\Empty.png");
                game.board[i] = '\0';
            }

            visibleObjects.label[0].Text = game.result[0].ToString();
            visibleObjects.label[1].Text = game.result[1].ToString();
            game.player = false;

        }
    }
}
