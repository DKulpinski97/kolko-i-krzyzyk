﻿using Kolko_i_krzyżyk.ObiectGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Kolko_i_krzyżyk.Control
{
    class ChangeField
    {

        public void ChangeImage(PictureBox pictureBox, Game game)
        {
            if (game.player == false)
            {
                pictureBox.Image = System.Drawing.Image.FromFile(@"..\..\..\Picture\Cross.png");
                game.player = true;
            }
            else
            {
                pictureBox.Image = System.Drawing.Image.FromFile(@"..\..\..\Picture\Circle.png");
                game.player = false;
            }

        }
    }
}
