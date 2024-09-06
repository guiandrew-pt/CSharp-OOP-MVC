using ChessGame.BoardFolder;
using ChessGame.BoardFolder.Enums;
using ChessGame.BoardFolder.Exceptions;

namespace ChessGame.Chess
{
	public class ChessGameMechanics
	{
        private readonly HashSet<Piece> _pieces;
        private readonly HashSet<Piece> _capturedPieces;

        public Board Board { get; private set; }
        public int Turn { get; private set; }
        public Color CurrentPlayer { get; private set; }
        public bool IsMoveFinished { get; set; }
        public bool Check { get; set; }
        public Piece? VulnerableEnPassant { get; private set; }

        public ChessGameMechanics()
        {
            Turn = 1;
            CurrentPlayer = Color.White;
            Board = new Board(8, 8);
            IsMoveFinished = false;
            Check = false;
            VulnerableEnPassant = null;
            _pieces = new HashSet<Piece>();
            _capturedPieces = new HashSet<Piece>();

            PlacePiecesBoard();
        }

        public Piece? PerformMovement(Position origin, Position destiny)
        {
            Piece? piece = Board.RemovePiece(origin);
            piece?.IncreasesAmountOfMovements();
            Piece? capturedPiece = Board.RemovePiece(destiny);
            Board.PlaceAPiece(piece, destiny);

            if (capturedPiece != null)
            {
                _capturedPieces.Add(capturedPiece);
            }

            // #specialmove (small Castling)
            if (piece is King && destiny.Column == origin.Column + 2)
            {
                Position originRook = new Position(origin.Row, origin.Column + 3);
                Position destinyRook = new Position(origin.Row, origin.Column + 1);

                Piece? rook = Board.RemovePiece(originRook);
                rook.IncreasesAmountOfMovements();
                Board.PlaceAPiece(rook, destinyRook);
            }

            // #specialmove (big Castling)
            if (piece is King && destiny.Column == origin.Column - 2)
            {
                Position originRook = new Position(origin.Row, origin.Column - 4);
                Position destinyRook = new Position(origin.Row, origin.Column - 1);

                Piece? rook = Board.RemovePiece(originRook);
                rook.IncreasesAmountOfMovements();
                Board.PlaceAPiece(rook, destinyRook);
            }

            // #specialmove (En Passant)
            if (piece is Pawn)
            {
                if (origin.Column != destiny.Column && capturedPiece == null)
                {
                    Position positionEnPassant;
                    if (piece.Color == Color.White)
                    {
                        positionEnPassant = new Position(destiny.Row + 1, destiny.Column);
                    }
                    else
                    {
                        positionEnPassant = new Position(destiny.Row - 1, destiny.Column);
                    }

                    capturedPiece = Board.RemovePiece(positionEnPassant);
                    _capturedPieces.Add(capturedPiece);
                }
            }

            return capturedPiece;
        }

        public void UndoTheMovement(Position origin, Position destiny, Piece? capturedPiece)
        {
            Piece? piece = Board.RemovePiece(destiny);
            piece?.DecreasesAmountOfMovements();

            if (capturedPiece != null)
            {
                Board.PlaceAPiece(capturedPiece, destiny);
                _capturedPieces.Remove(capturedPiece);
            }

            Board.PlaceAPiece(piece, origin);

            // #specialmove (small Castling)
            if (piece is King && destiny.Column == origin.Column + 2)
            {
                Position originRook = new Position(origin.Row, origin.Column + 3);
                Position destinyRook = new Position(origin.Row, origin.Column + 1);

                Piece? rook = Board.RemovePiece(destinyRook);
                rook.DecreasesAmountOfMovements();
                Board.PlaceAPiece(rook, originRook);
            }

            // #specialmove (big Castling)
            if (piece is King && destiny.Column == origin.Column - 2)
            {
                Position originRook = new Position(origin.Row, origin.Column - 4);
                Position destinyRook = new Position(origin.Row, origin.Column - 1);

                Piece? rook = Board.RemovePiece(destinyRook);
                rook.DecreasesAmountOfMovements();
                Board.PlaceAPiece(rook, originRook);
            }

            // #specialmoce (En Passant)
            if (piece is Pawn)
            {
                if (origin.Column != destiny.Column && capturedPiece == VulnerableEnPassant)
                {
                    Piece? pawn = Board.RemovePiece(destiny);
                    Position positionEnPassant;

                    if (piece.Color == Color.White)
                    {
                        positionEnPassant = new Position(3, destiny.Column);
                    }
                    else
                    {
                        positionEnPassant = new Position(4, destiny.Column);
                    }

                    Board.PlaceAPiece(pawn, positionEnPassant);
                }
            }
        }

