namespace MauiAppToolbarItemNotRemovable;

public partial class SecondPage : ContentPage
{
    private ToolbarItem? Item1 { get; } = new()
    {
        Text = "Item1",
    };

    private ToolbarItem? Item2 { get; } = new()
    {
        Text = "Item2"
    };

    private ToolbarItem? Item3 { get; } = new()
    {
        Text = "Item3"
    };

    public SecondPage()
	{
		InitializeComponent();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        ChangeItemVisibility(Item1);
    }

    private void Button2_OnClicked(object? sender, EventArgs e)
    {
        ChangeItemVisibility(Item2);
    }

    private void Button3_OnClicked(object? sender, EventArgs e)
    {
        ChangeItemVisibility(Item3);
    }

    public void ChangeItemVisibility(ToolbarItem? toolbarItem)
    {
        if (toolbarItem is null) return;

        var containsToolbarItem = ToolbarItems.Contains(toolbarItem);

        if (!containsToolbarItem)
        {
            ToolbarItems.Add(toolbarItem);
        }
        else
        {
            ToolbarItems.Remove(toolbarItem);
        }
    }
}