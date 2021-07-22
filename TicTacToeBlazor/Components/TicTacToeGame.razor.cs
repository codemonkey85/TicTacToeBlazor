namespace TicTacToeBlazor.Components
{
    public partial class TicTacToeGame
    {
        int turnNumber = 0;
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

            switch (squareId)
            {
                case "square0":
                    if (!string.IsNullOrWhiteSpace(Square0Content))
                    {
                        return;
                    }
                    Square0Content = CurrentPlayerName;
                    break;

                case "square1":
                    if (!string.IsNullOrWhiteSpace(Square1Content))
                    {
                        return;
                    }
                    Square1Content = CurrentPlayerName;
                    break;

                case "square2":
                    if (!string.IsNullOrWhiteSpace(Square2Content))
                    {
                        return;
                    }
                    Square2Content = CurrentPlayerName;
                    break;

                case "square3":
                    if (!string.IsNullOrWhiteSpace(Square3Content))
                    {
                        return;
                    }
                    Square3Content = CurrentPlayerName;
                    break;

                case "square4":
                    if (!string.IsNullOrWhiteSpace(Square4Content))
                    {
                        return;
                    }
                    Square4Content = CurrentPlayerName;
                    break;

                case "square5":
                    if (!string.IsNullOrWhiteSpace(Square5Content))
                    {
                        return;
                    }
                    Square5Content = CurrentPlayerName;
                    break;

                case "square6":
                    if (!string.IsNullOrWhiteSpace(Square6Content))
                    {
                        return;
                    }
                    Square6Content = CurrentPlayerName;
                    break;

                case "square7":
                    if (!string.IsNullOrWhiteSpace(Square7Content))
                    {
                        return;
                    }
                    Square7Content = CurrentPlayerName;
                    break;

                case "square8":
                    if (!string.IsNullOrWhiteSpace(Square8Content))
                    {
                        return;
                    }
                    Square8Content = CurrentPlayerName;
                    break;
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

        private void CheckIsGameOver() =>
            isGameOver =
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
}
