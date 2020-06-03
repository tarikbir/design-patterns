using System;

namespace SimpleGame.Classes
{
    struct Position
    {
        int x;
        int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Position(Position pos)
        {
            x = pos.x;
            y = pos.y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   x == position.x &&
                   y == position.y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }
    }
}
