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
            writeOut(PlayersName + ", really?  Same!");
            wait(3);
            writeOut("My name is " + PlayersName + ", birdwatching-extraordinaire and battleship champion.  Are you ready to battle, or would you like a tutorial?");
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

            writeLine("Raft location 1: ");
            string L1 = getInput();
            writeLine("Raft location 2: ");
            string L2 = getInput();
            writeLine("Raft location 3: ");
            string L3 = getInput();
            writeLine("Raft location 4: ");
            string L4 = getInput();
            writeLine("Raft location 5: ");
            string L5 = getInput();


            string[,] enemyField = new string[,]
    {
                        {"-", "-", "-", "-", "-"},
                        {"-", "-", "-", "-", "-"},
                        {"-", "-", "-", "-", "-"},
                        {"-", "-", "-", "-", "-"},
                        {"-", "-", "-", "-", "-"},
    };
            string[,] yourField = new string[,]
                {
                        {"x", "x", "x", "x", "x"},
                        {"x", "x", "x", "x", "x"},
                        {"x", "x", "x", "x", "x"},
                        {"x", "x", "x", "x", "x"},
                        {"x", "x", "x", "x", "x"},
                };

            char aa = Convert.ToChar(L1.Substring(0, 1));
            int a = char.ToUpper(aa) - 65;
            int aaa = Convert.ToInt32(L1.Substring(1));

            char bb = Convert.ToChar(L2.Substring(0, 1));
            int b = char.ToUpper(bb) - 65;
            int bbb = Convert.ToInt32(L2.Substring(1));

            char cc = Convert.ToChar(L3.Substring(0, 1));
            int c = char.ToUpper(cc) - 65;
            int ccc = Convert.ToInt32(L3.Substring(1));

            char dd = Convert.ToChar(L4.Substring(0, 1));
            int d = char.ToUpper(dd) - 65;
            int ddd = Convert.ToInt32(L4.Substring(1));

            char ee = Convert.ToChar(L5.Substring(0, 1));
            int e = char.ToUpper(ee) - 65;
            int eee = Convert.ToInt32(L5.Substring(1));

            yourField[a, aaa] = yourField[a, aaa].Replace("x", "o");
            yourField[b, bbb] = yourField[b, bbb].Replace("x", "o");
            yourField[c, ccc] = yourField[c, ccc].Replace("x", "o");
            yourField[d, ddd] = yourField[d, ddd].Replace("x", "o");
            yourField[e, eee] = yourField[e, eee].Replace("x", "o");


            string eL1 = "a2";
            string eL2 = "e3";
            string eL3 = "a4";
            string eL4 = "c4";
            string eL5 = "d1";

            char ff = Convert.ToChar(eL1.Substring(0, 1));
            int f = char.ToUpper(ff) - 65;
            int fff = Convert.ToInt32(eL1.Substring(1));

            char gg = Convert.ToChar(eL2.Substring(0, 1));
            int g = char.ToUpper(gg) - 65;
            int ggg = Convert.ToInt32(eL2.Substring(1));

            char hh = Convert.ToChar(eL3.Substring(0, 1));
            int h = char.ToUpper(hh) - 65;
            int hhh = Convert.ToInt32(eL3.Substring(1));

            char ii = Convert.ToChar(eL4.Substring(0, 1));
            int i = char.ToUpper(ii) - 65;
            int iii = Convert.ToInt32(eL4.Substring(1));

            char jj = Convert.ToChar(eL5.Substring(0, 1));
            int j = char.ToUpper(jj) - 65;
            int jjj = Convert.ToInt32(eL5.Substring(1));


            while (1==1)
            {


                writeLine("Call enemy raft location: ");
                string callShip = getInput();

                if(callShip != eL1 && callShip != eL2 && callShip != eL3 && callShip != eL4 && callShip != eL5)
                {
                    writeLine("You missed.");
                }

                if (callShip == eL1)
                {
                    enemyField[f, fff] = enemyField[f, fff].Replace("-", "x");
                    writeLine("You sunk a raft.");
                }

                if (callShip == eL2)
                {
                    enemyField[g, ggg] = enemyField[g, ggg].Replace("-", "x");
                    writeLine("You sunk a raft.");
                }

                if (callShip == eL3)
                {
                    enemyField[h, hhh] = enemyField[h, hhh].Replace("-", "x");
                    writeLine("You sunk a raft.");
                }

                if (callShip == eL4)
                {
                    enemyField[i, iii] = enemyField[i, iii].Replace("-", "x");
                    writeLine("You sunk a raft.");
                }

                if (callShip == eL5)
                {
                    enemyField[j, jjj] = enemyField[j, jjj].Replace("-", "x");
                    writeLine("You sunk a raft.");
                }

                Random rand = new Random();
                int xRand = rand.Next(5);
                int yRand = rand.Next(5);

                string enemyCall = yourField[xRand, yRand];
                int m = xRand;
                int n = yRand;
                writeLine("Your opponent called row " + m + " and column " + n);
               
                if (xRand == a && yRand == aaa)
                {
                    yourField[a, aaa] = yourField[a, aaa].Replace("o", "x");
                    writeLine("Your opponent sunk one of your rafts!");
                }
                if (xRand == b && yRand == bbb)
                {
                    yourField[b, bbb] = yourField[b, bbb].Replace("o", "x");
                    writeLine("Your opponent sunk one of your rafts!");
                }
                if (xRand == c && yRand == ccc)
                {
                    yourField[c, ccc] = yourField[c, ccc].Replace("o", "x");
                    writeLine("Your opponent sunk one of your rafts!");
                }
                if (xRand == d && yRand == ddd)
                {
                    yourField[d, ddd] = yourField[d, ddd].Replace("o", "x");
                    writeLine("Your opponent sunk one of your rafts!");
                }
                if (xRand == e && yRand == eee)
                {
                    yourField[e, eee] = yourField[e, eee].Replace("o", "x");
                    writeLine("Your opponent sunk one of your rafts!");
                }







                for (int r = 0; r < 5; r++)
                {
                    writeLine("");
                    for (int k = 0; k < 5; k++)
                    {
                        write(enemyField[r, k]);
                    }
                }
                for (int r = 0; r < 5; r++)
                {
                    writeLine("");
                    for (int k = 0; k < 5; k++)
                    {
                        write(yourField[r, k]);
                    }
                }

                writeLine("");
                wait(10);
                clear();

                if (enemyField[f, fff] = "x" &&)
            }
            


            return;
        }

    }
   
}
