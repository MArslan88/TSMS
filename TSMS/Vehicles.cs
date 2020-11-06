using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Windows.Forms;


namespace TSMS
{
    public class Vehicles
    {
        public string Traffic_Dencity = "";
        
                
        public Vehicles(int Denc) //constructor with 1 perameter
        {
        }
        public Vehicles() // constructor with no parameter
        {

        }

        // methods
        public void Dencity(int Denc) 
        {           
           Traffic_Dencity = Denc.ToString();            
        }
        public string Vehicle_ID(string VehicleID)
        {
            return VehicleID;
        }
        public string Categories(string Category)
        {
            return Category;
        }
    }
}
