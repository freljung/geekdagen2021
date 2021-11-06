namespace Demo.NetAnalyzers;

// IDE0060: Remove unused parameter
// https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0060
/// <summary>
/// <b>Konfiguration:</b> dotnet_code_quality_unused_parameters sätts till all eller non_public i .editorconfig
/// </summary>
public class TestClass
{
    public int GetNum1(int unusedParam) { return 1; }
    internal int GetNum2(int unusedParam) { return 1; }
    private int GetNum3(int unusedParam) { return 1; }

    // dotnet_code_quality_unused_parameters = non_public
    internal int GetNum4(int unusedParam) { return 1; }
    private int GetNum5(int unusedParam) { return 1; }
}
