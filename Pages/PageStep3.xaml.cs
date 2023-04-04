namespace GymApp.Pages;

public partial class PageStep3 : ContentPage
{
	public PageStep3()
	{
		InitializeComponent();
        if (Classes.ClassHelper.ModeGender == 1)
        {
            ImageFemale.IsVisible = true;
            ImageMale.IsVisible = false;
        }
        if (Classes.ClassHelper.ModeGender == 2)
        {
            ImageFemale.IsVisible = false;
            ImageMale.IsVisible = true;
        }
    }

    private void ButtonHands_Clicked(object sender, EventArgs e)
    {
        btnHands.BackgroundColor = Color.FromArgb("#e3dfbc");
        btnSpine.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnTorso.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnLegs.BackgroundColor = Color.FromArgb("#FFFFFF");
        Navigation.PushAsync(new PageStep4());
    }

    private void ButtonSpine_Clicked(object sender, EventArgs e)
    {
        btnHands.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnSpine.BackgroundColor = Color.FromArgb("#e3dfbc");
        btnTorso.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnLegs.BackgroundColor = Color.FromArgb("#FFFFFF");
        Navigation.PushAsync(new PageStep4());
    }

    private void ButtonTorso_Clicked(object sender, EventArgs e)
    {
        btnHands.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnSpine.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnTorso.BackgroundColor = Color.FromArgb("#e3dfbc");
        btnLegs.BackgroundColor = Color.FromArgb("#FFFFFF");
        Navigation.PushAsync(new PageStep4());
    }

    private void ButtonLegs_Clicked(object sender, EventArgs e)
    {
        btnHands.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnSpine.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnTorso.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnLegs.BackgroundColor = Color.FromArgb("#e3dfbc");
        Navigation.PushAsync(new PageStep4());
    }
}