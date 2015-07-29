using System;
using System.Collections.Generic;

using System.Web;


public class OrderDetail
{
    private int orderID;

    public int OrderID
    {
        get { return orderID; }
        set { orderID = value; }
    }
    private int unitPrice;

    public int UnitPrice
    {
        get { return unitPrice; }
        set { unitPrice = value; }
    }
    private int quantity;

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }
    private int discount;

    public int Discount
    {
        get { return discount; }
        set { discount = value; }
    }

    public OrderDetail()
    {

    }
}