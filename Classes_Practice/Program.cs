namespace Classes_Practice;
class Program
{
    static void Main(string[] args)
    {

        Car car = new Car("Toyota","Camry",2020,"Blue",5000);
        //Display
        Console.WriteLine(car);

        Bike bike = new Bike("Trek","Mountain","Red",2);
        //Display
        Console.WriteLine(bike);
        
        Hobby hobby = new Hobby("Photography", "Capturing moments through the lens",20);
        //Display
        Console.WriteLine(hobby);

    }

}


