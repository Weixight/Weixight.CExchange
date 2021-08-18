using System.ComponentModel;
using Xamarin.Forms;
using Weixight.CExchange.Mobile.ViewModels;

namespace Weixight.CExchange.Mobile.Views
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