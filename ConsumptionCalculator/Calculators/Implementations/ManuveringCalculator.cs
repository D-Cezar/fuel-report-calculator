namespace ConsumptionCalculator.Calculators.Implementations;
internal class ManuveringCalculator : BaseCalculator, ICalculator
{
    public CalculatorType Type => CalculatorType.Manuvering;

    public CategoryType Category => CategoryType.Diesel;

    public string Name => Constants.Manuvering;

    public double DefaultIndex { get; set; } = 0.86;

    public List<ComponentType> Components { get; } = new List<ComponentType> { ComponentType.Volume, ComponentType.Distance, ComponentType.Index, ComponentType.Total };

}
