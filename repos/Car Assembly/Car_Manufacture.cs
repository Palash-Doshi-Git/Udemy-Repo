using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Assembly
{
    internal class Car_Manufacture
    {
        
        int H_Tyre_Cost = 3000;

        int L_Body_Cost = 50000;
        int H_Body_Cost = 70000;

        int L_Engine = 70000;
        int H_Engine = 100000;
        int Car_Tyre=0;
        int Car_Body=0;
        int Car_Engine = 0;
        public void car_Assemble()
        {
            Console.WriteLine("Select Car Parts");
            Console.WriteLine("Select Car Tyres \n 1 -  Low Quality - 1000 \n 2 -  High Quality  - 3000");
            Car_Tyre = int.Parse(Console.ReadLine());
            Console.WriteLine("Select Car Body \n 1 -  Low Quality - 50000 \n 2 -  High Quality  - 70000");
            Car_Body = int.Parse(Console.ReadLine());
            Console.WriteLine("Select Car Engine \n 1 -  Low Quality - 70000 \n 2 -  High Quality  - 100000");
            Car_Engine = int.Parse(Console.ReadLine());


            // Switch for Car Tyre
            switch (Car_Tyre)
            {
                case 1: 
                    int L_Tyre_Cost = 1000;
                    break;
                case 2: int H_Tyre_Cost = 

            }
        }

        



    }
}
