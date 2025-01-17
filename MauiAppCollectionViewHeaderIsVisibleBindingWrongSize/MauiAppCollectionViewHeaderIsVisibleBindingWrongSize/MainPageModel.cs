using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppCollectionViewHeaderIsVisibleBindingWrongSize;

public partial class MainPageModel : ObservableObject
{
    [ObservableProperty]
    bool _isRefreshing;
    
    [ObservableProperty]
    bool _showHeader;
    
    public ObservableCollection<ItemGroupViewModel> Items { get; } = [];

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
            foreach (var vm in GetItemGroups())
            {
                Items.Add(vm);
            }
        });
    }
    
    
    List<ItemGroupViewModel> GetItemGroups()
    {
        List<ItemGroupViewModel> items =
        [
            new("Group 1", GetItems()),
            new("Group 2", GetItems()),
            new("Group 3", GetItems()),
            new("Group 4", GetItems())
        ];

        return items;
    }

    List<ItemViewModel> GetItems()
    {
        List<ItemViewModel> items =
        [
            new()
            {
                TextLine1 = "1",
            },
            new()
            {
                TextLine1 = "1",
                TextLine2 = "2",
            },
            new()
            {
                TextLine1 = "1",
                TextLine2 = "2",
                TextLine3 = "3",
            },
            new()
            {
                TextLine1 = "1",
                TextLine2 = "2",
                TextLine3 = "3",
            },
            new()
            {
                TextLine1 = "1",
                TextLine2 = "2",
            },
            new()
            {
                TextLine1 = "1",
            },
            new()
            {
                TextLine1 = "1",
                TextLine2 = "2",
                TextLine3 = "3",
            },
            new()
            {
                TextLine1 = "1",
                TextLine2 = "2",
            },
            new()
            {
                TextLine1 = "1",
            },
            new()
            {
                TextLine1 = "1",
                TextLine2 = "2",
                TextLine3 = "3",
            },
            new()
            {
                TextLine1 = "1",
                TextLine2 = "2",
            },
            new()
            {
                TextLine1 = "1",
            }
        ];

        return items;
    }
}