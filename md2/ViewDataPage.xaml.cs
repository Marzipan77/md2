using md2.Models;  
using Microsoft.Maui.Controls;

namespace md2
{
    public partial class ViewDataPage : ContentPage
    {
        private readonly DataManager _dataManager;

        public ViewDataPage(DataManager dataManager)
        {
            InitializeComponent();
            _dataManager = dataManager;

            // Load data into CollectionView
            DataCollectionView.ItemsSource = _dataManager.GetAllData();
        }
    }
}

