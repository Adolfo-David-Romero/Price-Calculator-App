namespace Price_Calculator_App;

public partial class MainPage : ContentPage
{
    int count = 0;
    

    public MainPage()
    {
        InitializeComponent();
    }

    /*private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }*/
    private void OnDiscountBtnClicked(object sender, EventArgs e)
    {
            
        DiscountTxt.Text = $"";

        SemanticScreenReader.Announce(DiscountTxt.Text);
    }
    private void OnDiscountClicked(object sender, EventArgs e)
    {
            
            DiscountTxt.Text = $"";

        SemanticScreenReader.Announce(DiscountTxt.Text);
    }
}