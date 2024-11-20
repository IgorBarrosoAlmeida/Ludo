using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //out:
            //[0,0] --> [5,5]
            //[0,9] --> [5,14]
            //[9,0] --> [14,5]
            //[9,9] --> [14,14]
            for (int i = 0; i < 15; i++)
            {
                for(int j = 0; j < 15; j++)
                {

                }
            }
        }
    }

    class Square
    {
        /*
        0 - Out of map
        1 - Normal squares
        2 - Final squares
        */
        private int type;
        private int number;
    }

    class Player
    {
        // Atributos
        private int Id;
        private string Color;
        private Pawn[] Pawns;

        // Getters and Setters
        public int _Id { get { return Id; } set { Id = value; } }
        public string _Color { get { return Color; } set { Color = value; } }

        // Construtor
        public Player(int id, string color)
        {
            Id = id;
            Color = color;

            Pawns = new Pawn[4];
            for(int i = 0; i < 4; i++)
            {
                Pawns[i] = new Pawn(i, color);
            }
        }
    }

    class Pawn
    {
        // Atributos
        private int Id;
        private Square PawnPosition;
        private string Color;
        private bool IsInGame;

        // Getters and Setters
        public int _Id { get { return Id; } set { Id = value; } }
        public string _Color { get { return Color; } set { Color = value; } }

        // Construtor 
        public Pawn(int id, string color)
        {
            Id = id;
            Color = color;
            IsInGame = false;
        }
    }
}