        // Perform the movement, increase the turn, and change the player(color too):
        public void MakeMove(Position origin, Position destiny)
        {
            Piece? capturedPiece = PerformMovement(origin, destiny);

            if (IsKingInCheck(CurrentPlayer))
            {
                UndoTheMovement(origin, destiny, capturedPiece);
                throw new BoardException("You can not put yourself in check!");
            }

            Piece? piece = Board.PiecePosition(destiny);

            // #specialmove (Pawn Promotion)
            if ((piece.Color == Color.White && destiny.Row == 0) || (piece.Color == Color.Black && destiny.Row == 7))
            {
                piece = Board.RemovePiece(destiny);
                _pieces.Remove(piece);

                Piece queen = new Queen(piece.Color, Board);
                Board.PlaceAPiece(queen, destiny);
                _pieces.Add(queen);
            }

            if (IsKingInCheck(FoeColor(CurrentPlayer)))
            {
                Check = true;
            }
            else
            {
                Check = false;
            }

            if (VerifyCheckmate(FoeColor(CurrentPlayer)))
            {
                IsMoveFinished = true;
            }
            else
            {
                Turn++;
                ChangePlayer();
            }

            // #specialmove (En Passant)
            // If in the first time(2 steps) is vulnerable for en passant;
            if (piece is Pawn && (destiny.Row == origin.Row - 2 || destiny.Row == origin.Row + 2))
            {
                VulnerableEnPassant = piece;
            }
            else
            {
                VulnerableEnPassant = null;
            }
        }

        public void ValidateOriginPosition(Position position)
        {
            if (Board.PiecePosition(position) == null)
            {
                throw new BoardException("There is no piece at the chosen position!");
            }

            if (CurrentPlayer != Board.PiecePosition(position).Color)
            {
                throw new BoardException("The origin piece is not yours!");
            }

            if (!Board.PiecePosition(position).IsTheMovementPossible())
            {
                throw new BoardException("There are no possible moves for this origin piece!");
            }
        }

        public void ValidateDestinyPosition(Position origin, Position destiny)
        {
            if (!Board.PiecePosition(origin).CanMoveToDestiny(destiny))
            {
                throw new BoardException("The destiny position is invalid!");
            }
        }

        public void PlaceANewPieceOnBoard(char column, int row, Piece piece)
        {
            Board.PlaceAPiece(piece, new ChessPosition(column, row).ToPosition());

            _pieces.Add(piece);
        }

        public HashSet<Piece> CapturedPiecesMethod(Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();

            foreach (Piece piece in _capturedPieces)
            {
                if (piece.Color == color)
                {
                    aux.Add(piece);
                }
            }

            return aux;
        }

        public HashSet<Piece> PiecesInGame(Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();

            foreach (Piece piece in _pieces)
            {
                if (piece.Color == color)
                {
                    aux.Add(piece);
                }
            }

            aux.ExceptWith(CapturedPiecesMethod(color));

            return aux;
        }

        public bool IsKingInCheck(Color color)
        {
            Piece? king = King(color);

            if (king == null)
            {
                throw new BoardException($"There is no King with color {color} in the board!");
            }

            foreach (Piece piece in PiecesInGame(FoeColor(color)))
            {
                bool[,] matrix = piece.PossibleMovements();

                if (matrix[king.Position.Row, king.Position.Column])
                {
                    return true;
                }
            }

            return false;
        }

