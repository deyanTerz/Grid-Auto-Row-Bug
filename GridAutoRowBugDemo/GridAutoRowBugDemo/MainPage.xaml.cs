namespace GridAutoRowBugDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, System.EventArgs e)
    {
        Button button = (Button)sender;
        button.HeightRequest = button.HeightRequest == 100 ? 50 : 100;
    }
}

