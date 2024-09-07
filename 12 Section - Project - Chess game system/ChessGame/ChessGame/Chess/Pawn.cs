using ChessGame.BoardFolder;
using ChessGame.BoardFolder.Enums;

namespace ChessGame.Chess
{
    public class Pawn : Piece
    {
        private ChessGameMechanics _chessGameMechanics;

        public Pawn(Color color, Board board, ChessGameMechanics chessGameMechanics) : base(color, board)
        {
            _chessGameMechanics = chessGameMechanics;
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] matrix = new bool[Board.Rows, Board.Columns];

            Position position = new Position(0, 0);

            if (Color == Color.White) // White
            {
                // UP
                position.ValuesPosition(Position.Row - 1, Position.Column);
                if (Board.ValidPosition(position) && IsPositionFree(position))
                {
                    matrix[position.Row, position.Column] = true;
                }

                // Two steps UP (First movement)
                position.ValuesPosition(Position.Row - 2, Position.Column);
                if (Board.ValidPosition(position) && IsPositionFree(position) && AmountOfMovements == 0)
                {
                    matrix[position.Row, position.Column] = true;
                }

                // Diagonal (if foe exist)
                position.ValuesPosition(Position.Row - 1, Position.Column - 1);
                if (Board.ValidPosition(position) && ExistFoe(position))
                {
                    matrix[position.Row, position.Column] = true;
                }

                // Diagonal (if foe exist)
                position.ValuesPosition(Position.Row - 1, Position.Column + 1);
                if (Board.ValidPosition(position) && ExistFoe(position))
                {
                    matrix[position.Row, position.Column] = true;
                }

                // #specialmove (En Passant)
                // En passant only possible at row 3;
                if (Position.Row == 3)
                {
                    Position left = new Position(Position.Row, Position.Column - 1);
                    if (Board.ValidPosition(left) && ExistFoe(left) && Board.PiecePosition(left) == _chessGameMechanics.VulnerableEnPassant)
                    {
                        matrix[left.Row - 1, left.Column] = true;
                    }

                    Position right = new Position(Position.Row, Position.Column + 1);
                    if (Board.ValidPosition(right) && ExistFoe(right) && Board.PiecePosition(right) == _chessGameMechanics.VulnerableEnPassant)
                    {
                        matrix[right.Row - 1, right.Column] = true;
                    }
                }
            }
            else // Black
            {
                // UP
                position.ValuesPosition(Position.Row + 1, Position.Column);
                if (Board.ValidPosition(position) && IsPositionFree(position))
                {
                    matrix[position.Row, position.Column] = true;
                }

                // Two steps UP (First movement)
                position.ValuesPosition(Position.Row + 2, Position.Column);
                if (Board.ValidPosition(position) && IsPositionFree(position) && AmountOfMovements == 0)
                {
                    matrix[position.Row, position.Column] = true;
                }

                // Diagonal (if foe exist)
                position.ValuesPosition(Position.Row + 1, Position.Column - 1);
                if (Board.ValidPosition(position) && ExistFoe(position))
                {
                    matrix[position.Row, position.Column] = true;
                }

                // Diagonal (if foe exist)
                position.ValuesPosition(Position.Row + 1, Position.Column + 1);
                if (Board.ValidPosition(position) && ExistFoe(position))
                {
                    matrix[position.Row, position.Column] = true;
                }

                // #specialmove (En Passant)
                // En passant only possible at row 4;
                if (Position.Row == 4)
                {
                    Position left = new Position(Position.Row, Position.Column - 1);
                    if (Board.ValidPosition(left) && ExistFoe(left) && Board.PiecePosition(left) == _chessGameMechanics.VulnerableEnPassant)
                    {
                        matrix[left.Row + 1, left.Column] = true;
                    }

                    Position right = new Position(Position.Row, Position.Column + 1);
                    if (Board.ValidPosition(right) && ExistFoe(right) && Board.PiecePosition(right) == _chessGameMechanics.VulnerableEnPassant)
                    {
                        matrix[right.Row + 1, right.Column] = true;
                    }
                }
            }

            return matrix;
        }

        private bool IsPositionFree(Position position)
        {
            return Board.PiecePosition(position) == null;
        }

        private bool ExistFoe(Position position)
        {
            Piece? piece = Board.PiecePosition(position);
            return piece != null && piece.Color != Color;
        }

        public override string ToString()
        {
            return $"P";
        }
    }
}

