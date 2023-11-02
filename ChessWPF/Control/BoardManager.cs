using ChessWPF.Common;
using ChessWPF.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWPF.Control
{
    public class BoardManager
    {
        public BoardManager() { }

        private Tile[,] _board = new Tile[Constants.BOARD_COL_CNT, Constants.BOARD_ROW_CNT];

        public void InitBoard()
        {
            _board = new Tile[Constants.BOARD_COL_CNT, Constants.BOARD_ROW_CNT];
        }

        public void InitBoard(Pieces[] list)
        {
            _board = new Tile[Constants.BOARD_COL_CNT, Constants.BOARD_ROW_CNT];

            for(int i = 0; i < list.Length; i++)
            {
                _board[list[i].Y, list[i].X] = new Tile(list[i]);
            }
        }

        public Pieces? GetPiece(Point pos)
        {
            return _board[pos.Y, pos.X] == null ? null : _board[pos.Y, pos.X].Curr_Piece;
        }

        public bool Move(Pieces piece, Point destPos)
        {
            Point pieceCurrPos = piece.Curr_Position;

            Pieces? inTile = _board[pieceCurrPos.Y, pieceCurrPos.X].Curr_Piece;

            if (inTile == null) return false;

            piece.Move(destPos);

            _board[destPos.Y, destPos.X].Curr_Piece = piece;
            _board[pieceCurrPos.Y, pieceCurrPos.X].Curr_Piece = null;

            return true;
        }
    }

    public class Tile
    {
        public Tile(Pieces? curr_Piece)
        {
            Curr_Piece = curr_Piece;
        }

        public Pieces? Curr_Piece { get; set; }
    }
}
