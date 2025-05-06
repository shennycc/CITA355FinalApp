using MyFirstMauiApp;
namespace MyFirstMauiApp;

public partial class LoginPage : ContentPage
{
    private const string SharedPassword = "1234";

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        if (PasswordEntry.Text == SharedPassword)
        {
            ErrorLabel.IsVisible = false;
            await Navigation.PushAsync(new StudentInfo());
        }
        else
        {
            ErrorLabel.Text = "Invalid password.";
            ErrorLabel.IsVisible = true;
        }
    }
}
