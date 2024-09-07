using ChessGame.BoardFolder.Enums;

namespace ChessGame.BoardFolder
{
	public abstract class Piece
	{
		public Position? Position { get; set; }
		public Color Color { get; protected set; }
		public int AmountOfMovements { get; protected set; }
		public Board Board { get; protected set; }

        public Piece(Color color, Board board)
        {            
            Color = color;
            Board = board;
            Position = null;
            AmountOfMovements = 0;
        }

        public void IncreasesAmountOfMovements()
        {
            AmountOfMovements++;
        }

        public void DecreasesAmountOfMovements()
        {
            AmountOfMovements--;
        }

        // Will verify if the piece can make the move the player are writing to do:
        public bool IsTheMovementPossible()
        {
            bool[,] matrix = PossibleMovements();

            for (int i = 0; i < Board.Rows; i++)
            {
                for (int j = 0; j < Board.Columns; j++)
                {
                    if (matrix[i, j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool CanMoveToDestiny(Position destiny)
        {
            return PossibleMovements()[destiny.Row, destiny.Column];
        }

        public abstract bool[,] PossibleMovements();
    }
}

