using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Rx 
{
    public float rxID;
    public float rSphere;
    public float rCylinder;
    public float rAxis;
    public float rPrism;
    public float rBase;
    public float rAdd;
    public float rSeg;
    public float rpd;
    public float rnpd;
    public float lSphere;
    public float lCylinder;
    public float lAxis;
    public float lPrism;
    public float lBase;
    public float lAdd;
    public float lSeg;
    public float lpd;
    public float lnpd;
    
    public Rx(string line)
	{
        string[] info;
        info = line.Split(',');
        rxID = float.Parse(info[0]);
        rSphere = float.Parse(info[1]);
        rCylinder = float.Parse(info[2]);
        rAxis = float.Parse(info[3]);
        rPrism = float.Parse(info[4]);
        rBase = float.Parse(info[5]);
        rAdd = float.Parse(info[6]);
        rSeg = float.Parse(info[7]);
        rpd = float.Parse(info[8]);
        rnpd = float.Parse(info[9]);
        lSphere = float.Parse(info[10]);
        lCylinder = float.Parse(info[11]);
        lAxis = float.Parse(info[12]);
        lPrism = float.Parse(info[13]);
        lBase = float.Parse(info[14]);
        lAdd = float.Parse(info[15]);
        lSeg = float.Parse(info[16]);
        lpd = float.Parse(info[17]);
        lnpd = float.Parse(info[18]);

  	}


    // Use CompareTo function to compare if there is any data for rxID
    // Example: If user inputs rxID as 5 then the function dispalys
    // an error "There is no Rx with ID of 5" 

  //  public float CompareTo(Rx other)
 //   {
 //       float result = float.Compare(this.rxID, other.rxID);
  //      return result;
  //  }


}