using CodingChallengeMauiApp.Views;

namespace CodingChallengeMauiApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("Oldphonepage", typeof(Oldphonepage));
    }
}