        public bool VerifyCheckmate(Color color)
        {
            if (!IsKingInCheck(color))
            {
                return false;
            }

            foreach (Piece piece in PiecesInGame(color))
            {
                bool[,] matrix = piece.PossibleMovements();

                for (int i = 0; i < Board.Rows; i++)
                {
                    for (int j = 0; j < Board.Columns; j++)
                    {
                        if (matrix[i, j]) 
                        {
                            Position origin = piece.Position;
                            Position destiny = new Position(i, j);
                            Piece? capturedPiece = PerformMovement(origin, destiny);

                            bool verifyCheck = IsKingInCheck(color);
                            UndoTheMovement(origin, destiny, capturedPiece);
                            if (!verifyCheck)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }

        private void ChangePlayer()
        {
            if (CurrentPlayer == Color.White)
            {
                CurrentPlayer = Color.Black;
            }
            else
            {
                CurrentPlayer = Color.White;
            }
        }

        private Color FoeColor(Color color)
        {
            if (color == Color.White)
            {
                return Color.Black;
            }
            else
            {
                return Color.White;
            }
        }

        private Piece? King(Color color)
        {
            foreach (Piece piece in PiecesInGame(color))
            {
                if (piece is King)
                {
                    return piece;
                }
            }

            return null;
        }

        /* private void PlacePiecesBoard()
        {
            PlaceANewPieceOnBoard('c', 1, new Rook(Color.White, Board));
            PlaceANewPieceOnBoard('c', 2, new Rook(Color.White, Board));
            PlaceANewPieceOnBoard('d', 2, new Rook(Color.White, Board));
            PlaceANewPieceOnBoard('e', 2, new Rook(Color.White, Board));
            PlaceANewPieceOnBoard('e', 1, new Rook(Color.White, Board));
            PlaceANewPieceOnBoard('d', 1, new King(Color.White, Board));

            PlaceANewPieceOnBoard('c', 7, new Rook(Color.Black, Board));
            PlaceANewPieceOnBoard('c', 8, new Rook(Color.Black, Board));
            PlaceANewPieceOnBoard('d', 7, new Rook(Color.Black, Board));
            PlaceANewPieceOnBoard('e', 7, new Rook(Color.Black, Board));
            PlaceANewPieceOnBoard('e', 8, new Rook(Color.Black, Board));
            PlaceANewPieceOnBoard('d', 8, new King(Color.Black, Board));
        } */

        /* private void PlacePiecesBoard()
        {
            PlaceANewPieceOnBoard('c', 1, new Rook(Color.White, Board));
            PlaceANewPieceOnBoard('d', 1, new King(Color.White, Board));
            PlaceANewPieceOnBoard('h', 7, new Rook(Color.White, Board));

            PlaceANewPieceOnBoard('a', 8, new King(Color.Black, Board));
            PlaceANewPieceOnBoard('b', 8, new Rook(Color.Black, Board));
        } */

        private void PlacePiecesBoard()
        {
            // Whites:
            PlaceANewPieceOnBoard('a', 1, new Rook(Color.White, Board));
            PlaceANewPieceOnBoard('b', 1, new Knight(Color.White, Board));
            PlaceANewPieceOnBoard('c', 1, new Bishop(Color.White, Board));
            PlaceANewPieceOnBoard('d', 1, new Queen(Color.White, Board));
            PlaceANewPieceOnBoard('e', 1, new King(Color.White, Board, this));
            PlaceANewPieceOnBoard('f', 1, new Bishop(Color.White, Board));
            PlaceANewPieceOnBoard('g', 1, new Knight(Color.White, Board));
            PlaceANewPieceOnBoard('h', 1, new Rook(Color.White, Board));

            PlaceANewPieceOnBoard('a', 2, new Pawn(Color.White, Board, this));
            PlaceANewPieceOnBoard('b', 2, new Pawn(Color.White, Board, this));
            PlaceANewPieceOnBoard('c', 2, new Pawn(Color.White, Board, this));
            PlaceANewPieceOnBoard('d', 2, new Pawn(Color.White, Board, this));
            PlaceANewPieceOnBoard('e', 2, new Pawn(Color.White, Board, this));
            PlaceANewPieceOnBoard('f', 2, new Pawn(Color.White, Board, this));
            PlaceANewPieceOnBoard('g', 2, new Pawn(Color.White, Board, this));
            PlaceANewPieceOnBoard('h', 2, new Pawn(Color.White, Board, this));

            // Blacks:
            PlaceANewPieceOnBoard('a', 8, new Rook(Color.Black, Board));
            PlaceANewPieceOnBoard('b', 8, new Knight(Color.Black, Board));
            PlaceANewPieceOnBoard('c', 8, new Bishop(Color.Black, Board));
            PlaceANewPieceOnBoard('d', 8, new Queen(Color.Black, Board));
            PlaceANewPieceOnBoard('e', 8, new King(Color.Black, Board, this));
            PlaceANewPieceOnBoard('f', 8, new Bishop(Color.Black, Board));
            PlaceANewPieceOnBoard('g', 8, new Knight(Color.Black, Board));
            PlaceANewPieceOnBoard('h', 8, new Rook(Color.Black, Board));

            PlaceANewPieceOnBoard('a', 7, new Pawn(Color.Black, Board, this));
            PlaceANewPieceOnBoard('b', 7, new Pawn(Color.Black, Board, this));
            PlaceANewPieceOnBoard('c', 7, new Pawn(Color.Black, Board, this));
            PlaceANewPieceOnBoard('d', 7, new Pawn(Color.Black, Board, this));
            PlaceANewPieceOnBoard('e', 7, new Pawn(Color.Black, Board, this));
            PlaceANewPieceOnBoard('f', 7, new Pawn(Color.Black, Board, this));
            PlaceANewPieceOnBoard('g', 7, new Pawn(Color.Black, Board, this));
            PlaceANewPieceOnBoard('h', 7, new Pawn(Color.Black, Board, this));
        }
    }
}

