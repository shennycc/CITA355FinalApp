namespace MyFirstMauiApp;

public partial class StudentInfo : ContentPage
{
    public StudentInfo()
    {
        InitializeComponent();
    }

    private async void OnStartTestClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(StudentIdEntry.Text) ||
            string.IsNullOrWhiteSpace(FirstNameEntry.Text) ||
            string.IsNullOrWhiteSpace(LastNameEntry.Text) ||
            string.IsNullOrWhiteSpace(EmailEntry.Text))
        {
            ErrorLabel.Text = "Please fill in all fields.";
            ErrorLabel.IsVisible = true;
            return;
        }

        ErrorLabel.IsVisible = false;

        // Navigate to Exam Page (we’ll build this next)
        await Navigation.PushAsync(new ExamPage());
    }
}
