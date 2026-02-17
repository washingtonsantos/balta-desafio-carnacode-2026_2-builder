using Builder.Reports.Enums;
using Builder.Reports.Sales;

Console.WriteLine("=== Sistema de Relatórios ===");

var report = new SalesReportBuilder()
    .WithTitle("Vendas Mensais")
    .ExportAs(ReportFormat.PDF)
    .WithDateRange(new DateTime(2024, 1, 1), new DateTime(2024, 1, 31))
    .IncludeHeader("Relatório de Vendas")
    .IncludeFooter("Confidencial")
    .IncludeCharts(ReportCharts.Bar)
    .IncludeSummary()
    .AddColumns(new List<string> { "Produto", "Quantidade", "Valor" })
    .WithFilters(new List<string> { "Status=Ativo" })
    .WithSortBy("Valor")
    .WithGroupBy("Categoria")
    .IncludeTotals()
    .WithOrientation(PdfOrientation.Portrait)
    .WithPageSize("A4")
    .IncludePageNumbers()
    .WithCompanyLogo("logo.png")
    .WithWaterMark("Confidencial")
    .Build();

report.Generate();

var report2 = new SalesReportBuilder()
    .WithTitle("Relatório Trimestral")
    .ExportAs(ReportFormat.Excel)
    .WithDateRange(new DateTime(2024, 1, 1), new DateTime(2024, 3, 31))
    .AddColumns(new List<string> { "Vendedor", "Região", "Total" })
    .IncludeCharts(ReportCharts.Line)
    .IncludeHeader("Relatório de Vendas por Trimestral")
    .WithGroupBy("Região")
    .IncludeTotals()
    .Build();

report2.Generate();

var report3 = new SalesReportBuilder()
    .WithTitle("Vendas Anuais")
    .ExportAs(ReportFormat.PDF)
    .WithDateRange(new DateTime(2024, 1, 1), new DateTime(2024, 12, 31))
    .IncludeHeader("Relatório de Vendas")
    .IncludeFooter("Confidencial")
    .AddColumns(new List<string> { "Produto", "Quantidade", "Valor" })
    .IncludeCharts(ReportCharts.Pie)
    .IncludeTotals()
    .WithOrientation(PdfOrientation.Landscape)
    .WithPageSize("A4")
    .Build();

report3.Generate();

