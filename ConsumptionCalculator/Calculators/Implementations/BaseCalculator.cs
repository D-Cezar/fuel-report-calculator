namespace ConsumptionCalculator.Calculators.Implementations;

internal class BaseCalculator
{
    public List<Dictionary<ComponentType, double>> Data { get; set; } = new();

    public bool HasData
    {
        get
        {
            return Data.Any();
        }
    }

    public void AddOrUpdate(int index, Dictionary<ComponentType, double> record)
    {
        if (Data.Count <= index)
        {
            Data.Add(record);
        }
        else
        {
            Data[index] = record;
        }
    }

    public void Remove(int index)
    {
        if (Data.Count > index)
        {
            Data.RemoveAt(index);
        }
    }

    public double GetTotal()
    {
        return Data.Sum(x => x[ComponentType.Total]);
    }
}