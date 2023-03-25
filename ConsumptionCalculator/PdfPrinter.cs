using ConsumptionCalculator.Calculators;
using Gehtsoft.PDFFlow.Builder;
using Gehtsoft.PDFFlow.Models.Enumerations;

namespace ConsumptionCalculator;

internal static class PdfPrinter
{
    public static void SavePdf(string name, string title, Settings settings, List<ICalculator> calculators)
    {
        var document = DocumentBuilder.New();
        var section = document.AddSection();

        AddCompanyInfo(section, settings);

        AddTitle(section, title);

        AddConsumtion(section, calculators);

        AddFooter(section);

        document.Build(name);
    }

    private static void AddCompanyInfo(SectionBuilder section, Settings settings)
    {
        var companyInfo = $@"{settings.Company.Name}
{settings.Company.Address}, {settings.Company.City}, {settings.Company.County}, jud {settings.Company.Country}
{settings.Company.Vat}
{settings.Company.Reg}";

        section.AddParagraph(companyInfo).SetFontSize(12).SetMarginBottom(20).SetAlignment(Gehtsoft.PDFFlow.Models.Enumerations.HorizontalAlignment.Left);
    }

    private static void AddTitle(SectionBuilder section, string title)
    {
        section.AddParagraph(title).SetBold().SetFontSize(20).SetMarginBottom(20).SetAlignment(Gehtsoft.PDFFlow.Models.Enumerations.HorizontalAlignment.Center);
    }

    private static void AddConsumtion(SectionBuilder section, List<ICalculator> calculators)
    {
        var categories = calculators.GroupBy(x => x.Category);

        foreach (var category in categories)
        {
            section.AddParagraph(category.Key.GetEnumDisplayName()).SetBold().SetFontSize(14).SetMarginBottom(10).SetAlignment(Gehtsoft.PDFFlow.Models.Enumerations.HorizontalAlignment.Left);

            foreach (var calculator in category)
            {
                section.AddParagraph(calculator.Name).SetFontSize(12).SetMarginBottom(10).SetAlignment(Gehtsoft.PDFFlow.Models.Enumerations.HorizontalAlignment.Left);
                var table = section.AddTable()
                .SetContentRowStyleHorizontalAlignment(Gehtsoft.PDFFlow.Models.Enumerations.HorizontalAlignment.Center)
                .SetAltRowStyleHorizontalAlignment(Gehtsoft.PDFFlow.Models.Enumerations.HorizontalAlignment.Center)
                .SetBorderWidth(2.0f).SetBorderStroke(Stroke.Solid);
                foreach (var column in calculator.Components.Where(x => x != ComponentType.Index))
                {
                    table.AddColumn(column.GetEnumDisplayName());
                }
                foreach (var record in calculator.Data)
                {
                    var row = table.AddRow();
                    foreach (var column in record.Where(x => x.Key != ComponentType.Index))
                    {
                        row.AddCellToRow(record[column.Key].ToString());
                    }
                }
                section.AddParagraph($"{Constants.Total}: {Math.Round(calculator.Data.Sum(x => x[ComponentType.Total]), 2)}").SetFontSize(14).SetMarginBottom(20).SetAlignment(Gehtsoft.PDFFlow.Models.Enumerations.HorizontalAlignment.Right);
            }

            section.AddParagraph($"{Constants.Total}: {Math.Round(category.Sum(x => x.GetTotal()), 2)}").SetBold().SetFontSize(14).SetMarginBottom(40).SetAlignment(Gehtsoft.PDFFlow.Models.Enumerations.HorizontalAlignment.Right);
        }
    }

    private static void AddFooter(SectionBuilder section)
    {
        var footer = $@"Data                                                                              Semnatura
_________________________                                   _________________________________";

        section.AddParagraph(footer).SetFontSize(12).SetMarginTop(60).SetAlignment(Gehtsoft.PDFFlow.Models.Enumerations.HorizontalAlignment.Left);
    }
}