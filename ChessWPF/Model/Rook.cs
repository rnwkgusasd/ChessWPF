using ChessWPF.Common;
using System.Collections.Generic;
using System.Drawing;

namespace ChessWPF.Model
{
    public class Rook : Pieces
    {
        public Rook(Color t_color, Point initPos) : base(Constants.ROOK, t_color)
        {
            this.Curr_Position = initPos;
        }

        public override bool Move(Point pos)
        {
            return base.Move(pos);
        }

        public override Point[] Moveable()
        {
            List<Point> pointList = new List<Point>();

            for (int i = 0; i < Constants.BOARD_ROW_CNT; i++)
            {
                if (i == this.X) continue;

                pointList.Add(new Point(i, this.Y));
            }

            for (int i = 0; i < Constants.BOARD_COL_CNT; i++)
            {
                if(i == this.Y) continue;

                pointList.Add(new Point(this.X, i));

            }

            return pointList.ToArray();
        }
    }
}
