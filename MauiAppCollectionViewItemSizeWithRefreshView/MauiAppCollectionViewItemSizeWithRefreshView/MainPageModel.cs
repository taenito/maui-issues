using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppCollectionViewItemSizeWithRefreshView;

public partial class MainPageModel : ObservableObject
{
    [ObservableProperty]
    bool _isRefreshing;
    
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
    
    public MainPageModel()
    {
        _ = InitItems();
    }

    async Task InitItems()
    {
        await Task.Delay(2000);
        
        Items.Clear();
        foreach (var itemViewModel in GetItems())
        {
            Items.Add(itemViewModel);
        }
    }

    List<ItemViewModel> GetItems()
    {
        List<ItemViewModel> items =
        [
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