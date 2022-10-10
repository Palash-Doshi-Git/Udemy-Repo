using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Assembly
{
    internal class CarAssemble : Car_Manufacture , ICar_Properties
    {
        int Car_Quality = 0;
        int Car_Cost = 0;
        string Car_Logo = "Null";

        public void properties(int Car_Quality, int Car_Cost, int Car_Logo)
        {
            throw new NotImplementedException();
        }

                public void Car_Cost()
        {

        }
    }
}
