using ChessGame.BoardFolder;
using ChessGame.BoardFolder.Enums;

namespace ChessGame.Chess
{
	public class Bishop : Piece
    {
        public Bishop(Color color, Board board) : base(color, board)
        {

        }

        public override bool[,] PossibleMovements()
        {
            bool[,] matrix = new bool[Board.Rows, Board.Columns];

            Position position = new Position(0, 0);

            // Northwest
            position.ValuesPosition(Position.Row - 1, Position.Column - 1);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
                if (Board.PiecePosition(position) != null && Board.PiecePosition(position)?.Color != Color)
                {
                    break;
                }

                position.ValuesPosition(position.Row -1, position.Column - 1);
            }

            // Northeast
            position.ValuesPosition(Position.Row - 1, Position.Column + 1);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
                if (Board.PiecePosition(position) != null && Board.PiecePosition(position)?.Color != Color)
                {
                    break;
                }

                position.ValuesPosition(position.Row - 1, position.Column + 1);
            }

            // South-east
            position.ValuesPosition(Position.Row + 1, Position.Column + 1);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
                if (Board.PiecePosition(position) != null && Board.PiecePosition(position)?.Color != Color)
                {
                    break;
                }

                position.ValuesPosition(position.Row + 1, position.Column + 1);
            }

            // South-west
            position.ValuesPosition(Position.Row + 1, Position.Column - 1);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
                if (Board.PiecePosition(position) != null && Board.PiecePosition(position)?.Color != Color)
                {
                    break;
                }

                position.ValuesPosition(position.Row + 1, position.Column - 1);
            }

            return matrix;
        }

        private bool CanMove(Position position)
        {
            Piece? piece = Board.PiecePosition(position);
            return piece == null || piece.Color != Color;
        }

        public override string ToString()
        {
            return $"B";
        }
    }
}

