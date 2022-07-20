using Kolko_i_krzyżyk.Check;
using Kolko_i_krzyżyk.ObiectGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Kolko_i_krzyżyk.Control
{
    public class ControlGame
    {
        public void GameType(Game game, int field, VisibleObjects visibleObjects)
        {

            if (game.computer == false)
            {
                ControlPlayerVSPlayer(game, field , visibleObjects);
            }
            else
            {
                ControlPlayerVSComputer(game, field , visibleObjects);
            }
        }
        public void ControlPlayerVSPlayer(Game game, int field, VisibleObjects visibleObjects)
        {
            CheckTheFields checkTheFields = new CheckTheFields();
            ChangeField changeField = new ChangeField();
            int[] pozytion = Pozytion(field);
            if (game.board[pozytion[1],pozytion[0]] == '\0')
            {
                changeField.ChangeImage(visibleObjects.pictureBoxes[field], game);
                changeField.ChangeInformationInBoardOfFields(field, game, pozytion);
                checkTheFields.CheckColumns(game, visibleObjects);
                checkTheFields.CheckRow(game, visibleObjects);
                checkTheFields.CheckCrose(game, visibleObjects);
                checkTheFields.CheckTie(game, visibleObjects);
            }
            else
            {
                MessageBox.Show("Nie można urzyć tego pola poniewarz jest one już zajęte");
            }


        }
        public void ControlPlayerVSComputer(Game game, int field, VisibleObjects visibleObjects)
        {
            CheckTheFields checkTheFields = new CheckTheFields();
            ChangeField changeField = new ChangeField();
            int[] pozytion;
            if (game.player == false)
            {
                pozytion = Pozytion(field);
                changeField.ChangeImage(visibleObjects.pictureBoxes[field], game);
                changeField.ChangeInformationInBoardOfFields(field, game, pozytion);
            }
            else
            {
                for (int i = 0; i < 1; i = 0)
                {
                    field = RandomPozytion();
                    pozytion = Pozytion(field);
                    if (game.board[pozytion[1], pozytion[0]] == '\0')
                    {
                        changeField.ChangeImage(visibleObjects.pictureBoxes[field], game);
                        changeField.ChangeInformationInBoardOfFields(field, game, pozytion);
                        break;
                    }
                }
            }
        }
        public int RandomPozytion()
        {
            var rand = new Random();
            int a=0;
                 a= rand.Next(0, 9);
            return a;
        }

            public int[] Pozytion (int field)
            {
            int[] pozytion= new int[2];
            pozytion[0] = field % 3;
            pozytion[1] = Convert.ToInt32(field/3);
            return pozytion;
            }
    }
}
