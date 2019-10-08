 using System.Collections.Generic;

namespace Dealerships.Models

{
    public class Car
    {
        public string MakeModel { get; set; }
        public int Price { get; set; }
        public int Miles { get; set; }
        public string Summary { get; set; }
        private static List <Car> _instances = new List <Car>();



        public Car(string makeModel, int price, int miles)
        {
            MakeModel = makeModel;
            Price = price;
            Miles = miles;
            _instances.Add(this);

        }
     
        public static List<Car> GetAll()
        {
        return _instances;
        }
        
        
        public static string MakeSound(string sound)
        {
            return "Our cars sound like " + sound;
        }

        public void SetPrice(int newPrice)
        {
        Price = newPrice;
        }
        public string GetMakeModel()
        {
        return MakeModel;
        }

        public int GetPrice()
        {
        return Price;
        }

        public int GetMiles()
        {
        return Miles;
        }

        public bool WorthBuying(int maxPrice)
        {
            return (Price < maxPrice);
        }

        public bool LowMileage(int maxMiles)
        {
            return (Miles < maxMiles);
        }
    }

}