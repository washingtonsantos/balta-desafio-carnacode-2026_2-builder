namespace Builder.Reports.Sales
{
    public class SalesReport
    {
        public string Title { get; set; } = string.Empty;
        public string Format { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IncludeHeader { get; set; }
        public bool IncludeFooter { get; set; }
        public string HeaderText { get; set; } = string.Empty;
        public string FooterText { get; set; } = string.Empty;
        public bool IncludeCharts { get; set; }
        public string ChartType { get; set; } = string.Empty;
        public bool IncludeSummary { get; set; }
        public List<string> Columns { get; set; } = new();
        public List<string> Filters { get; set; } = new();
        public string SortBy { get; set; } = string.Empty;
        public string GroupBy { get; set; } = string.Empty;
        public bool IncludeTotals { get; set; }
        public string Orientation { get; set; } = string.Empty;
        public string PageSize { get; set; } = string.Empty;
        public bool IncludePageNumbers { get; set; }
        public string CompanyLogo { get; set; } = string.Empty;
        public string WaterMark { get; set; } = string.Empty;

        public void Generate()
        {
            Console.WriteLine($"\n=== Gerando Relatório: {Title} ===");
            Console.WriteLine($"Formato: {Format}");
            Console.WriteLine($"Período: {StartDate:dd/MM/yyyy} a {EndDate:dd/MM/yyyy}");

            if (IncludeHeader)
                Console.WriteLine($"Cabeçalho: {HeaderText}");

            if (IncludeCharts)
                Console.WriteLine($"Gráfico: {ChartType}");

            Console.WriteLine($"Colunas: {string.Join(", ", Columns)}");

            if (Filters.Count > 0)
                Console.WriteLine($"Filtros: {string.Join(", ", Filters)}");

            if (!string.IsNullOrEmpty(GroupBy))
                Console.WriteLine($"Agrupado por: {GroupBy}");

            if (IncludeFooter)
                Console.WriteLine($"Rodapé: {FooterText}");

            Console.WriteLine("Relatório gerado com sucesso!");
        }
    }
}