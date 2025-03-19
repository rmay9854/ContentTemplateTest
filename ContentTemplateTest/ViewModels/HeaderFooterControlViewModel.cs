using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Maui;

namespace ContentTemplateTest.ViewModels;

public partial class HeaderFooterControlViewModel: ObservableObject
{
    [ObservableProperty]
    private string ?headerText;
}
