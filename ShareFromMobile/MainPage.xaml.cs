﻿namespace ShareFromMobile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
           await Shell.Current.Navigation.PushAsync(new LoadingPage());
        }
    }

}
