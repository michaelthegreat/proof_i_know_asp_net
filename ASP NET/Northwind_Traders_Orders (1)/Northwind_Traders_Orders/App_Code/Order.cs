using System;
using System.Collections.Generic;

using System.Web;


public class Order
{
    private int orderID;
    public int OrderID
    {
        get { return orderID; }
        set { orderID = value; }
    }
    private int customerID;

    public int CustomerID
    {
        get { return customerID; }
        set { customerID = value; }
    }
    public Order()
    {



    }
}