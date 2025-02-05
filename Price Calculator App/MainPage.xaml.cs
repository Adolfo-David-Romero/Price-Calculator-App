using System;
using Microsoft.Maui.Accessibility;
using Microsoft.Maui.Controls;
using Price_Calculator_App.BusinessLogic;

namespace Price_Calculator_App;

public partial class MainPage : ContentPage
{
    

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
    //Discount Button 
    private void OnDiscountBtnClicked(object sender, EventArgs e)
    {
        string userName = nameEntry.Text;
        int pricePerItem = int.Parse(priceEntry.Text);
        bool addDiscount = discountRbtn.IsChecked;
        double discountAmount = double.Parse(discountEntry.ToString());
        int numberOfItem = int.Parse(itemsEntry.Text);
        
        Bill bill = new Bill(userName, pricePerItem, addDiscount, discountAmount, numberOfItem);
        
        DiscountLabel.Text = $"{bill.ToString()}";

        SemanticScreenReader.Announce(DiscountLabel.Text);
    }
    //Clear Button
    private void OnClearBtnClicked(object sender, EventArgs e)
    {
        
        SemanticScreenReader.Announce(DiscountLabel.Text);
    }
    
}