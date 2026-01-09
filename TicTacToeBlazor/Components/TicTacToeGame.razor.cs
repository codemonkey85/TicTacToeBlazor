namespace TicTacToeBlazor.Components;

public partial class TicTacToeGame
{
    private const string X = nameof(X);
    private const string O = nameof(O);

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
        [8] = string.Empty
    };

    private readonly int[][] winningCombos =
    [
        [0, 1, 2],
        [3, 4, 5],
        [6, 7, 8],
        [0, 3, 6],
        [1, 4, 7],
        [2, 5, 8],
        [0, 4, 8],
        [2, 4, 6]
    ];

    private string currentTurn = O;

    private string info = $"{O} goes first";

    private bool isGameOver;
    private bool isGameTied;
    private int numberOfTurns;

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
            currentTurn = currentTurn is X
                ? O
                : X;
            info = $"It is now {currentTurn}'s turn";
        }
    }

    private void CheckIfGameIsOver()
    {
        foreach (var combo in winningCombos)
        {
            var marks = combo.Select(i => squares[i]).ToList();

            if (!marks.All(m => m is X) && !marks.All(m => m is O))
            {
                continue;
            }

            isGameOver = true;
            return;
        }

        if (!squares.Values.All(mark => mark is { Length: > 0 }))
        {
            return;
        }

        isGameTied = true;
        isGameOver = true;
    }

    private void ResetBoard()
    {
        currentTurn = O;
        numberOfTurns = 0;

        for (var i = 0; i < 9; i++)
        {
            squares[i] = string.Empty;
        }

        isGameOver = false;
        isGameTied = false;

        info = $"{O} goes first";
    }
}
