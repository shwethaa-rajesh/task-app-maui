using Practice1.ViewModel;

namespace Practice1;

public partial class MainPage : ContentPage
{
	int count = 0;
	MainViewModel instance;
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		instance = vm;
	}

	private void onCheckDeleteClicked(System.Object sender, System.EventArgs e)
	{
		Navigation.PushAsync(new DeletedItems(new DeletedTasksViewModel(), instance.DeletedItems.ToArray<string>()));
	}

    

}


