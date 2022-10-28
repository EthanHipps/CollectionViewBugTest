using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CollectionViewBugTest;

public partial class MainPageViewModel : ObservableObject
{
    private readonly static IList<string> Data = new List<string> { "test 1", "test 2", "test 3" };

    public ObservableCollection<CollectionViewStringGroup> TestData { get; } = new() {
        new("Header 1", Data),
        new ("Header 2", Data),
        new ("Header 3", Data)
    };

    [RelayCommand]
    private async Task ClearAndAddItemsAsync()
    {
        await Task.Delay(1000);
        TestData.Clear();
        TestData.Add(new("Header 1", Data));
    }

}
