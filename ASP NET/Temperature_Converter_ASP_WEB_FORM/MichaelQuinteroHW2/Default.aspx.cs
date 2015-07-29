using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    //celsius to farenheit click event handler
    protected void ctof_Click(object sender, EventArgs e)
    { 
        //declare placeholders to hold variables
        decimal celsius;
        decimal farenheit = 0;
        //try to get the value
        try
        {
            /*°C  x  9/5 + 32 = °F
           (°F  -  32)  x  5/9 = °C */
            //take the value
            celsius = Decimal.Parse(tCelsius.Text);
            //perform the conversion formula on the value and round
            farenheit = (decimal)((Decimal.ToDouble(celsius) * (9 / 5.0)) + 32);
            farenheit = Math.Round(farenheit, 1);
            //convert the numeric value to a string as it ispassed back into the textbox
            tFarenheit.Text = farenheit.ToString();
            //disable the buttons and textboxes
            tCelsius.Enabled = false;
            tFarenheit.Enabled  = false;
            ftoc.Enabled = false;
            ctof.Enabled = false;
        }
        //if the input is invalid, raise an error
        catch( Exception ex)
        {
            error.Text = "Invalid Input for Celsius";
        }
        
    }
    //farenheit to celsius click event handler
    protected void ftoc_Click(object sender, EventArgs e)
    {
        //declare variables to hold the values
        decimal celsius = 0;
        decimal farenheit;
        //try to parse the textbox into farenheit
        try
        {
             /*°C  x  9/5 + 32 = °F
            (°F  -  32)  x  5/9 = °C */
            farenheit = Decimal.Parse(tFarenheit.Text);
            //perform the conversion formula on the value and round
            celsius = (decimal) ((Decimal.ToDouble(farenheit) - 32) * (5/9.0));
            celsius = Math.Round(celsius, 1);
            //convert the numeric value to a string as it ispassed back into the textbox
            tCelsius.Text = celsius.ToString();
            //disable the buttons and textboxes
            tCelsius.Enabled = false;
            tFarenheit.Enabled  = false;
            ftoc.Enabled = false;
            ctof.Enabled = false;
        }
            //print an error mesage on error
        catch( Exception ex)
        {
            error.Text = "Invalid Input for Farenheit";
        }
    }
    //clear button event handler
    protected void clear_Click(object sender, EventArgs e)
    {
        //clear the textboxes
        tCelsius.Text = "";
        tFarenheit.Text = "";
        //enable the buttons
        ftoc.Enabled = true;
        ctof.Enabled = true;
        //swag
    }
}