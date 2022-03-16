using System.ComponentModel;
using Xamarin.Forms;
using prueba.ViewModels;

namespace prueba.Views
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
