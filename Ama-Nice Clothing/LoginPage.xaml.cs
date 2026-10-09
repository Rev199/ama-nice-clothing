namespace Ama_Nice_Clothing;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text?.Trim() ?? "";
        string password = txtPassword.Text ?? "";

        if (username == "" || password == "")
        {
            await DisplayAlertAsync("Login", "Please enter your username and password.", "OK");
            return;
        }

        await DisplayAlertAsync("Login", $"Welcome, {username}!", "OK");
    }

    private void OnTogglePassword(object sender, TappedEventArgs e)
    {
        txtPassword.IsPassword = !txtPassword.IsPassword;
    }

    private async void OnForgotPassword(object sender, TappedEventArgs e)
    {
        await DisplayAlertAsync("Forgot Password", "Password reset coming soon.", "OK");
    }

    private async void OnSignUp(object sender, TappedEventArgs e)
    {
        await DisplayAlertAsync("Sign Up", "Sign up page coming soon.", "OK");
    }
}