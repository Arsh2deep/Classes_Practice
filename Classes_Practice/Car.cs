namespace Classes_Practice
{
    public class Car
    {
        string _make;
        string _model;
        int _year;
        string _color;
        int _mileage;

        public Car(string make, string model, int year, string color, int mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Mileage = mileage;
        }

        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public string Color { get => _color; set => _color = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }

        public override string ToString()
        {
        return $"Make: {_make}: Model: {_model}: Year: {_year}: Mileage:{_mileage}";

        }

    }
    
}
