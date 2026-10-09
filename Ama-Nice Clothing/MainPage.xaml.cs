namespace Ama_Nice_Clothing;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void btnShop_Click(object sender, EventArgs e)
    {
        await DisplayAlertAsync("Ama-Nice Clothing", "Welcome to our store!", "OK");
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}