


namespace Dealership.Models
{
    class Car
    {
        private string _MakeModel;
        private int _Price;
        private int _Miles;
        private string _Summary;

        public Car(string makeModel, int price, int miles, string summary)
        {
            _MakeModel = makeModel;
            _Price = price;
            _Miles = miles;
            _Summary = summary;
        }

        public static string MakeSound(string sound)
        {
            return "Our cars sound like " + sound;
        }

        public void SetPrice(int newPrice)
        {
        _Price = newPrice;
        }
        public string GetMakeModel()
        {
        return _MakeModel;
        }

        public int GetPrice()
        {
        return _Price;
        }

        public int GetMiles()
        {
        return _Miles;
        }

        public bool WorthBuying(int maxPrice)
        {
            return (_Price < maxPrice);
        }

        public bool LowMileage(int maxMiles)
        {
            return (_Miles < maxMiles);
        }
    }

}