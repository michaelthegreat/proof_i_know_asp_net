using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;


public class Customer
{
    private int customerID;
    public int CustomerID
    {
        get { return customerID; }
    }

    private string companyName;
    public string CompanyName
    {
        get { return companyName; }
        set { companyName = value; }
    }
    public Customer(SqlDataReader rdr)
    {
        customerID = (int)rdr["CustomerID"];
        companyName = (string)rdr["CompanyName"];
    }

}