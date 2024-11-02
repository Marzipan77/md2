using md2.Models;
using Microsoft.Maui.Controls;
namespace md2
{
    public partial class MainPage : ContentPage
    {
        private readonly DataManager _dataManager = new DataManager();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnViewDataClicked(object sender, EventArgs e)
        {
            // Pāriet uz skata datu lapu
            await Navigation.PushAsync(new ViewDataPage(_dataManager));
        }

        private void OnCreateTestDataClicked(object sender, EventArgs e)
        {
            // Izveido testa datus
            _dataManager.CreateTestData();
            DisplayAlert("Veiksmīgi", "Testa dati izveidoti", "OK");
        }

        private void OnSaveDataClicked(object sender, EventArgs e)
        {
            // Saglabā datus failā
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "data.json");
            _dataManager.Save(filePath);
            DisplayAlert("Veiksmīgi", "Dati saglabāti", "OK");
        }

        private void OnLoadDataClicked(object sender, EventArgs e)
        {
            // Ielādē datus no faila
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "data.json");
            _dataManager.Load(filePath);
            DisplayAlert("Veiksmīgi", "Dati ielādēti", "OK");
        }

    //    private async void OnAddNewEntryClicked(object sender, EventArgs e)
    //    {
    //        // Pāriet uz jaunu ierakstu pievienošanas lapu
    //        await Navigation.PushAsync(new AddNewEntryPage(_dataManager));
    //    }
    }
}
