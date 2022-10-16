using CodingChallengeMauiApp.Models;

namespace CodingChallengeMauiApp.Views;

public partial class Oldphonepage : ContentPage
{
	public Oldphonepage()
	{
		InitializeComponent();
	}

    public void inputLetter_TextChanged(object sender, TextChangedEventArgs e)
	{
		var oldphone = new OldPhone();
        if (inputLetter.Text.Contains("#"))
            lbScreen.Text = oldphone.OldPhonePad(inputLetter.Text);
    }
}