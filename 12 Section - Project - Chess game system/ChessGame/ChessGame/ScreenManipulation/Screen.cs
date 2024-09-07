using ChessGame.BoardFolder;
using ChessGame.BoardFolder.Enums;
using ChessGame.Chess;

namespace ChessGame.ScreenManipulation
{
	public class Screen
	{
		public static void PrintBoard(Board board)
		{
			for (int i = 0; i < board.Rows; i++)
			{
				Console.Write($"{8 - i} ");

				for (int j = 0; j < board.Columns; j++)
				{
                    PrintPiece(board.PiecePosition(i, j));
				}

				Console.WriteLine();
			}

			Console.WriteLine("  a b c d e f g h");
		}

        public static void PrintBoard(Board board, bool[,] possiblePositions)
        {
            ConsoleColor backgroundOrigin = Console.BackgroundColor;
            ConsoleColor backgroundwithPossiblePositions = ConsoleColor.DarkGray;

            for (int i = 0; i < board.Rows; i++)
            {
                Console.Write($"{8 - i} ");

                for (int j = 0; j < board.Columns; j++)
                {
                    if (possiblePositions[i, j])
                    {
                        Console.BackgroundColor = backgroundwithPossiblePositions;
                    }
                    else
                    {
                        Console.BackgroundColor = backgroundOrigin;
                    }

                    PrintPiece(board.PiecePosition(i, j));
                    Console.BackgroundColor = backgroundOrigin;
                }

                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = backgroundOrigin;
        }

        public static ChessPosition ReadPositionOnTheBoard()
		{
			string? positionStr = Console.ReadLine();

			char column = positionStr[0];
			int row = Convert.ToInt16($"{positionStr[1]}");
			return new ChessPosition(column, row);
		}

        public static void PrintPiece(Piece piece)
        {
			if (piece == null)
			{
                Console.Write("- ");
            }
			else
			{
                if (piece.Color == Color.White)
                {
                    Console.Write(piece);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(piece);
                    Console.ForegroundColor = aux;
                }

                Console.Write(" ");
            }
        }

        public static void PrintChessMatch(ChessGameMechanics chessGameMechanics)
        {
            PrintBoard(chessGameMechanics.Board);

            Console.WriteLine();

            PrintCapturedPieces(chessGameMechanics);

            Console.WriteLine();
            Console.WriteLine($"Turn: {chessGameMechanics.Turn}");

            if (!chessGameMechanics.IsMoveFinished)
            {
                Console.WriteLine($"Wait for the move: {chessGameMechanics.CurrentPlayer}");

                if (chessGameMechanics.Check)
                {
                    Console.WriteLine("CHECK!");
                }
            }
            else
            {
                Console.WriteLine("CHECKMATE!");
                Console.WriteLine($"Winner: {chessGameMechanics.CurrentPlayer}!");
            }
        }

        public static void PrintCapturedPieces(ChessGameMechanics chessGameMechanics)
        {
            Console.WriteLine("Captured Pieces:");

            Console.Write("Whites: ");
            PrintHash(chessGameMechanics.CapturedPiecesMethod(Color.White));

            Console.WriteLine();

            Console.Write("Blacks: ");

            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintHash(chessGameMechanics.CapturedPiecesMethod(Color.Black));
            Console.ForegroundColor = aux;

            Console.WriteLine();
        }

        public static void PrintHash(HashSet<Piece> pieces)
        {
            Console.Write("[");
            foreach (Piece piece in pieces)
            {
                Console.Write($"{piece} ");
            }
            Console.Write("]");
        }
    }
}

