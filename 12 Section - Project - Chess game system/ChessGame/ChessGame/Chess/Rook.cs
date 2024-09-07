using ChessGame.BoardFolder;
using ChessGame.BoardFolder.Enums;

namespace ChessGame.Chess
{
    public class Rook : Piece
    {
        public Rook(Color color, Board board) : base(color, board)
        {

        }

        public override bool[,] PossibleMovements()
        {
            bool[,] matrix = new bool[Board.Rows, Board.Columns];

            Position position = new Position(0, 0);

            // Up(North)
            position.ValuesPosition(Position.Row - 1, Position.Column);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
                if (Board.PiecePosition(position) != null && Board.PiecePosition(position)?.Color != Color)
                {
                    break;
                }

                position.Row--;
            }

            // Down(South)
            position.ValuesPosition(Position.Row + 1, Position.Column);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
                if (Board.PiecePosition(position) != null && Board.PiecePosition(position)?.Color != Color)
                {
                    break;
                }

                position.Row++;
            }

            // Right (East)
            position.ValuesPosition(Position.Row, Position.Column + 1);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
                if (Board.PiecePosition(position) != null && Board.PiecePosition(position)?.Color != Color)
                {
                    break;
                }

                position.Column++;
            }

            // Left (West)
            position.ValuesPosition(Position.Row, Position.Column - 1);
            while (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
                if (Board.PiecePosition(position) != null && Board.PiecePosition(position)?.Color != Color)
                {
                    break;
                }

                position.Column--;
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
            return $"R";
        }
    }
}

