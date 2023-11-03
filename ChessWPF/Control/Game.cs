using ChessWPF.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWPF.Control
{
    public class Game
    {
        public Game() { }

        public BoardManager _bm = new BoardManager();
        public PieceManager _pm = new PieceManager();

        public void InitGame()
        {
            _pm.InitPieces();
            _bm.InitBoard(_pm._pieces_R.Concat(_pm._pieces_B).ToArray());
        }

        public void Move(Pieces pic, Point dest)
        {
            if (pic != null)
            {
                _bm.Move(pic, dest);
            }
        }
    }
}
