using ChessGame.BoardFolder;
using ChessGame.BoardFolder.Enums;

namespace ChessGame.Chess
{
    public class King : Piece
    {
        private ChessGameMechanics _chessGameMechanics;

        public King(Color color, Board board, ChessGameMechanics chessGameMechanics) : base(color, board)
        {
            _chessGameMechanics = chessGameMechanics;
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] matrix = new bool[Board.Rows, Board.Columns];

            Position position = new Position(0, 0);

            // Up(North)
            position.ValuesPosition(Position.Row - 1, Position.Column);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            // Northeast
            position.ValuesPosition(Position.Row - 1, Position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            // Right (East)
            position.ValuesPosition(Position.Row, Position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            // South-east
            position.ValuesPosition(Position.Row + 1, Position.Column + 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            // Down (South)
            position.ValuesPosition(Position.Row + 1, Position.Column);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            // South-west
            position.ValuesPosition(Position.Row + 1, Position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            // Left (West)
            position.ValuesPosition(Position.Row, Position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            // Northwest
            position.ValuesPosition(Position.Row - 1, Position.Column - 1);
            if (Board.ValidPosition(position) && CanMove(position))
            {
                matrix[position.Row, position.Column] = true;
            }

            // #specialmove (Castling)
            if (AmountOfMovements == 0 && !_chessGameMechanics.Check)
            {
                // #specialmove (small Castling)
                Position positionSmallCastling = new Position(Position.Row, Position.Column + 3);
                if (VerifyRookToCastling(positionSmallCastling))
                {
                    Position positionFirst = new Position(Position.Row, Position.Column + 1);
                    Position positionSecond = new Position(Position.Row, Position.Column + 2);

                    if (Board.PiecePosition(positionFirst) == null && Board.PiecePosition(positionSecond) == null)
                    {
                        matrix[Position.Row, Position.Column + 2] = true;
                    }
                }

                // #specialmove (big Castling)
                Position positionBigCastling = new Position(Position.Row, Position.Column - 4);
                if (VerifyRookToCastling(positionBigCastling))
                {
                    Position positionFirst = new Position(Position.Row, Position.Column - 1);
                    Position positionSecond = new Position(Position.Row, Position.Column - 2);
                    Position positionThird = new Position(Position.Row, Position.Column - 3);

                    if (Board.PiecePosition(positionFirst) == null && Board.PiecePosition(positionSecond) == null && Board.PiecePosition(positionThird) == null)
                    {
                        matrix[Position.Row, Position.Column - 2] = true;
                    }
                } 
            }

            return matrix;
        }

        private bool VerifyRookToCastling(Position position)
        {
            Piece? piece = Board.PiecePosition(position);

            return piece != null && piece is Rook && piece.Color == Color && piece.AmountOfMovements == 0;
        }

        private bool CanMove(Position position)
        {
            Piece? piece = Board.PiecePosition(position);
            return piece == null || piece.Color != Color;
        }

        public override string ToString()
        {
            return $"K";
        }
    }
}

