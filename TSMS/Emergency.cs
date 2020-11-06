using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSMS
{
    class Emergency
    {
        public string VehicleNo = "";


        public Emergency(int Denc) //constructor with 1 perameter
        {

        }
        public Emergency() // constructor with no parameter
        {

        }

        public void InspectEmergency(int Denc)
        {
            VehicleNo = Denc.ToString();            
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
