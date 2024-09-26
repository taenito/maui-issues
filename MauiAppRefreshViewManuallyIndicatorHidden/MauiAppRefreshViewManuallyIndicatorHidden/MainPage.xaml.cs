namespace MauiAppRefreshViewManuallyIndicatorHidden;

public partial class MainPage
{
    private MainPageModel _pageModel;
    
    public MainPage()
    {
        InitializeComponent();
        BindingContext = _pageModel = new MainPageModel();
    }
}