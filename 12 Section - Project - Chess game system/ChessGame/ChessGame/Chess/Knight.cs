using ChessGame.BoardFolder;
using ChessGame.BoardFolder.Enums;

namespace ChessGame.Chess
{
    public class Knight : Piece
    {
        public Knight(Color color, Board board) : base(color, board)
        {

        }

        public override bool[,] PossibleMovements()
        {
            bool[,] matrix = new bool[Board.Rows, Board.Columns];

            Position position = new Position(0, 0);

            position.ValuesPosition(Position.Row - 1, Position.Column - 2);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            position.ValuesPosition(Position.Row - 2, Position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            position.ValuesPosition(Position.Row - 2, Position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            position.ValuesPosition(Position.Row - 1, Position.Column + 2);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            position.ValuesPosition(Position.Row + 1, Position.Column + 2);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            position.ValuesPosition(Position.Row + 2, Position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            position.ValuesPosition(Position.Row + 2, Position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            position.ValuesPosition(Position.Row + 1, Position.Column - 2);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
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
            return $"N";
        }
    }
}

