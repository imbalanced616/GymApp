using GymApp.Pages;

namespace GymApp;

public partial class PageStep1 : ContentPage
{
	public PageStep1()
	{
		InitializeComponent();
	}

    private void btnWeightLoss_Clicked(object sender, EventArgs e)
    {
        btnWeightLoss.BackgroundColor = Color.FromArgb("#e3dfbc");
        btnKeepingFit.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnBuildMuscle.BackgroundColor = Color.FromArgb("#FFFFFF");
        Navigation.PushAsync(new PageStep2());
    }

    private void btnKeepingFit_Clicked(object sender, EventArgs e)
    {
        btnWeightLoss.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnKeepingFit.BackgroundColor = Color.FromArgb("#e3dfbc");
        btnBuildMuscle.BackgroundColor = Color.FromArgb("#FFFFFF");
        Navigation.PushAsync(new PageStep2());
    }

    private void btnBuildMuscle_Clicked(object sender, EventArgs e)
    {
        btnWeightLoss.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnKeepingFit.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnBuildMuscle.BackgroundColor = Color.FromArgb("#e3dfbc");
        Navigation.PushAsync(new PageStep2());
    }
}