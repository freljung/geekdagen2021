using System.Security.Cryptography;

namespace Demo.NetAnalyzers;

// CA5351 Do Not Use Broken Cryptographic Algorithms
// https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5351
public class UsesBrokenEncryption
{
    public string EncryptMD5(string thing)
    {
        using var hashAlg = MD5.Create();
        // Fix
        //using var hashAlg = SHA256.Create();

        // Skapa hash...
        return string.Empty;
    }

    public string EncryptRC2(string thing)
    {
        using var encAlg = RC2.Create();
        // Fix
        //using var encAlg = new AesManaged();

        // Kryptera...
        return string.Empty;
    }

    public string EncryptDES(string thing)
    {
        using var hashAlg = DES.Create();
        // Fix
        //using var encAlg = new AesManaged();

        // Kryptera...
        return string.Empty;
    }
}
