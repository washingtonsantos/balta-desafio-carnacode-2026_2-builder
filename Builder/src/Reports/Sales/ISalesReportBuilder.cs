using Builder.Reports.Enums;

namespace Builder.Reports.Sales
{
    public interface ISalesReportBuilder
    {
        SalesReportBuilder WithTitle(string title);
        SalesReportBuilder ExportAs(ReportFormat format);
        SalesReportBuilder WithDateRange(DateTime startDate, DateTime endDate);
        SalesReportBuilder IncludeHeader(string headerText);
        SalesReportBuilder IncludeFooter(string footerText);
        SalesReportBuilder IncludeCharts(ReportCharts reportCharts);
        SalesReportBuilder IncludeSummary();
        SalesReportBuilder AddColumns(List<string> columns);
        SalesReportBuilder WithFilters(List<string> filters);
        SalesReportBuilder WithSortBy(string sortBy);
        SalesReportBuilder WithGroupBy(string groupBy);
        SalesReportBuilder IncludeTotals();
        SalesReportBuilder WithOrientation(PdfOrientation orientation);
        SalesReportBuilder WithPageSize(string pageSize);
        SalesReportBuilder IncludePageNumbers();
        SalesReportBuilder WithCompanyLogo(string companyLogo);
        SalesReportBuilder WithWaterMark(string waterMark);
        SalesReport Build();
    }
}