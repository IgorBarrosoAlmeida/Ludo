using System;

namespace Ludo
{
    class Game
    {
        // Atributos
        static private Player[] Players;
        static private Square[,] Map;
        static private int nPlayers;
        //static private string[] colors;


        static void Main(string[] args)
        {
            string[] colors = {"Red", "Blue", "Yellow", "Green"};

            // Inicializa os jogadores
            do
            {
                Console.WriteLine("Number of players (between 2 and 4): ");
                nPlayers = int.Parse(Console.ReadLine());
                if(nPlayers > 4 || nPlayers < 2)
                {
                    Console.WriteLine("Invalid number of players (must be between 2 and 4)!");
                }

            } while (nPlayers > 4 || nPlayers < 2);
            
            Players = new Player[nPlayers];
            for (int i = 0; i < nPlayers; i++)
            {
                Players[i] = new Player(i, colors[i]);
            }

            // Inicializa o mapa
            Map = new Square[15, 15];

            bool isOutOfMap;
            for (int i = 0; i < 15; i++)
            {
                for(int j = 0; j < 15; j++)
                {
                    //out:
                    // [0,0] --> [5,5]
                    // [0,9] --> [5,14]
                    // [9,0] --> [14,5]
                    // [9,9] --> [14,14]
                    // square [6,6], [6,8], [8,6], [8,8]
                    isOutOfMap = (i > 0 && i <= 5) && (j > 0 && j <= 5);
                    isOutOfMap = isOutOfMap || (i > 0 && i <= 5) && (j > 9 && j <= 14);
                    isOutOfMap = isOutOfMap || (i > 9 && i <= 14) && (j > 0 && j <= 5);
                    isOutOfMap = isOutOfMap || (i > 9 && i <= 14) && (i > 9 && i <= 14);
                    isOutOfMap = isOutOfMap || (i == 6 && j == 6) || (i == 6 && j == 8) || (i == 8 && j == 6) || (i == 8 && j == 8);

                    if (isOutOfMap)
                    {
                        Map[i, j] = new Square(0);
                    }
                }
            }
        }
    }


}


/*
 Ideia:
Quando o peao for mexer ele vai reconhecer o tipo dos 4 quadrados ao redor dele, assim ele saberá para onde se mover
O movimento do peao se da de uma em uma casa e ele realiza esse reconhecimento a cada casa (mas o reconhecimento pode ser feito de maneira
O peao se move para onde ele reconheceu que deve se mover de casa em casa e quando 
*/