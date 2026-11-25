using Navigation2.Models;

namespace Navigation2;

[QueryProperty(nameof(title), "title")]
[QueryProperty(nameof(desc), "desc")]
public partial class Notes : ContentPage
{
    public string title { get; set; }
    public string desc { get; set; }

	public Notes()
	{
		InitializeComponent();
        //NotesName.Text = $"Temp";
        NotesDescLabel.Text = desc;
        NotesNameLabel.Text = title;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        NotesNameLabel.Text = title;
        NotesDescLabel.Text = desc;
    }

    private async void OnGoBack(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}