using ChessWPF.Common;
using System.Collections.Generic;
using System.Drawing;

namespace ChessWPF.Model
{
    public class Pawn : Pieces
    {
        public Pawn(Color t_color, Point initPos) : base(Constants.PAWN, t_color) 
        {
            this.Curr_Position = initPos;
        }

        public override bool Move(Point pos)
        {
            return base.Move(pos);
        }

        public override Point[] Moveable()
        {
            int moveableCnt = this.Move_Cnt == 0 ? 2 : 1;
            int angle = this.Team_Color == Color.Red ? -1 : 1;

            List<Point> pointList = new List<Point>();

            for(int i = 1; i <= moveableCnt; i++)
            {
                int destPos = this.Y + (i * angle);

                if (0 <= destPos && destPos < Constants.BOARD_COL_CNT)
                {
                    pointList.Add(new Point(this.X, destPos));

                    if(i == 1)
                    {
                        if (0 <= this.X + 1 && this.X + 1 < Constants.BOARD_ROW_CNT) pointList.Add(new Point(this.X + 1, destPos));
                        if (0 <= this.X - 1 && this.X - 1 < Constants.BOARD_ROW_CNT) pointList.Add(new Point(this.X - 1, destPos));
                    }
                }
            }

            return pointList.ToArray();
        }
    }
}
