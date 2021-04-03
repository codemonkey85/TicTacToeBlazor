namespace TicTacToeBlazor.Components
{
    public partial class TicTacToeGame
    {
        int turnNumber = 0;
        private bool isGameOver = false;

        private bool IsXturn => turnNumber % 2 == 0;
        private bool GameIsTied = false;

        private string Block0Content { get; set; }
        private string Block1Content { get; set; }
        private string Block2Content { get; set; }
        private string Block3Content { get; set; }
        private string Block4Content { get; set; }
        private string Block5Content { get; set; }
        private string Block6Content { get; set; }
        private string Block7Content { get; set; }
        private string Block8Content { get; set; }

        public string CurrentPlayerName => IsXturn ? "X" : "O";

        public void SquareClicked(string blockId)
        {
            if (isGameOver)
            {
                return;
            }

            switch (blockId)
            {
                case "block0":
                    if (!string.IsNullOrWhiteSpace(Block0Content))
                    {
                        return;
                    }
                    Block0Content = CurrentPlayerName;
                    break;
                case "block1":
                    if (!string.IsNullOrWhiteSpace(Block1Content))
                    {
                        return;
                    }
                    Block1Content = CurrentPlayerName;
                    break;
                case "block2":
                    if (!string.IsNullOrWhiteSpace(Block2Content))
                    {
                        return;
                    }
                    Block2Content = CurrentPlayerName;
                    break;
                case "block3":
                    if (!string.IsNullOrWhiteSpace(Block3Content))
                    {
                        return;
                    }
                    Block3Content = CurrentPlayerName;
                    break;
                case "block4":
                    if (!string.IsNullOrWhiteSpace(Block4Content))
                    {
                        return;
                    }
                    Block4Content = CurrentPlayerName;
                    break;
                case "block5":
                    if (!string.IsNullOrWhiteSpace(Block5Content))
                    {
                        return;
                    }
                    Block5Content = CurrentPlayerName;
                    break;
                case "block6":
                    if (!string.IsNullOrWhiteSpace(Block6Content))
                    {
                        return;
                    }
                    Block6Content = CurrentPlayerName;
                    break;
                case "block7":
                    if (!string.IsNullOrWhiteSpace(Block7Content))
                    {
                        return;
                    }
                    Block7Content = CurrentPlayerName;
                    break;
                case "block8":
                    if (!string.IsNullOrWhiteSpace(Block8Content))
                    {
                        return;
                    }
                    Block8Content = CurrentPlayerName;
                    break;
            }

            CheckIsGameOver();

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
                (!string.IsNullOrEmpty(Block0Content) && !string.IsNullOrEmpty(Block1Content) && !string.IsNullOrEmpty(Block2Content) &&
                string.Equals(Block0Content, Block1Content) && string.Equals(Block0Content, Block2Content)) ||

                (!string.IsNullOrEmpty(Block3Content) && !string.IsNullOrEmpty(Block4Content) && !string.IsNullOrEmpty(Block5Content) &&
                string.Equals(Block3Content, Block4Content) && string.Equals(Block3Content, Block5Content)) ||

                (!string.IsNullOrEmpty(Block6Content) && !string.IsNullOrEmpty(Block7Content) && !string.IsNullOrEmpty(Block8Content) &&
                string.Equals(Block6Content, Block7Content) && string.Equals(Block6Content, Block8Content)) ||


                (!string.IsNullOrEmpty(Block0Content) && !string.IsNullOrEmpty(Block3Content) && !string.IsNullOrEmpty(Block6Content) &&
                string.Equals(Block0Content, Block3Content) && string.Equals(Block0Content, Block6Content)) ||

                (!string.IsNullOrEmpty(Block1Content) && !string.IsNullOrEmpty(Block4Content) && !string.IsNullOrEmpty(Block7Content) &&
                string.Equals(Block1Content, Block4Content) && string.Equals(Block1Content, Block7Content)) ||

                (!string.IsNullOrEmpty(Block2Content) && !string.IsNullOrEmpty(Block5Content) && !string.IsNullOrEmpty(Block8Content) &&
                string.Equals(Block2Content, Block5Content) && string.Equals(Block2Content, Block8Content)) ||


                (!string.IsNullOrEmpty(Block0Content) && !string.IsNullOrEmpty(Block4Content) && !string.IsNullOrEmpty(Block8Content) &&
                string.Equals(Block0Content, Block4Content) && string.Equals(Block0Content, Block8Content)) ||

                (!string.IsNullOrEmpty(Block2Content) && !string.IsNullOrEmpty(Block4Content) && !string.IsNullOrEmpty(Block6Content) &&
                string.Equals(Block2Content, Block4Content) && string.Equals(Block2Content, Block6Content));
        }

        public void ResetBoard()
        {
            Block0Content = string.Empty;
            Block1Content = string.Empty;
            Block2Content = string.Empty;
            Block3Content = string.Empty;
            Block4Content = string.Empty;
            Block5Content = string.Empty;
            Block6Content = string.Empty;
            Block7Content = string.Empty;
            Block8Content = string.Empty;
            turnNumber = 0;
            isGameOver = false;
            StateHasChanged();
        }
    }
}
