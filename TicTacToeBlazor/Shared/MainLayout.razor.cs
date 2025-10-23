namespace TicTacToeBlazor.Shared;

public partial class MainLayout
{
    private const string AppTitle = "Tic Tac Toe";

    private bool isDarkMode;
    private MudThemeProvider? mudThemeProvider;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender || mudThemeProvider is null)
        {
            return;
        }

        isDarkMode = await mudThemeProvider.GetSystemDarkModeAsync();
        await mudThemeProvider.WatchSystemDarkModeAsync(OnSystemPreferenceChanged);
        StateHasChanged();
    }

    private Task OnSystemPreferenceChanged(bool newValue)
    {
        isDarkMode = newValue;
        StateHasChanged();
        return Task.CompletedTask;
    }
}
