namespace ShareFromMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        public async void redirectToSharePage()
        {
            await Shell.Current.Navigation.PushAsync(new SharePage());
        }
    }
}
