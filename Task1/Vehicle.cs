namespace Task1;

public class Vehicle
{
    protected string Brand;
    protected string Model;
    protected int Year;
    protected int Price;
    
    public Vehicle(string brand, string model, int year, int price)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
    }
    public string GetBrand() { return Brand;}
    public string GetModel() { return Model;}
    public int GetYear() { return Year;}
    public int GetPrice() { return Price;}
    
    public virtual string DisplayInfo() => $"Авто: {Brand}  {Model} {Year}\nЦіна: {Price} грн\n";
    public virtual double CalculateTax() => Price * 0.01;
    public virtual int GetMaxSpeed() => 100;
}