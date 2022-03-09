using kakao_leaves.ViewModels;
using kakao_leaves.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace kakao_leaves
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
