using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RX : System.Web.UI.UserControl
{
    public string _rx_id = " ";
    public string _rx_rSphere = " ";
    public string _rx_rCylinder = " ";
    public string _rx_rAxis = " ";
    public string _rx_rPrism = " ";
    public string _rx_rBase = " ";
    public string _rx_rAdd = " ";
    public string _rx_rSeg = " ";
    public string _rx_rPD = " ";
    public string _rx_rNPD = " ";

    public string _rx_lSphere = " ";
    public string _rx_lCylinder = " ";
    public string _rx_lAxis = " ";
    public string _rx_lPrism = " ";
    public string _rx_lBase = " ";
    public string _rx_lAdd = " ";
    public string _rx_lSeg = " ";
    public string _rx_lPD = " ";
    public string _rx_lNPD = " ";


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string Rx_ID
    {
        get
        {
            return _rx_id;
        }
        set
        {
           _rx_id = value;
        }
    }


    // Right Eye

    public string Rx_rSphere
    {
        get
        {
            return _rx_rSphere;
        }

        set
        {
            _rx_rSphere = value;    
        }
    }

    public string Rx_rCylinder
    {
        get
        {
            return _rx_rCylinder;
        }

        set
        {
            _rx_rCylinder = value;
        }
    }


    public string Rx_rAxis
    {
        get
        {
            return _rx_rAxis;
        }

        set
        {
            _rx_rAxis = value;
        }
    }

    public string Rx_rPrism
    {
        get
        {
            return _rx_rPrism;
        }

        set
        {
            _rx_rPrism = value;
        }
    }

    public string Rx_rBase
    {
        get
        {
            return _rx_rBase;
        }

        set
        {
            _rx_rBase = value;
        }
    }

    public string Rx_rAdd
    {
        get
        {
            return _rx_rAdd;
        }

        set
        {
            _rx_rAdd = value;
        }
    }

    public string Rx_rSeg
    {
        get
        {
            return _rx_rSeg;
        }

        set
        {
            _rx_rSeg = value;
        }
    }

    public string Rx_rPD
    {
        get
        {
            return _rx_rPD;
        }

        set
        {
            _rx_rPD = value;
        }
    }

    public string Rx_rNPD
    {
        get
        {
            return _rx_rNPD;
        }

        set
        {
            _rx_rNPD = value;
        }
    }


    // Left Eye

    public string Rx_lSphere
    {
        get
        {
            return _rx_lSphere;
        }

        set
        {
            _rx_lSphere = value;
        }
    }

    public string Rx_lCylinder
    {
        get
        {
            return _rx_lCylinder;
        }

        set
        {
            _rx_lCylinder = value;
        }
    }


    public string Rx_lAxis
    {
        get
        {
            return _rx_lAxis;
        }

        set
        {
            _rx_lAxis = value;
        }
    }

    public string Rx_lPrism
    {
        get
        {
            return _rx_lPrism;
        }

        set
        {
            _rx_lPrism = value;
        }
    }

    public string Rx_lBase
    {
        get
        {
            return _rx_lBase;
        }

        set
        {
            _rx_lBase = value;
        }
    }

    public string Rx_lAdd
    {
        get
        {
            return _rx_lAdd;
        }

        set
        {
            _rx_lAdd = value;
        }
    }

    public string Rx_lSeg
    {
        get
        {
            return _rx_lSeg;
        }

        set
        {
            _rx_lSeg = value;
        }
    }

    public string Rx_lPD
    {
        get
        {
            return _rx_lPD;
        }

        set
        {
            _rx_lPD = value;
        }
    }

    public string Rx_lNPD
    {
        get
        {
            return _rx_lNPD;
        }

        set
        {
            _rx_lNPD = value;
        }
    }



}
