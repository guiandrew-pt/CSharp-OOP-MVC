using ChessGame.BoardFolder;

namespace ChessGame.Chess
{
	public class ChessPosition
	{
		public char Column { get; set; }
		public int Row { get; set; }

        public ChessPosition(char column, int row)
        {
            Column = column;
            Row = row;
        }

        // Convert the coordinate to a board position:
        public Position ToPosition()
        {
            return new Position(8 - Row, Column - 'a');
        }

        public override string ToString()
        {
            return $"{Column}{Row}";
        }
    }
}

