using ChessGame.BoardFolder;
using ChessGame.BoardFolder.Enums;
using ChessGame.BoardFolder.Exceptions;
using ChessGame.Chess;
using ChessGame.ScreenManipulation;

//
try
{
    ChessGameMechanics chessGameMechanics = new ChessGameMechanics();

    while (!chessGameMechanics.IsMoveFinished)
    {
        try
        {
            // Clear the console and print the board:
            Console.Clear();
            Screen.PrintChessMatch(chessGameMechanics);
            // Console.Clear();
            Console.WriteLine();

            // Ask to type the origin and destiny, and perform the moviments:
            Console.Write("Origin: ");
            Position origin = Screen.ReadPositionOnTheBoard().ToPosition();
            chessGameMechanics.ValidateOriginPosition(origin);

            bool[,] possiblePositions = chessGameMechanics.Board.PiecePosition(origin).PossibleMovements();

            // Clear the console and print the board:
            Console.Clear();
            Screen.PrintBoard(chessGameMechanics.Board, possiblePositions);
            
            Console.WriteLine();
            Console.Write("Destiny: ");
            Position destiny = Screen.ReadPositionOnTheBoard().ToPosition();
            chessGameMechanics.ValidateDestinyPosition(origin, destiny);

            chessGameMechanics.MakeMove(origin, destiny);
        }
        catch (BoardException ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }

        Console.Clear();
        Screen.PrintChessMatch(chessGameMechanics);
    }
}
catch (BoardException ex)
{
    Console.WriteLine(ex.Message);
}


Console.ReadLine();

