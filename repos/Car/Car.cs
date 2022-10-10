namespace Car
{
    internal class Car : Tyre, ICar 
    {
        private  int Car_tyre = 0;
        private readonly string Car_color = "Blue";
        private readonly string Car_type = "SUV";
        private readonly string Logo = "BMW";
        private static Car? _car_Instance = null;
        public string Tyre_company;
        
    
        private Car(int car_tyre, string car_color, string car_type, string Logo,string TyreCompany)
            :base(TyreCompany)
        {
            this.Tyre_company = TyreCompany;
            Car_tyre = car_tyre;
            Car_color = car_color;
            Car_type = car_type;
            this.Logo = Logo;
        }

        public static Car getInstance(int car_tyre, string car_color, string car_type, string Logo, string TyreCompany)
        {
            if (_car_Instance == null)
            {
                _car_Instance = new Car(car_tyre,car_color,car_type,Logo, TyreCompany);    
            }
            return _car_Instance;
            
        }

        public void Assemble( string color, string type)
        {
            
            color = Car_color;
            type = Car_type;
            
        }
        public void Assemble(string color, string type,string subtype)
        {

            color = Car_color;
            type = Car_type;
            subtype = "HatchBag";

        }
        public void display()
        {
            Console.WriteLine("Car Details");
            Console.WriteLine("Car Logo:  " + Logo);
            Console.WriteLine("Car Color : " + Car_color);
            Console.WriteLine("Car Type : " + Car_type);
            Console.WriteLine("Car Tyre : " + Car_tyre);
            Console.WriteLine("Tyre Company : "+ Tyre_company);
            Console.WriteLine("Expiry Date Of Tyre : "+DateOfExpiry.ToString("yyyy"));

        }

        public override string CheckTyre(DateTime expiry)
        {
            try
            {
                if (expiry != DateTime.Now.AddYears(4))
                {
                    throw new ArgumentException("Expiration Period more than 4 years");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Years of expiry : " +DateOfExpiry);
                expiry = DateTime.Now;
                DateOfExpiry = expiry.AddYears(4);
            }
                
            if (Car_tyre == 6 || Car_tyre == 4)
                return Car_tyre.ToString();
            else
            {
                Console.WriteLine("Invalid No. Car Tyre : "+Car_tyre);
                Car_tyre = 4;
            }
            return Car_tyre.ToString();
        }
    }
}
