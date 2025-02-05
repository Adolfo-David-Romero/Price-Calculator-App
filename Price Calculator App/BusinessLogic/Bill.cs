using System;

namespace Price_Calculator_App.BusinessLogic;

public class Bill
{
    //Feilds
    private string _userName;
    private double _pricePerItem;
    private bool _addDiscount;
    private double _discountAmount;
    private int _numberOfItems;

    
    //Constants
    private const double taxRate = 0.13;

    //Constructors 
    Bill() { }

    Bill(string userName, double pricePerItem, bool addDiscount, double discountAmount, int numberOfItems)
    {
        this._userName = userName;
        this._pricePerItem = pricePerItem;
        this._addDiscount = addDiscount;
        this._discountAmount = discountAmount;
        this._numberOfItems = numberOfItems;
    }
    

    //Properties
    public string UserName
    {
        get { return _userName; }
        set { _userName = value; }
    }
    public double PricePerItem {
        get {return _pricePerItem;}
        set{
            if (value > 0)
            {
                _pricePerItem = value;
            }
            else { Console.WriteLine("Invalid: Price must be greater than zero"); }
        }
    }

    public bool AddDiscount
    {
        get { return _addDiscount; }
        set { _addDiscount = value; }
    }

    public double DiscountAmount {
        get
        {
            if (_addDiscount) // if there is a discount added
            {
                return _discountAmount;
            }else { return 0.00; } //else, return 0
        }
        set
        {
            if (value > 0 && value <= 1) //Discount can only be between 0 and 100%
            {
                _discountAmount = value;
            }else { Console.WriteLine("Invalid: Discount must be greater than 0 AND less than 100"); }
            
        }
    }

    public int NumberOfItems
    {
        get {return _numberOfItems;}
        set{
            if (value > 0)
            {
                _numberOfItems = value;
            }
            else { Console.WriteLine("Invalid: Number of items must be greater than zero"); }
        }
    }
    public double Total
    {
        //Accessor property (read-only)
        /*TotalPrice (pricePerItem + Tax @13% ‐discount)* numberofItems*/
        get { return (PricePerItem + taxRate - DiscountAmount)* NumberOfItems; }
    }
    
    //Functions
    override public string ToString() { return $"{UserName}, Your Total is: ${Total}"; }
    
    
    

    
}