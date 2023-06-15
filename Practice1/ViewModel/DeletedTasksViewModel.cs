using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Google.Android.Material.Chip;

namespace Practice1.ViewModel
{
	public partial class DeletedTasksViewModel : ObservableObject
	{
		public DeletedTasksViewModel()
		{
			
		}

		[ObservableProperty]
		ObservableCollection<string> itemsDeleted;

        [ObservableProperty]
        ObservableCollection<string> taskItems;

        [RelayCommand]

        void RestoreTask(string taskName)
        {
           

            if (ItemsDeleted.Contains(taskName))
            {
                ItemsDeleted.Remove(taskName);
                TaskItems.Add(taskName);
            }
        }

        [RelayCommand]

        void RestoreAllTasks(string taskName)
        {
            foreach (string task in ItemsDeleted)
            {
                TaskItems.Add(task);
            }

            ItemsDeleted.Clear();
        }
    }
}

