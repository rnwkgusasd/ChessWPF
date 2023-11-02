using ChessWPF.Common;
using System.Collections.Generic;
using System.Drawing;

namespace ChessWPF.Model
{
    public class King : Pieces
    {
        public King(Color t_color, Point initPos) : base(Constants.KING, t_color)
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

            int destX = this.X + 1;

            if (destX < Constants.BOARD_ROW_CNT)
            {
                int destY1 = this.Y - 1;
                int destY2 = this.Y + 1;

                if (0 <= destY1) pointList.Add(new Point(destX, destY1));
                if (destY2 < Constants.BOARD_COL_CNT)
                {
                    // diagonal line
                    pointList.Add(new Point(destX, destY2));

                    // vertial, horizontal line
                    pointList.Add(new Point(this.X + 1, this.Y));
                    pointList.Add(new Point(this.X, this.Y + 1));
                }
            }

            int destX2 = this.X - 1;

            if (0 <= destX2)
            {
                int destY1 = this.Y - 1;
                int destY2 = this.Y + 1;

                if (0 <= destY1)
                {
                    // diagonal line
                    pointList.Add(new Point(destX2, destY1));

                    // vertial, horizontal line
                    pointList.Add(new Point(this.X - 1, this.Y));
                    pointList.Add(new Point(this.X, this.Y - 1));
                }
                if (destY2 < Constants.BOARD_COL_CNT) pointList.Add(new Point(destX2, destY2));
            }

            return pointList.ToArray();
        }
    }
}
