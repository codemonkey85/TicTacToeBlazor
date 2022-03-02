namespace TicTacToeBlazor.Components;

public partial class TicTacToeGame
{
    private int turnNumber = 0;
    private bool isGameOver = false;
    private string WinnerName = string.Empty;

    private bool IsXturn => turnNumber % 2 == 0;
    private bool GameIsTied = false;

    private string Square0Content { get; set; }
    private string Square1Content { get; set; }
    private string Square2Content { get; set; }
    private string Square3Content { get; set; }
    private string Square4Content { get; set; }
    private string Square5Content { get; set; }
    private string Square6Content { get; set; }
    private string Square7Content { get; set; }
    private string Square8Content { get; set; }

    public string CurrentPlayerName => IsXturn ? "X" : "O";

    public void SquareClicked(string squareId)
    {
        if (isGameOver)
        {
            return;
        }

        if (squareId switch
        {
            "square0" => !string.IsNullOrWhiteSpace(Square0Content) ? null : Square0Content = CurrentPlayerName,
            "square1" => !string.IsNullOrWhiteSpace(Square1Content) ? null : Square1Content = CurrentPlayerName,
            "square2" => !string.IsNullOrWhiteSpace(Square2Content) ? null : Square2Content = CurrentPlayerName,
            "square3" => !string.IsNullOrWhiteSpace(Square3Content) ? null : Square3Content = CurrentPlayerName,
            "square4" => !string.IsNullOrWhiteSpace(Square4Content) ? null : Square4Content = CurrentPlayerName,
            "square5" => !string.IsNullOrWhiteSpace(Square5Content) ? null : Square5Content = CurrentPlayerName,
            "square6" => !string.IsNullOrWhiteSpace(Square6Content) ? null : Square6Content = CurrentPlayerName,
            "square7" => !string.IsNullOrWhiteSpace(Square7Content) ? null : Square7Content = CurrentPlayerName,
            "square8" => !string.IsNullOrWhiteSpace(Square8Content) ? null : Square8Content = CurrentPlayerName,
            _ => null,
        } == null)
        {
            return;
        }

        CheckIsGameOver();

        if (isGameOver)
        {
            WinnerName = CurrentPlayerName;
        }

        turnNumber++;

        if (!isGameOver && turnNumber == 9)
        {
            isGameOver = true;
            GameIsTied = true;
        }
    }

    private void CheckIsGameOver() => isGameOver =
        CheckWinningCondition(Square0Content, Square1Content, Square2Content) ||
        CheckWinningCondition(Square3Content, Square4Content, Square5Content) ||
        CheckWinningCondition(Square6Content, Square7Content, Square8Content) ||
        CheckWinningCondition(Square0Content, Square3Content, Square6Content) ||
        CheckWinningCondition(Square1Content, Square4Content, Square7Content) ||
        CheckWinningCondition(Square2Content, Square5Content, Square8Content) ||
        CheckWinningCondition(Square0Content, Square4Content, Square8Content) ||
        CheckWinningCondition(Square2Content, Square4Content, Square6Content);

    private static bool CheckWinningCondition(string square1, string square2, string square3) =>
        !string.IsNullOrEmpty(square1) &&
        !string.IsNullOrEmpty(square2) &&
        !string.IsNullOrEmpty(square3) &&
        string.Equals(square1, square2) &&
        string.Equals(square1, square3);

    public void ResetBoard()
    {
        Square0Content =
        Square1Content =
        Square2Content =
        Square3Content =
        Square4Content =
        Square5Content =
        Square6Content =
        Square7Content =
        Square8Content = string.Empty;
        turnNumber = 0;
        isGameOver =
        GameIsTied = false;
        StateHasChanged();
    }
}
