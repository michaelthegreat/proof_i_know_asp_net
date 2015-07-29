using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    List<Rx> Rxs = new List<Rx>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if(Application["lastSelect"] == null) Application["lastSelect"] = 0;
        //If We havent initialized the list of prescriptions 
        //do so
        if (Application["Rxs"] == null)
        {
            //where the data is
            string path = Server.MapPath("App_Data/Rx.csv");
            //Read a line from the data file until we finish
            using (StreamReader readFile = new StreamReader(path))
            {
                readFile.ReadLine();
                string line;
                while ((line = readFile.ReadLine()) != null)
                {
                    Rx display_rx = new Rx(line);
                    Rxs.Add(display_rx);
                }
            }
        }

        else
        {
            Rxs = (List<Rx>)Application["Rxs"];
        }

        Application["Rxs"] = Rxs;
        //If the user postbacked we dont have much to do.
        if (IsPostBack)
        {
            return;
        }
    }

    protected void displayRx_Click(object sender, EventArgs e)
    {

        // Outputs the value from TextBox to display as message (Doesn't Work)
        if (Page.IsValid)
        {
            //get the user input
            string selected_id = tbRxId.Text;
            int selected = int.Parse( selected_id);
            //Store the last selected value so I can recopy the user's values if he posts back with
            //an invalid form
            Application["lastSelect"] = selected;
            //Search through the list of prescriptions. 
            //Initially, the prescription is not found
            bool found = false;
            if (Application["RXs"] != null)
            {
               List<Rx> RXs = (List<Rx>)Application["RXs"];
                foreach (Rx rx in RXs)
                {
                    //If the prescription is found, use it to update the table
                    if (rx.rxID == selected)
                    {
                        Label3.Text = "Rx ID " + rx.rxID;
                        RX1.Rx_rSphere = rx.rSphere.ToString();
                        RX1.Rx_rCylinder = rx.rCylinder.ToString();
                        RX1.Rx_rAxis = rx.rAxis.ToString();
                        RX1.Rx_rPrism = rx.rPrism.ToString();
                        RX1.Rx_rBase = rx.rBase.ToString();
                        RX1.Rx_rAdd = rx.rAdd.ToString();
                        RX1.Rx_rSeg = rx.rSeg.ToString();
                        RX1.Rx_rPD = rx.rpd.ToString();
                        RX1.Rx_rNPD = rx.rnpd.ToString();
                        RX1.Rx_lSphere = rx.lSphere.ToString();
                        RX1.Rx_lCylinder = rx.lCylinder.ToString();
                        RX1.Rx_lAxis = rx.lAxis.ToString();
                        RX1.Rx_lPrism = rx.lPrism.ToString();
                        RX1.Rx_lBase = rx.lBase.ToString();
                        RX1.Rx_lAdd = rx.lAdd.ToString();
                        RX1.Rx_lSeg = rx.lSeg.ToString();
                        RX1.Rx_lPD = rx.lpd.ToString();
                        RX1.Rx_lNPD = rx.lnpd.ToString();
                        found = true;
                        Label1.Text = "";
                    }
                }
            }
            if (!found)
            {
                Label3.Text = "Rx ID";
                Label1.Text = "There is no Rx with ID of " + selected_id;
            }
        }
        else
        {
            //If the user posts back with invalid input I want to copy
            //the old info back into the table
            int selected = (int) Application["lastSelect"];
            //Search through the list of prescriptions and update the information
            if (Application["RXs"] != null)
            {
                List<Rx> RXs = (List<Rx>)Application["RXs"];
                foreach (Rx rx in RXs)
                {
                    if (rx.rxID == selected)
                    {
                        Label3.Text = "Rx ID " + rx.rxID;
                        RX1.Rx_rSphere = rx.rSphere.ToString();
                        RX1.Rx_rCylinder = rx.rCylinder.ToString();
                        RX1.Rx_rAxis = rx.rAxis.ToString();
                        RX1.Rx_rPrism = rx.rPrism.ToString();
                        RX1.Rx_rBase = rx.rBase.ToString();
                        RX1.Rx_rAdd = rx.rAdd.ToString();
                        RX1.Rx_rSeg = rx.rSeg.ToString();
                        RX1.Rx_rPD = rx.rpd.ToString();
                        RX1.Rx_rNPD = rx.rnpd.ToString();
                        RX1.Rx_lSphere = rx.lSphere.ToString();
                        RX1.Rx_lCylinder = rx.lCylinder.ToString();
                        RX1.Rx_lAxis = rx.lAxis.ToString();
                        RX1.Rx_lPrism = rx.lPrism.ToString();
                        RX1.Rx_lBase = rx.lBase.ToString();
                        RX1.Rx_lAdd = rx.lAdd.ToString();
                        RX1.Rx_lSeg = rx.lSeg.ToString();
                        RX1.Rx_lPD = rx.lpd.ToString();
                        RX1.Rx_lNPD = rx.lnpd.ToString();


                    }
                }    // Do Nothing

            }
        }
    }
}

