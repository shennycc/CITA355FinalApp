namespace MyFirstMauiApp;

public partial class ExamPage : ContentPage
{
    public ExamPage()
    {
        InitializeComponent();
    }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        int score = 0;
        int total = 5;

        if (Q1B.IsChecked) score++;  // Correct: echo vs print
        if (Q2D.IsChecked) score++;  // Correct: Both a and c
        if (Q3B.IsChecked) score++;  // Correct: for loop
        if (Q4A.IsChecked) score++;  // Correct: session_start()
        if (Q5A.IsChecked) score++;  // Correct: cookie expires in 1 hour

        ResultLabel.Text = $"You answered {score} out of {total} questions correctly.";
        ResultLabel.IsVisible = true;
    }
}
