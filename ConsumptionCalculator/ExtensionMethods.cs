using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ConsumptionCalculator;

internal static class ExtensionMethods
{
    public static string GetEnumDisplayName(this Enum enumType)
    {
        return enumType.GetType().GetMember(enumType.ToString())
                       .FirstOrDefault()?
                       .GetCustomAttribute<DisplayAttribute>()!
                       .Name ?? enumType.ToString();
    }
}