using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Practice1.ViewModel
{
	public partial class DeletedTasksViewModel : ObservableObject
	{
		public DeletedTasksViewModel()
		{
			DeletedItems = new ObservableCollection<string>();
		}

		[ObservableProperty]
		ObservableCollection<string> deletedItems;

	}
}

