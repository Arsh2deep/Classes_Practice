using static System.Net.Mime.MediaTypeNames;

namespace Classes_Practice
{
    public class Bike
    {
        string Brand;
        string Type;
        string Color;
        int NumberOfWheels;

        public Bike(string brand, string type, string color, int numberOfWheels)
        {
            Brand = brand;
            Type = type;
            Color = color;
            NumberOfWheels = numberOfWheels;
        }

        public string Brand1 { get => Brand; set => Brand = value; }
        public string Type1 { get => Type; set => Type = value; }
        public string Color1 { get => Color; set => Color = value; }
        public int NumberOfWheels1 { get => NumberOfWheels; set => NumberOfWheels = value; }

        public override string ToString()
        {
            return $"Brand: {Brand}: Type: {Type}: Coloe: {Color}: Number of Wheels:{NumberOfWheels}";

        }



    }
}