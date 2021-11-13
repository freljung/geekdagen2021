using System.Security.Authentication;

namespace Demo.NetAnalyzers;

// 
// https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5397
public class UsesDeprecatedSslProtocol
{
    public void ConfigureSsl()
    {
        SslProtocols protocols = SslProtocols.Tls11 | SslProtocols.Tls12;
        SslProtocols sslProtocols = (SslProtocols)768;    // TLS 1.1

        Console.WriteLine($"{protocols} {sslProtocols}");

        // Fix
        // Let the operating system decide what TLS protocol version to use.
        // See https://docs.microsoft.com/dotnet/framework/network-programming/tls
        // SslProtocols sslProtocols = SslProtocols.None;
    }
}