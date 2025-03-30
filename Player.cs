using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
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
            for (int i = 0; i < 4; i++)
            {
                Pawns[i] = new Pawn(i, color);
            }
        }
    }
}
