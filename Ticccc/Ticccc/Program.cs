using System;

namespace Ticccc
{
    class Program
    {
        static char[,] playField =
        {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' }
        };

        static char[,] playFieldInit =
        {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' }
        };

        int turns = 0;

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCheck = true;

            

            do
            {
                if (player == 2)
                {
                    player = 1;
                    XorO(player, input);
                }
                else
                {
                    player = 2;
                    XorO(player, input);
                }

                setField();
                char[] playerChars = { 'X', 'O' };
                
                foreach(char playerChar in playerChars)
                {
                    if(playField[0,0] == playerChar && playField[0,1] == playerChar && playField[0,2] == playerChar 
                        || playField[0, 0] == playerChar && playField[1, 0] == playerChar && playField[2, 0] == playerChar
                        || playField[0, 0] == playerChar && playField[1, 1] == playerChar && playField[2, 2] == playerChar
                        || playField[1, 0] == playerChar && playField[1, 1] == playerChar && playField[1, 2] == playerChar
                        || playField[0, 2] == playerChar && playField[1, 1] == playerChar && playField[2, 0] == playerChar)
                    {
                        if(playerChar == 'X')
                        {
                            Console.WriteLine("You won player 1!");
                        }
                        else
                        {
                            Console.WriteLine("You won player 2!");
                        }
                        break;
                    }
                    
                }

                do
                {
                    Console.WriteLine("player {0}, make your move", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number");
                    }

                    if(input == 1 && playField[0,0] == '1')
                    {
                        inputCheck = true;
                    }
                    else if (input == 2 && playField[0, 1] == '2')
                    {
                        inputCheck = true;
                    }
                    else if (input == 3 && playField[0, 2] == '3')
                    {
                        inputCheck = true;
                    }
                    else if (input == 4 && playField[1, 0] == '4')
                    {
                        inputCheck = true;
                    }
                    else if (input == 5 && playField[1, 1] == '5')
                    {
                        inputCheck = true;
                    }
                    else if (input == 6 && playField[1, 2] == '6')
                    {
                        inputCheck = true;
                    }
                    else if (input == 7 && playField[2, 0] == '7')
                    {
                        inputCheck = true;
                    }
                    else if (input == 8 && playField[2, 1] == '8')
                    {
                        inputCheck = true;
                    }
                    else if (input == 9 && playField[2, 2] == '9')
                    {
                        inputCheck = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input. Please try another field!");
                    }

                } while (!inputCheck);


            } while (true);
        }

        public static void ResetField()
        {
            playField = playFieldInit;
            setField(); 
        }
        public static void setField()
        {
            Console.WriteLine("        |       |       ");
            Console.WriteLine("   {0}    |    {1}  |    {2}   ", playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("________|_______|_______");
            Console.WriteLine("        |       |       ");
            Console.WriteLine("   {0}    |    {1}  |    {2}   ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("________|_______|_______");
            Console.WriteLine("        |       |       ");
            Console.WriteLine("   {0}    |    {1}  |    {2}   ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("________|_______|_______");

        }

        public static void XorO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
            {
                playerSign = 'X';
            }
            else if (player == 2)
            {
                playerSign = 'O';
            }

            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;


            }

        
        }



    }
}
