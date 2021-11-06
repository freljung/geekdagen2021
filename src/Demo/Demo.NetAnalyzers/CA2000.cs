namespace Demo.NetAnalyzers;

// CA2000: Dispose objects before losing scope
// https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2000#configure-code-to-analyze
public class MethodDoNotDispose
{
    public void DoSomething()
    {
        var shouldBeDisposed = new DisposableClass();
        shouldBeDisposed.DoSomething();
    }
}

public class DisposableClass : IDisposable
{
    private readonly string doSomethingText = "Doing something";

    public void DoSomething()
    {
        Console.WriteLine(doSomethingText);
    }
    
    protected virtual void Dispose(bool disposing)
    {
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
