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

        private void CheckIsGameOver()
        {
            isGameOver =
                (!string.IsNullOrEmpty(Square0Content) && !string.IsNullOrEmpty(Square1Content) && !string.IsNullOrEmpty(Square2Content) &&
                string.Equals(Square0Content, Square1Content) && string.Equals(Square0Content, Square2Content)) ||

                (!string.IsNullOrEmpty(Square3Content) && !string.IsNullOrEmpty(Square4Content) && !string.IsNullOrEmpty(Square5Content) &&
                string.Equals(Square3Content, Square4Content) && string.Equals(Square3Content, Square5Content)) ||

                (!string.IsNullOrEmpty(Square6Content) && !string.IsNullOrEmpty(Square7Content) && !string.IsNullOrEmpty(Square8Content) &&
                string.Equals(Square6Content, Square7Content) && string.Equals(Square6Content, Square8Content)) ||

                (!string.IsNullOrEmpty(Square0Content) && !string.IsNullOrEmpty(Square3Content) && !string.IsNullOrEmpty(Square6Content) &&
                string.Equals(Square0Content, Square3Content) && string.Equals(Square0Content, Square6Content)) ||

                (!string.IsNullOrEmpty(Square1Content) && !string.IsNullOrEmpty(Square4Content) && !string.IsNullOrEmpty(Square7Content) &&
                string.Equals(Square1Content, Square4Content) && string.Equals(Square1Content, Square7Content)) ||

                (!string.IsNullOrEmpty(Square2Content) && !string.IsNullOrEmpty(Square5Content) && !string.IsNullOrEmpty(Square8Content) &&
                string.Equals(Square2Content, Square5Content) && string.Equals(Square2Content, Square8Content)) ||

                (!string.IsNullOrEmpty(Square0Content) && !string.IsNullOrEmpty(Square4Content) && !string.IsNullOrEmpty(Square8Content) &&
                string.Equals(Square0Content, Square4Content) && string.Equals(Square0Content, Square8Content)) ||

                (!string.IsNullOrEmpty(Square2Content) && !string.IsNullOrEmpty(Square4Content) && !string.IsNullOrEmpty(Square6Content) &&
                string.Equals(Square2Content, Square4Content) && string.Equals(Square2Content, Square6Content));
        }

        public void ResetBoard()
        {
            Square0Content = string.Empty;
            Square1Content = string.Empty;
            Square2Content = string.Empty;
            Square3Content = string.Empty;
            Square4Content = string.Empty;
            Square5Content = string.Empty;
            Square6Content = string.Empty;
            Square7Content = string.Empty;
            Square8Content = string.Empty;
            turnNumber = 0;
            isGameOver = false;
            GameIsTied = false;
            StateHasChanged();
        }
    }
}
