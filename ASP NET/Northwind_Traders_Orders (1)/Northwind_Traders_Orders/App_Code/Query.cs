using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web;

public static class Query
{
    //returns a customer object
    public static string Get_Customer(string companyName,  string error_msg)
    {
        //need a data reader and data connection
        SqlDataReader rdr = null;
        SqlConnection cn = null;
      //  Customer customer = null;
        string customer = "";
        error_msg = "";
        try
        {
            //set up the connectionad acquire a data readr
            cn = Setup_Connection();

            rdr = Get_CustomerReader(companyName, cn);
            //ifsuccesful thenset tenew customer
            if (rdr.HasRows)
            {
                rdr.Read();
                customer = ((string)rdr["CustomerID"]);
                //  customer = new Customer(rdr);
            }
            else
            {
                error_msg = "There are no customers name matching " + customer;
            }
        }
        catch (Exception ex)
        {
            error_msg = "ERROR: " + ex.Message;

        }

        finally
        {
            if (rdr != null)
            {
                rdr.Close();
            } 
            // EDIT: CLOSED THE rdr.Close() 

             if (cn != null)
             {
                 cn.Close();
             }
         }
        
        return customer;
    }//end function get customer

    //Sets up a sql connection to the database
    public static SqlConnection Setup_Connection()
    {
        string connection_string = WebConfigurationManager.ConnectionStrings["CustomerTable"].ConnectionString;

        SqlConnection cn = new SqlConnection(connection_string);

        cn.Open();
        return cn;
    }//End function setup connection

    /*
     * Index
     * 1. StoredProcedure1 => Returns Customer Reader with matching companyname
     * 2. StoredProcedure2 => Returns Orders Reader with matching customerID
     * 3. StoredProcedure3 => Returns Order Details reader with matching OrderID
     * */


    //Returns a reader to relevant customer information
    public static SqlDataReader Get_CustomerReader(string companyName, SqlConnection cn)
    {
        SqlDataReader reader;
        SqlCommand cmd = new SqlCommand();
        //query string
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "SELECT [CustomerID], [CompanyName] FROM [Customers] WHERE [CompanyName] = " + companyName;
        //@companyName";
        //cmd.Parameters.AddWithValue("@companyName",  companyName);

        //return query string
        cmd.Connection = cn;
        reader = cmd.ExecuteReader();
        return reader;
    }//end functin get customer reader

    //ret
    public static SqlDataReader Get_OrdersReader(string customerID, SqlConnection cn)
    {

        SqlCommand cmd = new SqlCommand();
        //query string
        cmd.CommandType = CommandType.StoredProcedure;
       // cmd.CommandText = "StoredProcedure2";
        cmd.CommandText = "SELECT [CustomerID] FROM [Customers] WHERE [CompanyName] = @customerID";
        cmd.Parameters.AddWithValue("@customerID", customerID);
        //return query string
        cmd.Connection = cn;
        return cmd.ExecuteReader();
    }//end functin get customer reader
    
    //Returns a reader to the order details
    public static SqlDataReader Get_OrderDetailsReader(string customerID, SqlConnection cn)
    {

        SqlCommand cmd = new SqlCommand();
        //query string
        cmd.CommandType = CommandType.StoredProcedure;
        //cmd.CommandTex = "StoredProcedure3";
        cmd.CommandText = "SELECT [OrderID] FROM [Orders] WHERE [OrderID] = @customerID";
        cmd.Parameters.AddWithValue("@customerID", customerID);
        //return query string
        cmd.Connection = cn;
        return cmd.ExecuteReader();
    }//end functin get customer reader

    public static SqlDataReader Get_OrderID(string orderID, SqlConnection cn)
    {

        SqlCommand cmd = new SqlCommand();
        //query string
        cmd.CommandType = CommandType.StoredProcedure;
        //cmd.CommandTex = "StoredProcedure3";
        cmd.CommandText = "SELECT [UnitPrice], [Quantity], [Discount] FROM [Order Detials] WHERE [OrderID] = @orderID";
        cmd.Parameters.AddWithValue("@orderID", orderID);
        //return query string
        cmd.Connection = cn;
        return cmd.ExecuteReader();
    }//end functin get customer reader
    /*
    private static void ReadOrderData(string connectionString)
    {
        string queryString =
            "SELECT OrderID, CustomerID FROM dbo.Orders;";

        using (SqlConnection connection =
                   new SqlConnection(connectionString))
        {
            SqlCommand command =
                new SqlCommand(queryString, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            // Call Read before accessing data. 
            while (reader.Read())
            {
                ReadSingleRow((IDataRecord)reader);
            }

            // Call Close when done reading.
            reader.Close();
        }
    }*/
}