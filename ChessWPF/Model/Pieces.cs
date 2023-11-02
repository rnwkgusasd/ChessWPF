using System.Drawing;

namespace ChessWPF.Model
{
    public interface IPieces
    {
        bool Move(Point pos);
        Point[] Moveable();
    }
    
    public class Pieces : IPieces
    {
        public string Name { get; }
        public int Move_Cnt { get; set; }
        public Point Curr_Position { get; set; }
        public Point Prev_Position { get; set; }
        public Color Team_Color { get; }

        public int X { get => Curr_Position.X; }
        public int Y { get => Curr_Position.Y; }

        public Pieces(string name, Color t_color)
        {
            Name = name;
            Team_Color = t_color;
            Move_Cnt = 0;
            Curr_Position = new Point(0, 0);
            Prev_Position = new Point(0, 0);
        }

        public virtual bool Move(Point pos) { Move_Cnt++;  Curr_Position = pos;  return true; }

        public virtual Point[] Moveable() { return new Point[0]; }
    }
}
