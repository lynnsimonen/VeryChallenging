using System;
using System.Collections.Generic;
using VeryChallenging.ViewModels;
using VeryChallenging.Views;
using Xamarin.Forms;

namespace VeryChallenging
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
