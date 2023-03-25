using System.ComponentModel.DataAnnotations;

namespace ConsumptionCalculator.Calculators;

internal enum ComponentType
{
    [Display(Name = Constants.Volume)]
    Volume,

    [Display(Name = Constants.Distance)]
    Distance,

    [Display(Name = Constants.Hours)]
    Hours,

    [Display(Name = Constants.Index)]
    Index,

    [Display(Name = Constants.Total)]
    Total
}