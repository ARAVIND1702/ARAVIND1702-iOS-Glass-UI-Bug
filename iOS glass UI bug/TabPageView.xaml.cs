namespace iOS_glass_UI_bug;

public partial class TabPageView : TabbedPage
{
    public TabPageView()
    {
        InitializeComponent();

        // Replicate iService5 pattern: set Title and IconImageSource in code
        // This is where the Glass UI bug manifests — PNG icons are loaded
        // asynchronously, causing the tab labels to be truncated on first render.

        var homePage = new HomePage
        {
            Title = "Repair",
            IconImageSource = "repair.png"
        };

        var bridgePage = new SearchPage
        {
            Title = "Bridge",
            IconImageSource = "bridge.png"
        };

        var historyPage = new FavoritesPage
        {
            Title = "History",
            IconImageSource = "history.png"
        };

        var settingsPage = new ProfilePage
        {
            Title = "Settings",
            IconImageSource = "settings.png"
        };

        Children.Add(homePage);
        Children.Add(bridgePage);
        Children.Add(historyPage);
        Children.Add(settingsPage);
    }
}
