using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppCollectionView2BindingWithSource;

public partial class ItemViewModel : ObservableObject
{
    [ObservableProperty]
    string _text;

    [ObservableProperty]
    private IAsyncRelayCommand<ItemViewModel> _commandByViewModel;

    public ItemViewModel(string text, IAsyncRelayCommand<ItemViewModel> commandByViewModel)
    {
        _text = text;
        _commandByViewModel = commandByViewModel;
    }

    [RelayCommand]
    Task ExecuteByViewModelAsync()
    {
        return CommandByViewModel.ExecuteAsync(this);
    }
}