﻿using Kolko_i_krzyżyk.Control;
using Kolko_i_krzyżyk.ObiectGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Kolko_i_krzyżyk.Check
{
    class CheckTheFields
    {
        public void CheckColumns(Game game, VisibleObjects visibleObjects )
        {
            char symbol;
            int tmp = 0;
            for(int startPozytion = 0; startPozytion < 3; startPozytion++)
            {
                if (game.board[startPozytion] != '\0')
                {
                    symbol = game.board[startPozytion];
                    tmp++;
                    for (int j = 1; j < 3; j++)
                    {
                        if(symbol== game.board[startPozytion+(j*3)])
                        {
                            tmp++;
                        }
                    }
                    if(tmp==3)
                    {
                        WriteTheWinner(game, symbol);
                        ChangeField changeField = new ChangeField();
                        changeField.RestartFields(visibleObjects, game);
                        break;
                    }
                    else
                    {
                        tmp = 0;
                        symbol = '\0';
                    }
                }
            }
        }

        public void CheckRow(Game game, VisibleObjects visibleObjects)
        {
            int tmp = 0;
            char symbol='\0';
            if(game.board[0] != '\0')
            {
                symbol = game.board[0];
            }
            for(int i=0;i<9;i++)
            {
                if(game.board[i]!='\0'&& symbol== game.board[i])
                {
                    tmp++;
                }
                if( i==2 || i==5 || i==8 )
                {
                    if(tmp==3)
                    {
                        WriteTheWinner(game, symbol);
                        ChangeField changeField = new ChangeField();
                        changeField.RestartFields(visibleObjects, game);
                        break;
                    }
                    tmp = 0;
                    symbol = '\0';
                    if (i + 1 < 9 && game.board[i+1]!='\0' )
                    {
                        symbol = game.board[i + 1];
                    }
                }
            }
        }
        private void WriteTheWinner(Game game,char symbol)
        {
            if(symbol=='X')
            {
                MessageBox.Show("Zwycięscą w meczu jest gracz 1");
                game.result[0]++;
            }
            else
            {
                MessageBox.Show("Zwycięscą w meczu jest gracz 2");
                game.result[1]++;
            }
            
        }
    }
}
