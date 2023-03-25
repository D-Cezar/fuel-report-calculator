namespace ConsumptionCalculator.Calculators.Implementations;

internal class LoggingCalculator : BaseCalculator, ICalculator
{
    public CalculatorType Type => CalculatorType.Logging;

    public CategoryType Category => CategoryType.Gas;

    public string Name => Constants.Logging;

    public double DefaultIndex { get; set; } = 0.18;

    public List<ComponentType> Components { get; } = new List<ComponentType> { ComponentType.Volume, ComponentType.Index, ComponentType.Total };
}