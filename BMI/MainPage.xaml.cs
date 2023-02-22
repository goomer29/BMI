namespace BMI;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
	public void ButtonClicked(object sender, EventArgs e)
	{
		double result = whightStepper.Value / Math.Pow(hightSlider.Value / 100, 2);
        bmi.Text = "BMI result: "+(result).ToString("F2");
		if (result < 18.5)
		{
			bmi.TextColor = Color.FromArgb("#0000FF");

        }
		else if (result >= 18.5 && result < 25)
		{
            bmi.TextColor = Color.FromArgb("#008000");
        }
        else if (result >= 25 && result <= 29.9)
        {
            bmi.TextColor = Color.FromArgb("#FF0000");
        }
        else if (result >= 30 && result <= 39.9)
        {
            bmi.TextColor = Color.FromArgb("#800000");
        }
        else
        {
            bmi.TextColor = Color.FromArgb("#000000");
        }
    }
}

