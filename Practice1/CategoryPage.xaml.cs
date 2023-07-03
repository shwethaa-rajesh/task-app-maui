using Practice1.ViewModel;

namespace Practice1;

public partial class CategoryPage : ContentPage
{
	public CategoryPage(CategoryPageVM vm) 
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
