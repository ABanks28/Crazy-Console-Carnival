using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class Battleship : CarnivalGame
    {
        public override string getName()
        {
            return "Battleship";
        }

        public override void play()
        {
            writeOut("Welcome to a very crappy, beat-down version of battleship!  One of the many features that makes this game so crappy is that you can't play with two players.  So if you have a friend next to you, excited to play some quality battleship, have fun taking turns!");
            wait(5);
            writeOut("What is your name?");
            string PlayersName = getInput();
            wait(2);
            writeOut(PlayersName + ", eh?  A name almost as crappy as this game.  Fitting.");
            wait(3);
            writeOut("My name is Cornelius Van Huber, birdwatching-extraordinaire and battleship champion.  Are you ready to battle, or would you like a tutorial?");
            writeOut("[battle] or [tutorial]");
            string battleOrTutorial = getOption("battle", "tutorial");
            if (battleOrTutorial == "tutorial")
            {
                writeOut("Are you serious?  You don't know how to play battleship?  Did you even have a childhood?");
                wait(2);
                
                writeOut("Whatever.  Here's how the basics go.  You and your opponent (me) both get 5 ships.  Each ship will only take up 1 tile... so this game is more like battlerafts.  To begin, you and I will both place our rafts down on the 5x5 board.  Rows are labeled A-E, and columns are labeled 1-5.  To call or place down a ship on a tile, it would look like this - 'A5'.  That would place it on row 1, column 5.  Capiche? \n[yes] [no]");
                bool capiche = getYesNo();
                writeOut("After we both place our ships, we take turns guessing each other's raft placement.  If I guess a raft position correctly, that raft is destroyed.  If you guess a raft position correctly, that raft is destroyed.  First one to destroy all of the opponent's rafts is victorious.");
                wait(6);
                writeOut("Okay I've run out of patience, let's play.");
            }

            if (battleOrTutorial == "battle")
            {
                writeOut("Ok, ready?  3... 2... 1...");
                dramaticPause(5);
                writeOut("Go!");
            }
            while(1==1)
            {
                writeLine("");
            }
            


            return;
        }

    }
   
}
