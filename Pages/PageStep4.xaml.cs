namespace GymApp.Pages;

public partial class PageStep4 : ContentPage
{
	public PageStep4()
	{
		InitializeComponent();
	}

    private void btnNewbie_Clicked(object sender, EventArgs e)
    {
        btnNewbie.BackgroundColor = Color.FromArgb("#e3dfbc");
        btnKeepOn.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnAdvenced.BackgroundColor = Color.FromArgb("#FFFFFF");

    }

    private void btnKeepOn_Clicked(object sender, EventArgs e)
    {
        btnNewbie.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnKeepOn.BackgroundColor = Color.FromArgb("#e3dfbc");
        btnAdvenced.BackgroundColor = Color.FromArgb("#FFFFFF");

    }

    private void btnAdvenced_Clicked(object sender, EventArgs e)
    {
        btnNewbie.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnKeepOn.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnAdvenced.BackgroundColor = Color.FromArgb("#e3dfbc");

    }

    private void btnNext_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PageStep5());
    }
}