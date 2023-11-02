using ChessWPF.Common;
using ChessWPF.Control;
using ChessWPF.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChessWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] btn = new Button[8, 8];

        int prevX = 0;
        int prevY = 0;

        public MainWindow()
        {
            InitializeComponent();

            gm.InitGame();

            for (int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    Button tBtn = new Button()
                    {
                        Background = Brushes.White,
                        Width = 80,
                        Height = 80,
                        Margin = new Thickness(j * 80, i * 80, 0, 0),
                        HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top,
                    };

                    //tBtn.Click += BtnEvent;

                    tBtn.Click += (sender, e) =>
                    {
                        Button t = sender as Button;

                        prevX = (int)(t.Margin.Left / 80);
                        prevY = (int)(t.Margin.Top / 80);

                        BtnEvent(prevX, prevY);

                        btn[prevY, prevX].Background = Brushes.Blue;
                    };

                    btn[i, j] = tBtn;

                    mainGrid.Children.Add(tBtn);
                }
            }
        }

        bool _doing = false;

        Game gm = new Game();

        public void BtnEvent(int x, int y)
        {
            Pieces? t = gm._bm.GetPiece(new System.Drawing.Point(x, y));

            if(t != null)
            {
                System.Drawing.Point[] t2 = new System.Drawing.Point[0];

                switch (t.Name)
                {
                    case Constants.PAWN:
                        t2 = (t as Pawn).Moveable();
                        break;

                    case Constants.ROOK:
                        t2 = (t as Rook).Moveable();
                        break;

                    case Constants.KNIGHT:
                        t2 = (t as Knight).Moveable();
                        break;

                    case Constants.BISHOP:
                        t2 = (t as Bishop).Moveable();
                        break;

                    case Constants.QUEEN:
                        t2 = (t as Queen).Moveable();
                        break;

                    case Constants.KING:
                        t2 = (t as King).Moveable();
                        break;
                }


                for(int i = 0; i < t2.Length; i++)
                {
                    btn[t2[i].Y, t2[i].X].Background = Brushes.Red;
                }
            }
        }
    }
}
