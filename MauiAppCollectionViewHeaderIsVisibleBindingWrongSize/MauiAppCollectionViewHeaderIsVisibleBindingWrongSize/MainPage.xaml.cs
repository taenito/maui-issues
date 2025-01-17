namespace MauiAppCollectionViewHeaderIsVisibleBindingWrongSize;

public partial class MainPage : ContentPage
{
    private MainPageModel _pageModel;
    
    public MainPage()
    {
        InitializeComponent();
        BindingContext = _pageModel = new MainPageModel();
    }
}