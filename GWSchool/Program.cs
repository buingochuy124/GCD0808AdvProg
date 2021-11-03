using System;

namespace People
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Person manager = new Person("Bui Ngoc Huy");
            RideBike rideBike = new RideBike("From Viet Nam");
            manager.ride(rideBike);
            Console.WriteLine(manager.Name);
            Console.WriteLine(rideBike.OriginBike);
            Console.ReadLine();
        }
    }
    class Person
    {
        private String _name;
        public Person()
        {

        }
        public Person(String name)
        {
            this._name = name;
        }
        public String Name
        {
            get
            {
                return _name;
            }
        }
        public void ride(RideBike ridebike)
        {
            ridebike.Ride(this);    
        }
    }
    class RideBike
    {
        private String originBike;

        public RideBike()
        {

        }
        public RideBike(String originBike)
        {
            this.originBike = originBike;
        }
        public String OriginBike
        {
            get
            {
                return originBike;
            }
        }
        public void Ride(Person person)
        {
            Console.WriteLine("person ride a bike");
        }
    }
}
