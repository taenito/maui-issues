using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiAppRefreshViewManuallyIndicatorHidden;

public partial class ItemViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(ShowTextLine1))]
    string? _textLine1;
    
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(ShowTextLine2))]
    string? _textLine2;
    
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(ShowTextLine3))]
    string? _textLine3;
    
    public bool ShowTextLine1 => !string.IsNullOrWhiteSpace(TextLine1);
    
    public bool ShowTextLine2 => !string.IsNullOrWhiteSpace(TextLine2);
    
    public bool ShowTextLine3 => !string.IsNullOrWhiteSpace(TextLine3);
    
}