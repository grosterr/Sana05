namespace Task1;

public class Truck : Vehicle
{
    protected int LoadCapacity;
    protected int NumberOfAxies;
    
    public Truck(string brand, string model, int year, int price, int loadCapacity, int numberOfAxies) : base(brand, model, year, price)
    {
        LoadCapacity = loadCapacity;
        NumberOfAxies = numberOfAxies;
    }
    public int GetLoadCapacity() { return LoadCapacity;}
    public int GetNumberOfAxies() { return NumberOfAxies;}
    public override double CalculateTax() => Price * 0.02 + GetLoadCapacity() * 1000;
    public override string DisplayInfo()
    {
        return $"Вантажівка: {GetBrand()} {GetModel()} {GetYear()}\nЦіна: {GetPrice()} грн\nВантажопідйомність: {GetLoadCapacity()} тонн\nКількість осей: {GetNumberOfAxies()}\nМаксимальна швидкість: {GetMaxSpeed()} км/год\nТранспортний податок:{CalculateTax()} грн\n";
    }

    public override int GetMaxSpeed() => 120;
}