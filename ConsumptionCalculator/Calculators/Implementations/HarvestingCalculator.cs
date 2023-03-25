namespace ConsumptionCalculator.Calculators.Implementations;

internal class HarvestingCalculator : BaseCalculator, ICalculator
{
    public CalculatorType Type => CalculatorType.Harvesting;

    public CategoryType Category => CategoryType.Diesel;

    public string Name => Constants.Harvesting;

    public double DefaultIndex { get; set; } = 0.85;

    public List<ComponentType> Components { get; } = new List<ComponentType> { ComponentType.Volume, ComponentType.Distance, ComponentType.Index, ComponentType.Total };
}