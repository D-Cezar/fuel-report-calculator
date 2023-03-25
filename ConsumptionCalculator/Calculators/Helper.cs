namespace ConsumptionCalculator.Calculators;

internal static class Helper
{
    public static List<ICalculator> GetCalculators()
    { 
        return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
            .Where(a => !a.IsAbstract && !a.IsInterface && a.GetInterfaces().Any(x => x.Name.Contains(typeof(ICalculator).Name)))
            .Select(a => (ICalculator)Activator.CreateInstance(a)).ToList();
    }
}