using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppCollectionView2BindingWithSource;

public partial class MainPageModel : ObservableObject
{
    [ObservableProperty]
    bool _isRefreshing;

    [ObservableProperty]
    string _lastCommandType = "";

    [ObservableProperty]
    string _lastItemText = "";
    
    public ObservableCollection<ItemViewModel> Items { get; } = [];

    [RelayCommand]
    async Task RefreshAsync()
    {
        try
        {
            IsRefreshing = true;
            await InitItems();
        }
        finally
        {
            IsRefreshing = false;
        }
    }

    [RelayCommand]
    async Task ChangeLastCommandByAncestorAsync(ItemViewModel itemViewModel)
    {
        LastCommandType = "Ancestor";
        LastItemText = itemViewModel.Text;
    }

    [RelayCommand]
    async Task ChangeLastCommandByViewModelAsync(ItemViewModel itemViewModel)
    {
        LastCommandType = "ViewModel";
        LastItemText = itemViewModel.Text;
    }
    
    public MainPageModel()
    {
        _ = InitItems();
    }

    async Task InitItems()
    {
        await Task.Delay(2000);
        
        Application.Current?.Dispatcher.Dispatch(() =>
        {
            Items.Clear();
            foreach (var itemViewModel in GetItems())
            {
                Items.Add(itemViewModel);
            }
        });
    }

    List<ItemViewModel> GetItems()
    {
        List<ItemViewModel> items = [];

        for (int i = 0; i < 50; i++)
        {
            items.Add(new ItemViewModel($"{i}", ChangeLastCommandByViewModelCommand));
        }

        return items;
    }
}