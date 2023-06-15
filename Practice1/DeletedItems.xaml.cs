using System.Collections.ObjectModel;

namespace Practice1;

public partial class DeletedItems : ContentPage
{
	public DeletedItems(ViewModel.DeletedTasksViewModel vm, string[] items)
	{
        ObservableCollection<string> itemsDeleted= new ObservableCollection<string>(items);
        InitializeComponent();
		vm.DeletedItems = itemsDeleted;
        BindingContext = vm;

    }
}
