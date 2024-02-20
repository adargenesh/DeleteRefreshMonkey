using DeleeRefreshMonkey.ViewModels;
namespace DeleeRefreshMonkey.Views;

public partial class MonkeyDetailsViewView : ContentPage
{
	public MonkeyDetailsViewView(MonkeyDetailsViewModel vm)
	{
        InitializeComponent();
		this.BindingContext = vm;
	}
}