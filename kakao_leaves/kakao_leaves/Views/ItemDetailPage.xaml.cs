using kakao_leaves.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace kakao_leaves.Views
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