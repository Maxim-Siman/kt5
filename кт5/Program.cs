interface IAnimal
{
    string Name { get; set; }
    void MakeSound();
}
interface IShape
{
    double Area { get; }
    double Perimeter { get; }
}
public class Circle : IShape
{
    public double Radius { get; set; }
    public double Area => Math.PI * Radius * Radius;
    public double Perimeter => 2 * Math.PI * Radius;
}
public class Rectangle : IShape
{
    public double Width { get; }
    public double Height { get; }
    public double Area => Width * Height;
    public double Perimeter => 2 * (Width + Height);
}
public class Triangle : IShape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }
    public double Area
    {
        get
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
    public double Perimeter => A + B + C;
}
public class Dog : IAnimal
{

    public string Name { get ; set ; }

    public void MakeSound()
    {
        Console.WriteLine($"собакен по имени {Name} сказала гав гав");
    }
}
public class Cat : IAnimal
{
    public string Name { get; set; }
    public void MakeSound()
    {
        Console.WriteLine($"кошка по имени {Name} сказала мяу");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Cat cat = new Cat();
        cat.Name = "Барсик";
        Dog dog = new Dog();
        dog.Name = "Лайка";
        cat.MakeSound();
        dog.MakeSound();

    }
}