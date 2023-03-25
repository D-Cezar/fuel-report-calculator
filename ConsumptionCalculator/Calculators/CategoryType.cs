using System.ComponentModel.DataAnnotations;

namespace ConsumptionCalculator.Calculators;

internal enum CategoryType
{
    [Display(Name = Constants.Diesel)]
    Diesel,

    [Display(Name = Constants.Gas)]
    Gas
}