namespace ConsumptionCalculator.Calculators.Implementations;

internal class LoadUnloadCalculator : BaseCalculator, ICalculator
{
    public CalculatorType Type => CalculatorType.LoadUnload;

    public CategoryType Category => CategoryType.Diesel;

    public string Name => Constants.LoadUnload;

    public double DefaultIndex { get; set; } = 0.17;

    public List<ComponentType> Components { get; } = new List<ComponentType> { ComponentType.Volume, ComponentType.Index, ComponentType.Total };
}