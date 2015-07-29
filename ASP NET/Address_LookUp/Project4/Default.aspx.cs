using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{


    List<Addresses> addresses = new List<Addresses>();

    protected void Page_Load(object sender, EventArgs e)
    {
        //stupid
        
        //Declared a list of addresses
        //Session["addresses"] = new List<Addresses>();
        //List<Addresses> addresses = (List<Addresses>) Session["addresses"];
        if (Application["addresses"] == null)
        {
            string path = Server.MapPath("App_Data/Addresses.csv");
            using (StreamReader readFile = new StreamReader(path))
            {
                string line;
                while ((line = readFile.ReadLine()) != null)
                {
                    Addresses address = new Addresses(line);
                    //what does Add do

                    addresses.Add(address);

                }
            }
            //addresses.Sort();
        }
        else
        {
            addresses = (List<Addresses>)Application["addresses"];
        }

        //initialize the addresses
        Application["addresses"] = addresses;
        //loop through the addresses and add buttons
        //for the stupid things
        foreach(Addresses addr in addresses)
        {
            addButton(addr.lastName[0]);
        }
        //Don't do anything if we're posting back
        if (IsPostBack)
        {
            return;
        }
    }


    // Slide 16 from Project 4 slide
    protected void LinkButton1_Click(object sender, EventArgs e)
    {   //retrieve the first letter used
       LinkButton btn = (LinkButton)sender;
        string firstLetter = btn.ID.Substring(2, 1);
        // firstLetter = first letter of the last Name in the Address

        LinkButton lb = new LinkButton();
        lb.Text = firstLetter;
        lb.ID = "lb" + firstLetter;
        lb.Click += LinkButton1_Click;

        //get the addresses list from the session

        //clear the dropdown list
        ddlNames.Items.Clear();
        //clear the text
        lblMessage.InnerHtml = "";
        //Add a blank item
        ListItem li = new ListItem("Select Name", "");
        ddlNames.Items.Add(li);
        //Loop through the address book and add names if
        //and only if the first letter of the last name is the
        //letter that the user clicked
        if (Application["addresses"] != null)
        {
            foreach (Addresses address in addresses)
            {
                if (address.lastName[0] == firstLetter[0])
                {
                    li = new ListItem(address.lastName + " , " + address.firstName, address.printval);

                    ddlNames.Items.Add(li);


                }
            }
        } 
    }
    protected void ddlNames_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblMessage.InnerHtml = "";        

        //get the value of the text and split it so we can add
        //add a newline without exception
        string selected = ddlNames.SelectedValue;
        string[] split = selected.Split(new Char[] { '@' });

        //update the text
        foreach(string message in split)
        {
            lblMessage.InnerHtml += message;
            lblMessage.InnerHtml += "<br />";
        }


    }

    //add a letter if the first letter of th elast name exists
    // in our gangster data
    public void addButton(char firstCharacter)
    {
        //if theres a button for the last name then dont do anything
        if (FindControl("lb" + firstCharacter.ToString()) != null)
        { return; }
        //if not then add the button.
        //The id will be lb + firstcharacteroflastname
        else
        {
            LinkButton lb = new LinkButton();
            lb.Text =  firstCharacter.ToString();
            lb.ID = "lb" + firstCharacter.ToString();
            lb.Click += LinkButton1_Click;
            Panel1.Controls.Add(lb);
            Panel1.Controls.Add(new LiteralControl("&nbsp&nbsp"));
        }
       //lol
    }
}
