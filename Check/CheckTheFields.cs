using Kolko_i_krzyżyk.Control;
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
        ChangeField changeField = new ChangeField();
        public void CheckColumns(Game game, VisibleObjects visibleObjects )
        {
            
            
            for(int i=0;i<3;i++)
            {
                int tmp = 0;
                char symbol = '\0';
                for (int j=0;j<3;j++)
                {
                    if(game.board[j,i]!='\0')
                    {
                        if(symbol== '\0')
                        {
                            symbol = game.board[j, i];
                            tmp++;
                        }
                        else if(symbol== game.board[j, i])
                        {
                            tmp++;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if(tmp==3)
                {
                    WriteTheWinner(game, symbol);
                    changeField.RestartFields(visibleObjects, game);
                    break;
                }

            }
        }

       public void CheckRow(Game game, VisibleObjects visibleObjects)
        {
            for (int i = 0; i < 3; i++)
            {
                int tmp = 0;
                char symbol = '\0';
                for (int j = 0; j < 3; j++)
                {
                    if (game.board[i, j] != '\0')
                    {
                        if (symbol == '\0')
                        {
                            symbol = game.board[i, j];
                            tmp++;
                        }
                        else if (symbol == game.board[i, j])
                        {
                            tmp++;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (tmp == 3)
                {
                    WriteTheWinner(game, symbol);
                    changeField.RestartFields(visibleObjects, game);
                    break;
                }

            }
        }
        public void CheckCrose(Game game, VisibleObjects visibleObjects)
        {
            if(game.board[0, 0]== game.board[1, 1] && game.board[0, 0]== game.board[2, 2] && game.board[0, 0]!='\0')
            {
                char symbol = game.board[0, 0];
                WriteTheWinner(game, symbol);
                changeField.RestartFields(visibleObjects, game);
            }
            else if(game.board[0, 2] == game.board[1, 1] && game.board[0, 2] == game.board[2, 0] && game.board[0, 2] != '\0')
            {
                char symbol = game.board[0, 2];
                WriteTheWinner(game, symbol);
                changeField.RestartFields(visibleObjects, game);
            }
        }
        public void CheckTie(Game game, VisibleObjects visibleObjects)
        {
            int tmp = 0;
            for(int i=0;i<3;i++)
            {
                for (int j=0;j<3;j++)
                {
                    if(game.board[i, j]!='\0')
                    {
                        tmp++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if(tmp==9)
            {
                MessageBox.Show("Partia zakonczona remisem");
                
                changeField.RestartFields(visibleObjects, game);
            }
        }
        public bool CheckHowMenyFieldUse(Game game)
        {
            int tmp = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (game.board[i, j] != '\0')
                    {
                        tmp++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (tmp == 9)
            {
                return true;
            }
            else
            {
                return false;
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
