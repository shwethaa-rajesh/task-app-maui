using System.Collections.ObjectModel;

namespace Practice1;

public partial class DeletedItems : ContentPage
{
	public DeletedItems(ViewModel.DeletedTasksViewModel vm, ObservableCollection<string> allItems, ObservableCollection<string> items)
	{
        InitializeComponent();
		vm.ItemsDeleted = items;
        vm.TaskItems = allItems;
        BindingContext = vm;

    }
}
