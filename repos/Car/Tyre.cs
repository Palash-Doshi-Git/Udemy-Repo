using System;

namespace Car
{
    
    class Tyre
    {
       public DateTime DateOfExpiry=  DateTime.Now.AddYears(4);
        public string tyre_Company ;

        public Tyre()
        {

        }
        public Tyre(string tyre_Company)
        {  
            this.tyre_Company = tyre_Company;
                
        }
        public virtual string CheckTyre(DateTime Date) { return Date.ToString("yyyy"); }
        public string  get_tyreCompany()
        {
            return tyre_Company ;

        }
    }
}

