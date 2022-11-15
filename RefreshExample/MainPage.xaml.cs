using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace RefreshExample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public List<string> Items => new List<string>
    {
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
        "Item",
    };

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Toolbar action", "Hello, I'm a toolbar action :)", "OK");
    }
}

