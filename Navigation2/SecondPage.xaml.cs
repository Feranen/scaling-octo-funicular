namespace Navigation2;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}
    private async void OnBack(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}