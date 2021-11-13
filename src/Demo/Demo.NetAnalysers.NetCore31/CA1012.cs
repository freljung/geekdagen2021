namespace Demo.NetAnalyzers
{
    abstract public class AbstractBaseClass
    {
        // CA1012: Abstract types should not have constructors
        // https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1012
        /// <summary>
        /// <para>
        /// <b>Problem:</b> En publik konstruktor är till för att skapa objekt och en abstrakt klass kan inte skapas, utan 
        /// kan bara anropas av en klass som ärver av basklassen (<see cref="AbstractBaseClass"/>).
        /// </para>
        /// 
        /// <para>
        /// <b>Lösning:</b> Antingen deklarera kontstruktorn som protected eller ändra klassen till att inte vara abstrakt.
        /// </para>
        /// 
        /// <para>
        /// <b>Konfiguration:</b> Som standard används bara regeln på externt synliga klasser. Det kan konfigeras i .editorconfig
        /// via dotnet_code_quality.CA1012.api_surface = private, internal
        /// </para>
        /// </summary>
        public AbstractBaseClass()
        {
        }
    }
}