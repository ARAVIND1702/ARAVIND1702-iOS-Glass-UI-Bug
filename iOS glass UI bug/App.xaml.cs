namespace iOS_glass_UI_bug;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		// Replicate iService5 pattern: NavigationPage wrapping a TabbedPage
		// No Shell — this matches how the Glass UI bug manifests in production apps
		var tabPage = new TabPageView();
		var navigationPage = new NavigationPage(tabPage);
		return new Window(navigationPage);
	}
}