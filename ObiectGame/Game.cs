using System;
using System.Collections.Generic;
using System.Text;

namespace Kolko_i_krzyżyk.ObiectGame
{
    public class Game
    {
        public char [] board = new char [9];
        //By zaoszczędzić miejsce urzyłem typu bool do wskazywania gracza
        public bool player = false;
        public int[] result = { 0, 0 };
        public bool computer;



    }
}
