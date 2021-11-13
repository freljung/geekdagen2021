namespace Demo.NetAnalyzers
{
    // CA1812: Avoid uninstantiated internal classes
    // https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1812
    internal class MyClass
    {
        public void DoSomething()
        {
        }
    }
    public class MyGeneric<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
}