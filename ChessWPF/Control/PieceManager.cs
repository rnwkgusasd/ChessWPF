using ChessWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWPF.Control
{
    public class PieceManager
    {
        public PieceManager() { }

        public List<Pieces> _pieces_R = new List<Pieces>();
        public List<Pieces> _pieces_B = new List<Pieces>();

        public void InitPieces()
        {
            _pieces_R.Clear();
            _pieces_B.Clear();

            // Add Pawn
            for(int i = 0; i < 8; i++)
            {
                _pieces_R.Add(new Pawn(System.Drawing.Color.Red, new System.Drawing.Point(i, 6)));
                _pieces_B.Add(new Pawn(System.Drawing.Color.Blue, new System.Drawing.Point(i, 1)));
            }

            // Add Rook
            // Red
            _pieces_R.Add(new Rook(System.Drawing.Color.Red, new System.Drawing.Point(0, 7)));
            _pieces_R.Add(new Rook(System.Drawing.Color.Red, new System.Drawing.Point(7, 7)));
            // Blue
            _pieces_B.Add(new Rook(System.Drawing.Color.Blue, new System.Drawing.Point(0, 0)));
            _pieces_B.Add(new Rook(System.Drawing.Color.Blue, new System.Drawing.Point(7, 0)));

            // Add Knight
            // Red
            _pieces_R.Add(new Knight(System.Drawing.Color.Red, new System.Drawing.Point(1, 7)));
            _pieces_R.Add(new Knight(System.Drawing.Color.Red, new System.Drawing.Point(6, 7)));
            // Blue
            _pieces_B.Add(new Knight(System.Drawing.Color.Blue, new System.Drawing.Point(1, 0)));
            _pieces_B.Add(new Knight(System.Drawing.Color.Blue, new System.Drawing.Point(6, 0)));

            // Add Bishop
            // Red
            _pieces_R.Add(new Bishop(System.Drawing.Color.Red, new System.Drawing.Point(2, 7)));
            _pieces_R.Add(new Bishop(System.Drawing.Color.Red, new System.Drawing.Point(5, 7)));
            // Blue
            _pieces_B.Add(new Bishop(System.Drawing.Color.Blue, new System.Drawing.Point(2, 0)));
            _pieces_B.Add(new Bishop(System.Drawing.Color.Blue, new System.Drawing.Point(5, 0)));

            // Add Queen, King
            // Red
            _pieces_R.Add(new Queen(System.Drawing.Color.Red, new System.Drawing.Point(3, 7)));
            _pieces_R.Add(new King(System.Drawing.Color.Red, new System.Drawing.Point(4, 7)));
            // Blue
            _pieces_B.Add(new Queen(System.Drawing.Color.Blue, new System.Drawing.Point(3, 0)));
            _pieces_B.Add(new King(System.Drawing.Color.Blue, new System.Drawing.Point(4, 0)));
        }
    }
}
