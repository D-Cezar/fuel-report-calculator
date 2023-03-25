namespace ConsumptionCalculator.Calculators;
internal interface ICalculator
{
    CalculatorType Type { get; }

    CategoryType Category { get; }

    string Name { get; }

    double DefaultIndex { get; set; }

    List<ComponentType> Components { get; }

    List<Dictionary<ComponentType, double>> Data { get; set; }

    bool HasData { get; }

    void AddOrUpdate(int index, Dictionary<ComponentType, double> record);

    void Remove(int index);

    double GetTotal();
}
