namespace ConsumptionCalculator.Calculators.Implementations;

internal class CutingCalculator : BaseCalculator, ICalculator
{
    public CalculatorType Type => CalculatorType.Cuting;

    public CategoryType Category => CategoryType.Gas;

    public string Name => Constants.Cuting;

    public double DefaultIndex { get; set; } = 0.15;

    public List<ComponentType> Components { get; } = new List<ComponentType> { ComponentType.Volume, ComponentType.Index, ComponentType.Total };
}