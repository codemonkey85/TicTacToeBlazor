namespace TicTacToeBlazor.Components;

public partial class TicTacToeGame4x4
{
    private const string X = nameof(X);
    private const string O = nameof(O);
    private string currentTurn = O;
    private int numberOfTurns = 0;
    private bool isGameOver = false;
    private bool isGameTied = false;
    private string info = $"{O} goes first";
    private readonly IDictionary<int, string> squares = new Dictionary<int, string>
    {
        [0] = string.Empty,
        [1] = string.Empty,
        [2] = string.Empty,
        [3] = string.Empty,
        [4] = string.Empty,
        [5] = string.Empty,
        [6] = string.Empty,
        [7] = string.Empty,
        [8] = string.Empty,
        [9] = string.Empty,
        [10] = string.Empty,
        [11] = string.Empty,
        [12] = string.Empty,
        [13] = string.Empty,
        [14] = string.Empty,
        [15] = string.Empty,
    };
    private readonly int[][] winningCombos = new int[][]
    {
        new int[] { 0, 1, 2, 3 },
        new int[] { 4, 5, 6, 7 },
        new int[] { 8, 9, 10, 11 },
        new int[] { 12, 13, 14, 15 },
        new int[] { 0, 4, 8, 12 },
        new int[] { 1, 5, 9, 13 },
        new int[] { 2, 6, 10, 14 },
        new int[] { 3, 7, 11, 15 },
        new int[] { 0, 5, 10, 15 },
        new int[] { 3, 6, 9, 12 },
    };

    private void TakeTurn(int id)
    {
        if (isGameOver || !string.IsNullOrEmpty(squares[id]))
        {
            return;
        }

        squares[id] = currentTurn;
        numberOfTurns++;

        CheckIfGameIsOver();

        if (isGameOver && !isGameTied)
        {
            info = $"The winner is {currentTurn}!";
        }
        else if (isGameTied)
        {
            info = "The game is tied!";
        }
        else
        {
            currentTurn = currentTurn is X ? O : X;
            info = $"It is now {currentTurn}'s turn";
        }
    }

    private void CheckIfGameIsOver()
    {
        foreach (var combo in winningCombos)
        {
            var marks = combo.Select(i => squares[i]);
            if (marks.All(m => m is X) || marks.All(m => m is O))
            {
                isGameOver = true;
                return;
            }
        }
        if (squares.Values.All(mark => mark is { Length: > 0 }))
        {
            isGameTied = true;
            isGameOver = true;
        }
    }

    private void ResetBoard()
    {
        currentTurn = O;
        numberOfTurns = 0;
        for (var i = 0; i < 15; i++)
        {
            squares[i] = string.Empty;
        }
        isGameOver = false;
        isGameTied = false;
        info = $"{O} goes first";
    }
}
