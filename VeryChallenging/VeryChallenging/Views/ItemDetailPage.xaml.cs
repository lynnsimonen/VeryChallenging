using System.ComponentModel;
using VeryChallenging.ViewModels;
using Xamarin.Forms;

namespace VeryChallenging.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}