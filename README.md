# Geek dagen2021

Denna repository innehåller kodexempel för presentationen [Få stil på koden och undvik misstag med .NET Analyzers](https://geekdagen.se/session/fa-stil-pa-koden-och-undvik-misstag-med-net-analyzers/)
för [Geek dagen 2021](https://geekdagen.se).

## Konfigurera specifika regler.

Specifika regler konfigureras i en .editorconfig-fil.
Vilken nivå av varning som ska genereras sker genom att ange 
```dotnet_diagnostics.<regelnumret>.severity = <nivå>```

Exempel:
Ändra alla formateringsregler till varningar
```
dotnet_diagnostic.IDE0055.severity = warning
```

Tillgängliga nivåer är 
- *none* - Ingen varning
- silent - Finns som refaktoreringsval men indikeras inte i UI:t eller varningslistan.
- suggestion - Utöver refaktoreringsval så visualiseras det som ...
- warning - Utöver refaktoreringsval så visualiseras det som en grön vågsymbol under koden (squiggle)
- error - Utöver refaktoreringsval så visualiseras det som en röd vågsymbol under koden (squiggle)

### Regler för kodformatering - IDE0055

Standard så är dessa regler förslag. De kan ändras genom att sätta ```dotnet_diagnostic.IDE0055.severity``` till lämplig nivå

    dotnet_diagnostic.IDE0055.severity = warning

### Exempel på formateringsregler

#### Sortering av using statements


dotnet_sort_system_directives_first = true

## Konfigurera Analyzers från command line


#### Inkludera default analyzers

``` cmd
dotnet build --no-incremental /p:EnforceCodeStyleInBuild=true
```


#### Behandla varningar som fel men exkludera varningar från analyzers

``` cmd
dotnet build --no-incremental -warnaserror /p:CodeAnalysisTreatWarningsAsErrors=false
```


#### .NET 6 AnalysisMode från kommandoprompten 

``` cmd
dotnet build --no-incremental /p:AnalysisMode=All
```


## .editorconfig

Kopiera in nedan i en .editorconfig för att sätta inställningar för whitespace etc.
