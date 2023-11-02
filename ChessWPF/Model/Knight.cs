using ChessWPF.Common;
using System.Collections.Generic;
using System.Drawing;

namespace ChessWPF.Model
{
    public class Knight : Pieces
    {
        public Knight(Color t_color, Point initPos) : base(Constants.KNIGHT, t_color)
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

            int xp = this.X + 2;
            int xm = this.X - 2;
            int yp = this.Y + 2;
            int ym = this.Y - 2;

            if(xp < Constants.BOARD_COL_CNT)
            {
                int dest1 = this.Y - 1;
                int dest2 = this.Y + 1;

                if (0 <= dest1) pointList.Add(new Point(xp, dest1));
                if (dest2 < Constants.BOARD_COL_CNT) pointList.Add(new Point(xp, dest2));
            }

            if (xm >= 0)
            {
                int dest1 = this.Y - 1;
                int dest2 = this.Y + 1;

                if (0 <= dest1) pointList.Add(new Point(xm, dest1));
                if (dest2 < Constants.BOARD_COL_CNT) pointList.Add(new Point(xm, dest2));
            }

            if (yp < Constants.BOARD_ROW_CNT)
            {
                int dest1 = this.X - 1;
                int dest2 = this.X + 1;

                if (0 <= dest1) pointList.Add(new Point(dest1, yp));
                if (dest2 < Constants.BOARD_COL_CNT) pointList.Add(new Point(dest2, yp));
            }

            if (ym >= 0)
            {
                int dest1 = this.X - 1;
                int dest2 = this.X + 1;

                if (0 <= dest1) pointList.Add(new Point(dest1, ym));
                if (dest2 < Constants.BOARD_COL_CNT) pointList.Add(new Point(dest2, ym));
            }

            return pointList.ToArray();
        }
    }
}
