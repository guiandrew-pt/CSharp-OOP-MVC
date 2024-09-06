using ChessGame.BoardFolder.Exceptions;

namespace ChessGame.BoardFolder
{
	public class Board
	{
		public int Rows { get; set; }
		public int Columns { get; set; }
        private readonly Piece?[,] Pieces;

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Pieces = new Piece[rows, columns];
        }

        public Piece? PiecePosition(int row, int colum)
        {
            return Pieces[row, colum];
        }

        public Piece? PiecePosition(Position position)
        {
            return Pieces[position.Row, position.Column];
        }

        // Will test if the piece exist in a given position:
        public bool PieceExist(Position position)
        {
            ValidatePosition(position);
            return PiecePosition(position) != null;
        }

        // Will add the piece in the board:
        public void PlaceAPiece(Piece piece, Position position)
        {
            if (PieceExist(position))
            {
                throw new BoardException("There is already a piece in that position!");
            }

            Pieces[position.Row, position.Column] = piece; // set the position in the board, with a piece;
            piece.Position = position; // Set the piece to "position"(argument) position;
        }

        // Will remove the piece from the board:
        public Piece? RemovePiece(Position position)
        {
            if (PiecePosition(position) == null)
            {
                return null;
            }

            Piece? aux = PiecePosition(position);
            aux.Position = null;
            Pieces[position.Row, position.Column] = null;
            return aux;
        }

        public bool ValidPosition(Position position)
        {
            if (position.Row < 0 || position.Row >= Rows || position.Column < 0 || position.Column >= Columns)
            {
                return false;
            }

            return true;
        }

        public void ValidatePosition(Position position)
        {
            if (!ValidPosition(position))
            {
                throw new BoardException("Invalid position!");
            }
        }
    }
}

