using System.Globalization;

// Практика А
class City
{
    public string Name;
    public GeoLocation Location;
}
class GeoLocation
{
    public double Latitude;
    public double Longitude;
}
//Практика B
public class Employee
{
    public string name;
    public int Id;
    public string otdel;
    public string dolsnost;
    public Employee(string name, int id, string otdel, string dolsnost)
    {
        this.name = name;
        Id = id;
        this.otdel = otdel;
        this.dolsnost = dolsnost;
    }
}
// Задание 1. Сделайте так, чтобы код заработал! Для этого создайте недостающие классы City и GeoLocation.
void Main()
{
    var RabOne = new Employee("Artem", 01, "backend", "teacher");
    var RabTwo = new Employee("Dima", 02, "backend", "uchenik");
    var RabThree = new Employee("Ilia", 03, "backend", "uchenik");
    Console.WriteLine($"Сотрудник: {RabOne.name}, с номером: {RabOne.Id}, работает в отделе: {RabOne.otdel}, на должности: {RabOne.dolsnost}");
    Console.WriteLine($"Сотрудник: {RabTwo.name}, с номером: {RabTwo.Id}, работает в отделе: {RabTwo.otdel}, на должности: {RabTwo.dolsnost}");
    Console.WriteLine($"Сотрудник: {RabThree.name}, с номером: {RabThree.Id}, работает в отделе: {RabThree.otdel}, на должности: {RabThree.dolsnost}");
    var city = new City();  
    city.Name = "Ekaterinburg";
    city.Location = new GeoLocation();
    city.Location.Latitude = 56.50;
    city.Location.Longitude = 60.35;
    Console.WriteLine("I love {0} located at ({1}, {2})", 
        city.Name, 
        city.Location.Longitude.ToString(CultureInfo.InvariantCulture),
        city.Location.Latitude.ToString(CultureInfo.InvariantCulture));
}