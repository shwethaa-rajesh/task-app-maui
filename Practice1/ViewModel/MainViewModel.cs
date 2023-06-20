using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Practice1.Models;

namespace Practice1.ViewModel;
public partial class MainViewModel : ObservableObject
{
    HttpClient client;

    JsonSerializerOptions _serializerOptions;
    string baseUrl = "https://648bf0968620b8bae7ebeed6.mockapi.io";
    public MainViewModel()
    {
        client = new HttpClient();
        _serializerOptions = new JsonSerializerOptions();
        Items = new ObservableCollection<string>();
        DeletedItems = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> _items;

    [ObservableProperty]
    ObservableCollection<string> deletedItems;

    [ObservableProperty]
    string text;


    [RelayCommand]

    async void AddTask()
    {
        System.Diagnostics.Debug.WriteLine("abc");
        string url = $"{baseUrl}/tasks";

        var taskNew = new TaskModel
        {
            task = "New task",
            createdAt = DateTime.Now.ToString(),
            id = "9999"

        };
        string json = JsonSerializer.Serialize<TaskModel>(taskNew, _serializerOptions);
        StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        var postResponse = await client.PostAsync(url, content);

        System.Diagnostics.Debug.WriteLine(postResponse);
        string getUrl = $"{baseUrl}/tasks";

        var response = await client.GetStringAsync(getUrl);


        System.Diagnostics.Debug.WriteLine(response);
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

