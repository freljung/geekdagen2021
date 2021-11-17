# Geek dagen2021

Denna repository inneh�ller kodexempel f�r presentationen [F� stil p� koden och undvik misstag med .NET Analyzers](https://geekdagen.se/session/fa-stil-pa-koden-och-undvik-misstag-med-net-analyzers/)
f�r [Geek dagen 2021](https://geekdagen.se).

## Aktivera .NET Analyzers

I .NET 5 och senare �r de aktiverade som standard. F�r tidigare versioner s� kan de aktiveras genom att s�tta ```<EnableNETAnalyzers>``` till ```true```
i projekt-filen

``` xml
<EnableNETAnalyzers>true</EnableNETAnalyzers>
```

## Konfigurera �vergripande

Som standard �r det f� regler som �r aktiverade f�r .NET Analyzers. F�r att �ndra den generella niv�n s� kan ```<AnalysisLevel>``` l�ggas till i 
projektfilen. Niv�n s�tts kortfattat till ```latest```, ```preview``` eller .NET versionens nummer. Niv�n kan �ven kombineras med ett l�ge som avg�r 
hur h�rt reglerna ska appliceras. L�get, som �ven kan s�ttas med ```<AnalysisMode>```. V�rdet s�tts till i stigande niv� till en av 
```None```, ```Default```, ```Minimum```, ```Recommended```, ```All```. 

L�s mer om AnalysysLevel p� [docs.microsoft.com](https://docs.microsoft.com/en-us/dotnet/core/project-sdk/msbuild-props#analysislevel).

### .NET 5

F�r .NET 5 s� s�tts analysniv�n och l�get med separat p� ```<AnalysisLevel>``` och ```<AnalysisMode>```.

### Konfigurera alla regler

```
dotnet_analyzer_diagnostic.severity = suggestion
```

### Konfigurera en kategori av regler

```
dotnet_analyzer_diagnostic.<category>.severity = suggestion

```

#### Alla IDE-regler

```
dotnet_analyzer_diagnostic.category-Style.severity = suggestion
dotnet_analyzer_diagnostic.category-CodeQuality.severity = suggestion
```
 
## Konfigurera specifika regler.

Specifika regler konfigureras i en .editorconfig-fil.
L�gg till ny .editorconfig som genereras fr�n nuvarande kod.
Vilken niv� av varning som ska genereras sker genom att ange 
```dotnet_diagnostics.<regelnumret>.severity = <niv�>```

Exempel:
�ndra alla formateringsregler till varningar

    dotnet_diagnostic.IDE0055.severity = warning


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

.editorconfig med standardinst�llningar f�r .NET C# och VB

```
# To learn more about .editorconfig see https://aka.ms/editorconfigdocs
###############################
# Core EditorConfig Options   #
###############################
root = true
# All files
[*]
indent_style = space

# XML project files
[*.{csproj,vbproj,vcxproj,vcxproj.filters,proj,projitems,shproj}]
indent_size = 2

# XML config files
[*.{props,targets,ruleset,config,nuspec,resx,vsixmanifest,vsct}]
indent_size = 2

# Code files
[*.{cs,csx,vb,vbx}]
indent_size = 4
insert_final_newline = true
charset = utf-8-bom
###############################
# .NET Coding Conventions     #
###############################
[*.{cs,vb}]
# Organize usings
dotnet_sort_system_directives_first = true
# this. preferences
dotnet_style_qualification_for_field = false:silent
dotnet_style_qualification_for_property = false:silent
dotnet_style_qualification_for_method = false:silent
dotnet_style_qualification_for_event = false:silent
# Language keywords vs BCL types preferences
dotnet_style_predefined_type_for_locals_parameters_members = true:silent
dotnet_style_predefined_type_for_member_access = true:silent
# Parentheses preferences
dotnet_style_parentheses_in_arithmetic_binary_operators = always_for_clarity:silent
dotnet_style_parentheses_in_relational_binary_operators = always_for_clarity:silent
dotnet_style_parentheses_in_other_binary_operators = always_for_clarity:silent
dotnet_style_parentheses_in_other_operators = never_if_unnecessary:silent
# Modifier preferences
dotnet_style_require_accessibility_modifiers = for_non_interface_members:silent
dotnet_style_readonly_field = true:suggestion
# Expression-level preferences
dotnet_style_object_initializer = true:suggestion
dotnet_style_collection_initializer = true:suggestion
dotnet_style_explicit_tuple_names = true:suggestion
dotnet_style_null_propagation = true:suggestion
dotnet_style_coalesce_expression = true:suggestion
dotnet_style_prefer_is_null_check_over_reference_equality_method = true:silent
dotnet_style_prefer_inferred_tuple_names = true:suggestion
dotnet_style_prefer_inferred_anonymous_type_member_names = true:suggestion
dotnet_style_prefer_auto_properties = true:silent
dotnet_style_prefer_conditional_expression_over_assignment = true:silent
dotnet_style_prefer_conditional_expression_over_return = true:silent
###############################
# Naming Conventions          #
###############################
# Style Definitions
dotnet_naming_style.pascal_case_style.capitalization             = pascal_case
# Use PascalCase for constant fields  
dotnet_naming_rule.constant_fields_should_be_pascal_case.severity = suggestion
dotnet_naming_rule.constant_fields_should_be_pascal_case.symbols  = constant_fields
dotnet_naming_rule.constant_fields_should_be_pascal_case.style    = pascal_case_style
dotnet_naming_symbols.constant_fields.applicable_kinds            = field
dotnet_naming_symbols.constant_fields.applicable_accessibilities  = *
dotnet_naming_symbols.constant_fields.required_modifiers          = const
###############################
# C# Coding Conventions       #
###############################
[*.cs]
# var preferences
csharp_style_var_for_built_in_types = true:silent
csharp_style_var_when_type_is_apparent = true:silent
csharp_style_var_elsewhere = true:silent
# Expression-bodied members
csharp_style_expression_bodied_methods = false:silent
csharp_style_expression_bodied_constructors = false:silent
csharp_style_expression_bodied_operators = false:silent
csharp_style_expression_bodied_properties = true:silent
csharp_style_expression_bodied_indexers = true:silent
csharp_style_expression_bodied_accessors = true:silent
# Pattern matching preferences
csharp_style_pattern_matching_over_is_with_cast_check = true:suggestion
csharp_style_pattern_matching_over_as_with_null_check = true:suggestion
# Null-checking preferences
csharp_style_throw_expression = true:suggestion
csharp_style_conditional_delegate_call = true:suggestion
# Modifier preferences
csharp_preferred_modifier_order = public,private,protected,internal,static,extern,new,virtual,abstract,sealed,override,readonly,unsafe,volatile,async:suggestion
# Expression-level preferences
csharp_prefer_braces = true:silent
csharp_style_deconstructed_variable_declaration = true:suggestion
csharp_prefer_simple_default_expression = true:suggestion
csharp_style_pattern_local_over_anonymous_function = true:suggestion
csharp_style_inlined_variable_declaration = true:suggestion
###############################
# C# Formatting Rules         #
###############################
# New line preferences
csharp_new_line_before_open_brace = all
csharp_new_line_before_else = true
csharp_new_line_before_catch = true
csharp_new_line_before_finally = true
csharp_new_line_before_members_in_object_initializers = true
csharp_new_line_before_members_in_anonymous_types = true
csharp_new_line_between_query_expression_clauses = true
# Indentation preferences
csharp_indent_case_contents = true
csharp_indent_switch_labels = true
csharp_indent_labels = flush_left
# Space preferences
csharp_space_after_cast = false
csharp_space_after_keywords_in_control_flow_statements = true
csharp_space_between_method_call_parameter_list_parentheses = false
csharp_space_between_method_declaration_parameter_list_parentheses = false
csharp_space_between_parentheses = false
csharp_space_before_colon_in_inheritance_clause = true
csharp_space_after_colon_in_inheritance_clause = true
csharp_space_around_binary_operators = before_and_after
csharp_space_between_method_declaration_empty_parameter_list_parentheses = false
csharp_space_between_method_call_name_and_opening_parenthesis = false
csharp_space_between_method_call_empty_parameter_list_parentheses = false
# Wrapping preferences
csharp_preserve_single_line_statements = true
csharp_preserve_single_line_blocks = true
###############################
# VB Coding Conventions       #
###############################
[*.vb]
# Modifier preferences
visual_basic_preferred_modifier_order = Partial,Default,Private,Protected,Public,Friend,NotOverridable,Overridable,MustOverride,Overloads,Overrides,MustInherit,NotInheritable,Static,Shared,Shadows,ReadOnly,WriteOnly,Dim,Const,WithEvents,Widening,Narrowing,Custom,Async:suggestion
```