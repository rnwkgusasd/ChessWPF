using ChessWPF.Common;
using System.Collections.Generic;
using System.Drawing;

namespace ChessWPF.Model
{
    public class Queen : Pieces
    {
        public Queen(Color t_color, Point initPos) : base(Constants.QUEEN, t_color)
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
                if (i == this.Y) continue;

                pointList.Add(new Point(this.X, i));

            }

            for (int i = 1; i <= Constants.BOARD_ROW_CNT; i++)
            {
                int destX = this.X + i;

                if (Constants.BOARD_ROW_CNT <= destX) break;

                int destY1 = this.Y - i;
                int destY2 = this.Y + i;

                if (0 <= destY1) pointList.Add(new Point(destX, destY1));
                if (destY2 < Constants.BOARD_COL_CNT) pointList.Add(new Point(destX, destY2));
            }

            for (int i = 1; i <= Constants.BOARD_ROW_CNT; i++)
            {
                int destX = this.X - i;

                if (destX < 0) break;

                int destY1 = this.Y - i;
                int destY2 = this.Y + i;

                if (0 <= destY1) pointList.Add(new Point(destX, destY1));
                if (destY2 < Constants.BOARD_COL_CNT) pointList.Add(new Point(destX, destY2));
            }

            return pointList.ToArray();
        }
    }
}
