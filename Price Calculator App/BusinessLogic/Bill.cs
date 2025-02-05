using System;

namespace Price_Calculator_App.BusinessLogic;

public class Bill
{
    // Fields
    private string _userName;
    private double _pricePerItem;
    private bool _addDiscount;
    private double _discountAmount;
    private int _numberOfItems;

    // Constants
    private const double taxRate = 0.13;

    // Constructors
    public Bill() { }

    public Bill(string userName, double pricePerItem, bool addDiscount, double discountAmount, int numberOfItems)
    {
        this._userName = userName;
        this._pricePerItem = pricePerItem;
        this._addDiscount = addDiscount;
        this._discountAmount = discountAmount;
        this._numberOfItems = numberOfItems;
    }

    // Properties
    public string UserName
    {
        get { return _userName; }
        set { _userName = value; }
    }

    public double PricePerItem
    {
        get { return _pricePerItem; }
        set
        {
            if (value > 0)
            {
                _pricePerItem = value;
            }
            else{ Console.WriteLine("Invalid: Price must be greater than zero");}
               
        }
    }

    public bool AddDiscount
    {
        get { return _addDiscount; }
        set { _addDiscount = value; }
    }

    public double DiscountAmount
    {
        get
        {
            return _addDiscount ? _discountAmount : 0.00;
        }
        set
        {
            if (value >= 0 && value <= 1)
            {
                // Ensure it's between 0 and 100%
                _discountAmount = value;
            }
            else{Console.WriteLine("Invalid: Discount must be between 0 and 1 (0-100%)");}
                
        }
    }

    public int NumberOfItems
    {
        get { return _numberOfItems; }
        set
        {
            if (value > 0)
            {
                _numberOfItems = value;
            }
            else{Console.WriteLine("Invalid: Number of items must be greater than zero");}
        }
    }
    
    public double Total
    {
        get
        {
            double priceWithTax = PricePerItem * (1 + taxRate); // Apply 13% tax
            double discountedPrice = priceWithTax; // Default price

            if (_addDiscount)
            {
                discountedPrice -= (DiscountAmount * PricePerItem); // Apply discount
            }

            return discountedPrice * NumberOfItems;
        }
    }

    // Functions
    public override string ToString()
    {
        return $"{UserName}, Your Total is: ${Total}";
    }

    public void ClearData()
    {
        UserName = string.Empty;
        PricePerItem = 0;
        DiscountAmount = 0.00;
        AddDiscount = false;
        NumberOfItems = 0;
    }
    
}