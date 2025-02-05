using System;

namespace Price_Calculator_App.BusinessLogic;

public class Bill
{
    //Feilds
    private double _pricePerItem;
    private double _discount;
    private int _nummberOfItems;
    private bool _addDiscount; 
    private const double taxRate = 0.13;

    //Properties
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

    public double Discount {
        get {return _discount;}
        set
        {
            if (value > 0 && value <= 1) //Discount can only be between 0 and 100%
            {
                _discount = value;
            }else { Console.WriteLine("Invalid: Discount must be greater than 0 AND less than 100"); }
            
        }
    }

    public int NummberOfItems
    {
        get {return _nummberOfItems;}
        set{
            if (value > 0)
            {
                _nummberOfItems = value;
            }
            else { Console.WriteLine("Invalid: Number of items must be greater than zero"); }
        }
    }

    
}