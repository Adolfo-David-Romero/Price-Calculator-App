namespace Price_Calculator_App;
using System;
using Microsoft.Maui.Accessibility;
using Microsoft.Maui.Controls;
using Price_Calculator_App.BusinessLogic;
using System.Collections.Generic;



public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // Handle Picker Selection Change
    private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        if (discountPicker.SelectedIndex != -1)
        {
            double selectedDiscount = (double)discountPicker.SelectedItem;
            DiscountLabel.Text = $"Selected Discount: {selectedDiscount * 100}%";
        }
    }

    // Handle Discount Button Click
    private void OnDiscountBtnClicked(object sender, EventArgs e)
    {
        try
        {
            string userName = nameEntry.Text;
            int pricePerItem = int.Parse(priceEntry.Text);
            int numberOfItems = int.Parse(itemsEntry.Text);
            bool addDiscount = discountRbtn.IsChecked;

            // Use selected discount from the Picker
            double discountAmount = discountPicker.SelectedItem != null ? (double)discountPicker.SelectedItem : 0.0;

            // Create Bill object
            Bill bill = new Bill(userName, pricePerItem, addDiscount, discountAmount, numberOfItems);

            // Display the total price
            DiscountLabel.Text = $"Total Price: {bill.Total.ToString("C")}"; // Format as currency

            // Announce result for accessibility
            SemanticScreenReader.Announce(DiscountLabel.Text);
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", "Invalid input. Please check your values.", "OK");
        }
    }

    // Clear Button Logic
    private void OnClearBtnClicked(object sender, EventArgs e)
    {
        nameEntry.Text = "";
        priceEntry.Text = "";
        itemsEntry.Text = "";
        discountRbtn.IsChecked = false;
        discountPicker.SelectedIndex = -1;
        DiscountLabel.Text = "Total Price: ";

        SemanticScreenReader.Announce(DiscountLabel.Text);
    }
}

