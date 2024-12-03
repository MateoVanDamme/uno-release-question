namespace webViewsWontLoad;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        this.Loaded += MainPage_Loaded;
    }

    private async void MainPage_Loaded(object sender, RoutedEventArgs e)
    {
        try
        {
            await this.webView.EnsureCoreWebView2Async();
        }
        catch (Exception ex) 
        {
            // %1 is not a valid Win32 application.
        }

    }
}
