namespace ConsumptionCalculator.Calculators.Implementations;

internal class SortingCalculator : BaseCalculator, ICalculator
{
    public CalculatorType Type => CalculatorType.Sorting;

    public CategoryType Category => CategoryType.Gas;

    public string Name => Constants.Sorting;

    public double DefaultIndex { get; set; } = 0.15;

    public List<ComponentType> Components { get; } = new List<ComponentType> { ComponentType.Volume, ComponentType.Index, ComponentType.Total };
}