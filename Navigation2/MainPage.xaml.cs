using Navigation2.Models;
using System.Collections.ObjectModel;

namespace Navigation2
{
    public partial class MainPage : ContentPage
    {

        ObservableCollection<Note> notes = [];
        public MainPage()
        {
            InitializeComponent();
            NotesCollection.ItemsSource = notes;

        }

        private async void OnCreateNote(object? sender, EventArgs e)
        {
            string title = NameEntry.Text;
            string desc = DescEditor.Text;

            notes.Add(new Note(title,desc));
            //string name = NameEntry.Text;
            //await Navigation.PushAsync(new Notes(imie, wynik));
        }
        private async void GoTo(object? sender, SelectionChangedEventArgs e)
        {
            //string name = NameEntry.Text;
            //await Navigation.PushAsync(new Notes(imie, wynik));

            if (e.CurrentSelection.FirstOrDefault() is Note SelectedNote)
            {
                string NameToSend = SelectedNote.title;
                string DescToSend = SelectedNote.desc;
                try { await Shell.Current.GoToAsync($"Notes?title={NameToSend}&desc={DescToSend}"); } catch { }
                NotesCollection.SelectedItem = null;
                return;
            }
        }
    }
}
