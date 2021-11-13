namespace Demo.NetAnalyzers
{
    // CA1823: Avoid unused private fields
    // https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1823
    internal class ClassWithUnusedFields
    {
        private string _someField = string.Empty;
    }
}