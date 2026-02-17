using Builder.Reports.Enums;

namespace Builder.Reports.Sales
{
    public sealed class SalesReportBuilder : ISalesReportBuilder
    {
        private readonly SalesReport _report = new();

        public SalesReport Build()
        {
            return _report;
        }

        public SalesReportBuilder WithTitle(string title)
        {
            _report.Title = title;
            return this;
        }

        public SalesReportBuilder ExportAs(ReportFormat format)
        {
            _report.Format = format.ToString();
            return this;
        }

        public SalesReportBuilder WithDateRange(DateTime startDate, DateTime endDate)
        {
            _report.StartDate = startDate;
            _report.EndDate = endDate;
            return this;
        }

        public SalesReportBuilder IncludeHeader(string headerText)
        {
            _report.IncludeHeader = true;
            _report.HeaderText = headerText;
            return this;
        }

        public SalesReportBuilder IncludeFooter(string footerText)
        {
            _report.IncludeFooter = true;
            _report.FooterText = footerText;
            return this;
        }

        public SalesReportBuilder IncludeCharts(ReportCharts reportCharts)
        {
            _report.IncludeCharts = true;
            _report.ChartType = reportCharts.ToString();
            return this;
        }

        public SalesReportBuilder IncludeSummary()
        {
            _report.IncludeSummary = true;
            return this;
        }

        public SalesReportBuilder AddColumns(List<string> columns)
        {
            _report.Columns = columns;
            return this;
        }

        public SalesReportBuilder WithFilters(List<string> filters)
        {
            _report.Filters = filters;
            return this;
        }

        public SalesReportBuilder WithSortBy(string sortBy)
        {
            _report.SortBy = sortBy;
            return this;
        }

        public SalesReportBuilder WithGroupBy(string groupBy)
        {
            _report.GroupBy = groupBy;
            return this;
        }

        public SalesReportBuilder IncludeTotals()
        {
            _report.IncludeTotals = true;
            return this;
        }

        public SalesReportBuilder WithOrientation(PdfOrientation orientation)
        {
            _report.Orientation = orientation.ToString();
            return this;
        }

        public SalesReportBuilder WithPageSize(string pageSize)
        {
            _report.PageSize = pageSize;
            return this;
        }

        public SalesReportBuilder IncludePageNumbers()
        {
            _report.IncludePageNumbers = true;
            return this;
        }

        public SalesReportBuilder WithCompanyLogo(string companyLogo)
        {
            _report.CompanyLogo = companyLogo;
            return this;
        }

        public SalesReportBuilder WithWaterMark(string waterMark)
        {
            _report.WaterMark = waterMark;
            return this;
        }
    }
}