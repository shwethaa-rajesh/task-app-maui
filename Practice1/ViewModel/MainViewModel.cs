using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Practice1.ViewModel;
public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Items = new ObservableCollection<string>();
        DeletedItems = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    ObservableCollection<string> deletedItems;

    [ObservableProperty]
    string text;

    [RelayCommand]

    void AddTask()
    {
        if (string.IsNullOrWhiteSpace(Text))
        {
            return;
        }
        Items.Add(Text);
        Text = string.Empty;
    }

    [RelayCommand]

    void DeleteTask(string taskName)
    {

        if(Items.Contains(taskName))
        {
            Items.Remove(taskName);
            DeletedItems.Add(taskName);
        }
    }    

}

