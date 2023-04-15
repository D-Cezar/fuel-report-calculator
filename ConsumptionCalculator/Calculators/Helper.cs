namespace ConsumptionCalculator.Calculators;

internal static class Helper
{
    public static List<ICalculator> GetCalculators()
    {
        var bla = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes());
        var blabla = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
            .Where(a => !a.IsAbstract && !a.IsInterface && a.GetInterfaces().Any(x => x.Name.Contains(typeof(ICalculator).Name)));
        var blablabla = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
            .Where(a => !a.IsAbstract && !a.IsInterface && a.GetInterfaces().Any(x => x.Name.Contains(typeof(ICalculator).Name)))
            .Select(a => (ICalculator)Activator.CreateInstance(a)).ToList();
        return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
            .Where(a => !a.IsAbstract && !a.IsInterface && a.GetInterfaces().Any(x => x.Name.Contains(typeof(ICalculator).Name)))
            .Select(a => (ICalculator)Activator.CreateInstance(a)).ToList();
    }
}