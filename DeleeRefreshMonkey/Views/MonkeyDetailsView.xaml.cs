using DeleeRefreshMonkey.ViewModels;

namespace DeleeRefreshMonkey.Views;

public partial class MonkeyDetailsView : ContentPage
{
	public MonkeyDetailsView(MonkeyDetailsViewModel vm)
	{
		
		InitializeComponent();
		this.BindingContext = vm;
	}
}