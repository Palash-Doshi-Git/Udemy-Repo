using System;

namespace Car
{
    public class Program 
    {
        
        static void Main(string[] avgs)
        {
            
            Car C = Car.getInstance(6,"Blue","Suv","BMW","Mrf");
            C.display();
            Car P = Car.getInstance(6, "Blue", "Tuv", "Lambo","MRF");
            P.display();
            Console.WriteLine(C.GetHashCode());
            Console.WriteLine(P.GetHashCode());
        }
       
    }


}