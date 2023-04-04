using GymApp.Classes;
namespace GymApp.Pages;

public partial class PageStep2 : ContentPage
{
	public PageStep2()
	{
		InitializeComponent();
	}

    private void ButtonFemale_Clicked(object sender, EventArgs e)
    {
        btnMale.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnFemale.BackgroundColor = Color.FromArgb("#e3dfbc");
        Classes.ClassHelper.ModeGender = 1;
    }

    private void ButtonMale_Clicked(object sender, EventArgs e)
    {
        btnFemale.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnMale.BackgroundColor = Color.FromArgb("#e3dfbc");
        Classes.ClassHelper.ModeGender = 2;
    }
    private void ButtonMove_Clicked(object sender, EventArgs e)
    {
        if (Classes.ClassHelper.ModeGender == 0) DisplayAlert("Alert", "Choose your gender", "OK");
        if (Classes.ClassHelper.ModeGender != 0) Navigation.PushAsync(new PageStep3());
    }
}