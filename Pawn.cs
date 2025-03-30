using System;

namespace Ludo
{
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
