using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NorthwindModel;
using System.Data.Entity;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Ignores selection of first item
        if (DropDownList1.SelectedIndex == 0)
        {
            return;
        }

        int ddlValue = 0;
        int countOrder = 0;
        var supplier = DropDownList1.SelectedItem.Text;

        using (NorthwindEntities myEntities = new NorthwindEntities())
        {
            Decimal total_value = 0.0M;
            ddlValue = int.Parse(DropDownList1.SelectedValue);

            // Outputs orders where supplierID in Product table is same as supplierID selected in the dropdown list 
            var productOrdersCount =
                from product in myEntities.Products
                where product.SupplierID == ddlValue
                select product;

        

            // Matches the ProductID from order_detail table to ProductID from Products table
            foreach (Product order in productOrdersCount)                  
            {
                // Output orders where productID in order_details table is same as productID calculated in productOrdersCount
                var order_details =
                    from order_detail in myEntities.Order_Details
                    where order_detail.ProductID == order.ProductID
                    select order_detail;
                
                // for each order_detail obtained from order_details calculate the total value by calling Order_Detail_Value function
                foreach (var order_detail in order_details)
                {
                    total_value += Order_Detail_Value(order_detail);
                    countOrder++;
                }
            }

            // Outputs the supplier information along with the total order and its cost
            lblMessage.Text = string.Format("Supplier {0} has {1} order items worth {2}", supplier, countOrder, total_value.ToString("C2"));
        }
    }
    
    // Calculates the sum of total order_detail_value using the formula to compute the total items worth
    private Decimal Order_Detail_Value(Order_Detail od)
    {
        Decimal discount = (Decimal)od.Discount;
        Decimal value = Decimal.Round((od.Quantity * od.UnitPrice) * (1.0M - discount), 2);
        return value;
    }
}