namespace TicTacToeBlazor.Components
{
    public partial class TicTacToeGame
    {
        int turnNumber = 0;
        private bool isGameOver = false;

        private bool IsXturn => turnNumber % 2 == 0;

        public string Winner { get; set; }

        private string Block0Content { get; set; }
        private string Block1Content { get; set; }
        private string Block2Content { get; set; }
        private string Block3Content { get; set; }
        private string Block4Content { get; set; }
        private string Block5Content { get; set; }
        private string Block6Content { get; set; }
        private string Block7Content { get; set; }
        private string Block8Content { get; set; }

        private string PrintCharacter() => IsXturn ? "X" : "O";

        public void SquareClicked(string blockId)
        {
            if (isGameOver)
            {
                return;
            }

            switch (blockId)
            {
                case "block0":
                    Block0Content = PrintCharacter();
                    break;
                case "block1":
                    Block1Content = PrintCharacter();
                    break;
                case "block2":
                    Block2Content = PrintCharacter();
                    break;
                case "block3":
                    Block3Content = PrintCharacter();
                    break;
                case "block4":
                    Block4Content = PrintCharacter();
                    break;
                case "block5":
                    Block5Content = PrintCharacter();
                    break;
                case "block6":
                    Block6Content = PrintCharacter();
                    break;
                case "block7":
                    Block7Content = PrintCharacter();
                    break;
                case "block8":
                    Block8Content = PrintCharacter();
                    break;
            }

            CheckIsGameOver();

            if (!isGameOver)
            {
                turnNumber++;
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

            if (isGameOver)
            {
                Winner = PrintCharacter();
            }
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
            Winner = string.Empty;
            StateHasChanged();
        }
    }
}
