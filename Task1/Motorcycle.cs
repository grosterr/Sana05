namespace Task1;

public class Motorcycle : Vehicle
{
    protected int EngineVolume;
    protected bool HasWindshield;
    
    public Motorcycle(string brand, string model, int year, int price, int engineVolume, bool hasWindshield) : base(brand, model, year, price)
    {
        EngineVolume = engineVolume;
        HasWindshield = hasWindshield;
    }
    public int GetEngineVolume() { return EngineVolume;}
    public bool GetHasWindshield() { return HasWindshield;}
    public override double CalculateTax() => Price * 0.008 + GetEngineVolume() * 0.5;
    public override int GetMaxSpeed() => 200;
    public override string DisplayInfo()
    {
        return $"Мотоцикл: {GetBrand()} {GetModel()} {GetYear()}\nЦіна: {GetPrice()}\nОб'єм двигуна в см³: {GetEngineVolume()}\nНаявність вітрового скла: {GetHasWindshield()}\nТранспортний податок: {CalculateTax()}\n";
    }
}