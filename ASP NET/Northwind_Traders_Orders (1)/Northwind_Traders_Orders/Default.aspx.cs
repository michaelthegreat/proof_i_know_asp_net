using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*
 * To Do:
 * 1. Print an error message on an unsuccesful Query
 * 2. Make a customer object from a selected drop down list
 * 3. Make an orders object from that customer
 * 4. Acquire all the order details from the orders object
 * 5. Displaythe total order cost for a selected object
 * 6. Make it so that the web app displays the order if there is only one item in thedrop down list
 *    andthat the drop down list disables thereafter.
 * */
public partial class Default : System.Web.UI.Page
{ 
    //On page initialization set the drop down list to empty
    //Before we populate it with a search query
    //Failure to do this will result in the list containing the 
    //Current query as well as the previous query
    protected void Page_Init(object sender, EventArgs e)
    {
        ddlCustomer.Items.Clear();

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            tbInput.Focus();
        }
        else
        {
            //To do: Print an error message on an unsuccesful query
        }


    }


    protected void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        string error_msg = " ";
        String customer = Query.Get_Customer((ddlCustomer.SelectedValue), error_msg);
       // Customer customer = Query.Get_Customer((ddlCustomer.SelectedValue), error_msg);
     
                
        if (customer != null)
        {
           string msg = Convert.ToString(ddlCustomer.SelectedItem.Text + " has orders totaling");
           lblMessage.Text = msg;            
            
          // lblMessage.Text = customer.CompanyName + " " + customer.CustomerID.ToString();
        }

        else
        {
                      
            lblMessage.Text = "Failed to retrieve customer object of value " + ddlCustomer.SelectedValue
            + error_msg;
        }
    }


    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }

    protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {
        lblMessage.Text = e.ToString();
    }

    // Computes the sum of order

    //protected void OrderDetails(object sender, EventArgs e)
    //{

    //    int or = Query.Get_OrderID((ddlCustomer.SelectedValue), error_msg);
    //    Decimal.Round(UnitPrice * Quantity, 2);
    //    Decimal discount_amt = Decimal.Round(base_cost * (Decimal)discount_amt, 2);
    //    Decimal net_cost = base_cost - discount_amt;


    //}




    }


}