namespace MauiAppCollectionViewHeaderIsVisibleBindingWrongSize;

public class ItemGroupViewModel : List<ItemViewModel>
{
    public string Name { get; private set; }

    public ItemGroupViewModel(string name, List<ItemViewModel> items) : base(items)
    {
        Name = name;
    }
}