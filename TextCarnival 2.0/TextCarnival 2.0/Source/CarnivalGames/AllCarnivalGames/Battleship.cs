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
        
            return;
        }

    }
   
}
