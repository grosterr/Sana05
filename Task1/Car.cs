namespace Task1;

public class Car : Vehicle
{
    protected int NumberOfDoors;
    protected string FuelType;
    
    public Car(string brand, string model, int year, int price, int numberOfDoors, string fuelType) : base(brand, model, year, price)
    {
        NumberOfDoors = numberOfDoors;
        FuelType = fuelType;
    }
    public int GetNumberOfDoors() { return NumberOfDoors;}
    public string GetFuelType() { return FuelType;}

    public override double CalculateTax()
    {
        if (FuelType == "Electric") return Price * 0.005;
        else return Price * 0.03;
    }
    public override string DisplayInfo()
    {
        return $"Легковий автомобіль {GetBrand()} {GetModel()} {GetYear()}\nЦіна: {GetPrice()}\nКількість дверей: {GetNumberOfDoors()}\nТип палива: {GetFuelType()}\nМаксимальна швидкість {GetMaxSpeed()} км/год\nТранспортний податок: {CalculateTax()} грн\n";
    }

    public override int GetMaxSpeed() => 180;
}