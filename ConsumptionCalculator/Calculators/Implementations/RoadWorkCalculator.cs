namespace ConsumptionCalculator.Calculators.Implementations;

internal class RoadWorkCalculator : BaseCalculator, ICalculator
{
    public CalculatorType Type => CalculatorType.RoadWork;

    public CategoryType Category => CategoryType.Diesel;

    public string Name => Constants.RoadWork;

    public double DefaultIndex { get; set; } = 11.63;

    public List<ComponentType> Components { get; } = new List<ComponentType> { ComponentType.Hours, ComponentType.Index, ComponentType.Total };
}