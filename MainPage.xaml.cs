using Microsoft.Maui.Controls;

namespace OPC_Inlamning3_AK;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Klickat {count} gång";
		else
			CounterBtn.Text = $"Klickat {count} gånger";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
    private void ExtraClick(object sender, EventArgs e)
    {
		ExtraBtn.Text = $"Be Happy!";
    }
}

