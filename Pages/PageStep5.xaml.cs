namespace GymApp.Pages;

public partial class PageStep5 : ContentPage
{
	public PageStep5()
	{
		InitializeComponent();
	}

    private void ButtonNext_Click(object sender, EventArgs e)
    {
        if (entryHeight.Text == null || entryWeight.Text == null) DisplayAlert("Alert", "Enter your height and weight", "OK");
        else Navigation.PushAsync(new PageHomeGym());
    }
}