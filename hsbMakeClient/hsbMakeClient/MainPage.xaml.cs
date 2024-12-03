namespace hsbMakeClient;

public class ShoppingItem { 
    public string Name { get; set; }
    public double Price { get; set; }
}

public sealed partial class MainPage : Page
{
    public List<ShoppingItem> Items = [
        new () { Name = "Bread", Price = 5.3 },
        new () { Name = "Potato", Price = 4.1 },
        new () { Name = "Water", Price = 1.9 }
    ];

    public MainPage()
    {
        this.InitializeComponent();
    }
}
