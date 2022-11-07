using System;
using System.Collections.Generic;
using System.ComponentModel;
using VeryChallenging.Models;
using VeryChallenging.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VeryChallenging.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}