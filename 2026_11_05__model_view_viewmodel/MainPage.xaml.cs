using main.ViewModels;


namespace main
{
	public partial class MainPage:ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			BindingContext = new UserViewModel();
		}
	}
}
