namespace CSharp_AzureDevopsNotifier.Entities
{
    public class AzureDevOpsFilter
    {
        public string Field { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }

        public AzureDevOpsFilter()
        {
            Field = string.Empty;
            Operator = string.Empty;
            Value = string.Empty;
        }

        public AzureDevOpsFilter(
            string fieldFilter,
            string operatorFilter,
            string valueFilter
            )
        {
            Field = fieldFilter;
            Operator = operatorFilter;
            Value = valueFilter;
        }
    }
}
