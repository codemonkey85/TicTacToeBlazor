namespace TicTacToeBlazor.Components;

public partial class TicTacToeGame
{
    private const string X = "X";
    private const string O = "O";

    private const string Square0Id = "square0";
    private const string Square1Id = "square1";
    private const string Square2Id = "square2";
    private const string Square3Id = "square3";
    private const string Square4Id = "square4";
    private const string Square5Id = "square5";
    private const string Square6Id = "square6";
    private const string Square7Id = "square7";
    private const string Square8Id = "square8";

    private int turnNumber = 0;
    private bool isGameOver = false;
    private string winnerName = string.Empty;

    private bool IsXturn => turnNumber % 2 == 0;
    private bool gameIsTied = false;

    private string Square0Content { get; set; } = string.Empty;
    private string Square1Content { get; set; } = string.Empty;
    private string Square2Content { get; set; } = string.Empty;
    private string Square3Content { get; set; } = string.Empty;
    private string Square4Content { get; set; } = string.Empty;
    private string Square5Content { get; set; } = string.Empty;
    private string Square6Content { get; set; } = string.Empty;
    private string Square7Content { get; set; } = string.Empty;
    private string Square8Content { get; set; } = string.Empty;

    private string CurrentPlayerName => IsXturn ? X : O;

    private void Clicked(string squareId)
    {
        if (isGameOver)
        {
            return;
        }

        if (squareId switch
        {
            Square0Id => !string.IsNullOrWhiteSpace(Square0Content) ? null : Square0Content = CurrentPlayerName,
            Square1Id => !string.IsNullOrWhiteSpace(Square1Content) ? null : Square1Content = CurrentPlayerName,
            Square2Id => !string.IsNullOrWhiteSpace(Square2Content) ? null : Square2Content = CurrentPlayerName,
            Square3Id => !string.IsNullOrWhiteSpace(Square3Content) ? null : Square3Content = CurrentPlayerName,
            Square4Id => !string.IsNullOrWhiteSpace(Square4Content) ? null : Square4Content = CurrentPlayerName,
            Square5Id => !string.IsNullOrWhiteSpace(Square5Content) ? null : Square5Content = CurrentPlayerName,
            Square6Id => !string.IsNullOrWhiteSpace(Square6Content) ? null : Square6Content = CurrentPlayerName,
            Square7Id => !string.IsNullOrWhiteSpace(Square7Content) ? null : Square7Content = CurrentPlayerName,
            Square8Id => !string.IsNullOrWhiteSpace(Square8Content) ? null : Square8Content = CurrentPlayerName,
            _ => null,
        } is null)
        {
            return;
        }

        CheckIsGameOver();

        if (isGameOver)
        {
            winnerName = CurrentPlayerName;
        }

        turnNumber++;

        if (isGameOver || turnNumber != 9)
        {
            return;
        }

        isGameOver = true;
        gameIsTied = true;
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

    private void ResetBoard()
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
            gameIsTied = false;
        StateHasChanged();
    }
}
