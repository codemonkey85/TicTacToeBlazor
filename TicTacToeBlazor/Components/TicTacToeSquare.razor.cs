using Microsoft.AspNetCore.Components;

namespace TicTacToeBlazor.Components
{
    public partial class TicTacToeSquare
    {
        [Parameter]
        public string BoxId
        {
            get; set;
        }

        public string Content
        {
            get; set;
        }

        public void SquareClicked()
        {
        }

        public void ResetBlock()
        {
        }
    }
}
