using System.Windows.Input;

namespace MauiAppCollectionView2BindingWithSource;

public partial class ItemView
{
    public ItemView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty CommandByAncestorAndReferenceProperty = BindableProperty.Create(
            propertyName: nameof(CommandByAncestorAndReference),
            returnType: typeof(ICommand),
            declaringType: typeof(ItemView),
            defaultValue: null,
            defaultBindingMode: BindingMode.OneWay,
            validateValue: null,
            propertyChanged: null,
            propertyChanging: null,
            coerceValue: null,
            defaultValueCreator: null);

    public static readonly BindableProperty CommandByAncestorAndReferenceParameterProperty = BindableProperty.Create(
            propertyName: nameof(CommandByAncestorAndReferenceParameter),
            returnType: typeof(object),
            declaringType: typeof(ItemView),
            defaultValue: null,
            defaultBindingMode: BindingMode.OneWay,
            validateValue: null,
            propertyChanged: null,
            propertyChanging: null,
            coerceValue: null,
            defaultValueCreator: null);

    public ICommand? CommandByAncestorAndReference
    {
        get => (ICommand?)GetValue(CommandByAncestorAndReferenceProperty);
        set => SetValue(CommandByAncestorAndReferenceProperty, value);
    }

    public object? CommandByAncestorAndReferenceParameter
    {
        get => (ICommand?)GetValue(CommandByAncestorAndReferenceParameterProperty);
        set => SetValue(CommandByAncestorAndReferenceParameterProperty, value);
    }
}