using Practice1.ViewModel;

namespace Practice1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage(new MainViewModel()));
	}
}

