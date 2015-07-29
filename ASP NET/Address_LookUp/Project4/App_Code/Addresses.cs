using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Addresses
/// </summary>
public class Addresses
{
    public String lastName;
    public String firstName;
    public String address1;
    public String address2;
    public String city;
    public String state;
    public String printval;
    public int zip;


    public Addresses(string line)
    {
        string[] info;
            info = line.Split(',');
            lastName = info[0];
            firstName = info[1];
            address1 = info[2];
            address2 = info[3];
            city = info[4];
            state = info[5];
            zip = int.Parse(info[6]);
            //printvalue is what we print in the label
            // "@" is a token that we will use to split the
           //string where we want a newline
            //because asp.net raises an exception if i use
           // \n or < br/> directly

            if (address2.Length >  1)
            {
                 printval = address1 + "@"
                          + address2 + "@"
                          + city + ", " + state
                          + " " + zip.ToString();
             }

            else
            {
                printval = address1 + "@"
                          + city + ", " + state
                          + " " + zip.ToString();
            }
            
        
    }

    public int CompareTo(Addresses other)
    {
        int result = string.Compare(this.state, other.state);
        return result;
    }



    /*
     * string selected_state = ddlState.SelectedValue;
ddlCity.Items.Clear();
ListItem li = new ListItem("", "");
ddlCity.Items.Add(li);
foreach (City city in cities)
{
if (city.state == selected_state)
{
li = new ListItem(city.name, city.name);
ddlCity.Items.Add(li);
}

     */
}

  