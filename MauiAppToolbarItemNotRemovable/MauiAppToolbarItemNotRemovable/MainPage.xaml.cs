namespace MauiAppToolbarItemNotRemovable
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object? sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }
    }
}
