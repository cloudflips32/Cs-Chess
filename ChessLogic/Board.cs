﻿namespace ChessLogic
{
    public class Board
    {
        private readonly Piece[,] pieces = new Piece[8, 8];

        public Piece this[int row, int col]
        {
            get { return pieces[row, col]; }
            set { pieces[row, col] = value; }
        }

        public Piece this[Position pos]
        {
            get { return this[pos.Row, pos.Column]; }
            set { this[pos.Row, pos.Column] = value; }
        }

        public static Board initial()
        {
            Board board = new Board();

            board.AddStartPieces();

            return board;
        }

        private void AddStartPieces()
        {
            this[0,0] = new Rook(Player.Black);
            this[0,1] = new Knight(Player.Black);
            this[0,2] = new Bishop(Player.Black);
            this[0,3] = new Queen(Player.Black);
            this[0,4] = new King(Player.Black);
            this[0,5] = new Bishop(Player.Black);
            this[0,6] = new Knight(Player.Black);
            this[0,7] = new Rook(Player.Black);

            this[7,0] = new Rook(Player.White);
            this[7,1] = new Knight(Player.White);
            this[7,2] = new Bishop(Player.White);
            this[7,3] = new Queen(Player.White);
            this[7,4] = new King(Player.White);
            this[7,5] = new Bishop(Player.White);
            this[7,6] = new Knight(Player.White);
            this[7,7] = new Rook(Player.White);

            int p = 0;
            while(p<8)
            {
                this[1,p] = new Pawn(Player.Black);
                this[6,p] = new Pawn(Player.White);
                p++;
            }
        }
        public static bool isInside(Position pos)
        {
            return pos.Row >= 0 && pos.Row < 8 && pos.Column >= 0 && pos.Column < 8;
        }
        public bool isEmpty(Position pos)
        {
            return this[pos] == null;
        }
    }
}
