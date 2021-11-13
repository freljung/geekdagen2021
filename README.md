# Geek dagen2021

Denna repository inneh�ller kodexempel f�r presentationen [F� stil p� koden och undvik misstag med .NET Analyzers](https://geekdagen.se/session/fa-stil-pa-koden-och-undvik-misstag-med-net-analyzers/)
f�r [Geek dagen 2021](https://geekdagen.se).

## Konfigurera specifika regler.

Specifika regler konfigureras i en .editorconfig-fil.
Vilken niv� av varning som ska genereras sker genom att ange 
```dotnet_diagnostics.<regelnumret>.severity = <niv�>```

Exempel:
�ndra alla formateringsregler till varningar
```
dotnet_diagnostic.IDE0055.severity = warning
```

Tillg�ngliga niv�er �r 
- *none* - Ingen varning
- silent - Finns som refaktoreringsval men indikeras inte i UI:t eller varningslistan.
- suggestion - Ut�ver refaktoreringsval s� visualiseras det som ...
- warning - Ut�ver refaktoreringsval s� visualiseras det som en gr�n v�gsymbol under koden (squiggle)
- error - Ut�ver refaktoreringsval s� visualiseras det som en r�d v�gsymbol under koden (squiggle)

### Regler f�r kodformatering - IDE0055

Standard s� �r dessa regler f�rslag. De kan �ndras genom att s�tta ```dotnet_diagnostic.IDE0055.severity``` till l�mplig niv�

    dotnet_diagnostic.IDE0055.severity = warning

### Exempel p� formateringsregler

#### Sortering av using statements


dotnet_sort_system_directives_first = true

## Konfigurera Analyzers fr�n command line


#### Inkludera default analyzers

``` cmd
dotnet build --no-incremental /p:EnforceCodeStyleInBuild=true
```


#### Behandla varningar som fel men exkludera varningar fr�n analyzers

``` cmd
dotnet build --no-incremental -warnaserror /p:CodeAnalysisTreatWarningsAsErrors=false
```


#### .NET 6 AnalysisMode fr�n kommandoprompten 

``` cmd
dotnet build --no-incremental /p:AnalysisMode=All
```


## .editorconfig

Kopiera in nedan i en .editorconfig f�r att s�tta inst�llningar f�r whitespace etc.
