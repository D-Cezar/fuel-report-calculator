namespace ConsumptionCalculator.Calculators.Implementations;

internal class EquipmentTransportCalculator : BaseCalculator, ICalculator
{
    public CalculatorType Type => CalculatorType.EquipmentTransport;

    public CategoryType Category => CategoryType.Diesel;

    public string Name => Constants.EquipmentTransport;

    public double DefaultIndex { get; set; } = 5;

    public List<ComponentType> Components { get; } = new List<ComponentType> { ComponentType.Hours, ComponentType.Index, ComponentType.Total };
}