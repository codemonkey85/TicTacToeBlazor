namespace TicTacToeBlazor.Components;

public partial class TicTacToeGame
{
    private int turnNumber = 0;
    private bool isGameOver = false;
    private string WinnerName = string.Empty;

    private bool IsXturn => turnNumber % 2 == 0;
    private bool GameIsTied = false;

    private string Square0Content { get; set; } = string.Empty;
    private string Square1Content { get; set; } = string.Empty;
    private string Square2Content { get; set; } = string.Empty;
    private string Square3Content { get; set; } = string.Empty;
    private string Square4Content { get; set; } = string.Empty;
    private string Square5Content { get; set; } = string.Empty;
    private string Square6Content { get; set; } = string.Empty;
    private string Square7Content { get; set; } = string.Empty;
    private string Square8Content { get; set; } = string.Empty;

    private const string X = "X";
    private const string O = "O";

    public string CurrentPlayerName => IsXturn ? X : O;

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
        } is null)
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
        (
            Square0Content, Square1Content, Square2Content,
            Square3Content, Square4Content, Square5Content,
            Square6Content, Square7Content, Square8Content
        ) switch
        {
            (
                X, X, X,
                _, _, _,
                _, _, _
            ) or
            (
                O, O, O,
                _, _, _,
                _, _, _
            ) or
            (
                _, _, _,
                X, X, X,
                _, _, _
            ) or
            (
                _, _, _,
                O, O, O,
                _, _, _
            ) or
            (
                _, _, _,
                _, _, _,
                X, X, X
            ) or
            (
                _, _, _,
                _, _, _,
                O, O, O
            ) or
            (
                X, _, _,
                _, X, _,
                _, _, X
            ) or
            (
                O, _, _,
                _, O, _,
                _, _, O
            ) or
            (
                _, _, X,
                _, X, _,
                X, _, _
            ) or
            (
                _, _, O,
                _, O, _,
                O, _, _
            ) or
            (
                X, _, _,
                X, _, _,
                X, _, _
            ) or
            (
                O, _, _,
                O, _, _,
                O, _, _
            ) or
            (
                _, X, _,
                _, X, _,
                _, X, _
            ) or
            (
                _, O, _,
                _, O, _,
                _, O, _
            ) or
            (
                _, _, X,
                _, _, X,
                _, _, X
            ) or
            (
                _, _, O,
                _, _, O,
                _, _, O
            ) => true,
            _ => false,
        };

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
