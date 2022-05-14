﻿using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Formatting;
using SourceGenerate.Domain.Attributes;
using SourceGenerate.Templates;
using SourceGenerate.Templates.Patterns;

namespace SourceGenerate.Generators.PatternGenerators;

[Generator]
internal class SingletonGenerator : BaseGenerator, IIncrementalGenerator
{
    protected override Type Type { get; } = typeof(SingletonAttribute);
    protected override ITemplate Template { get; } = new SingletonTemplate();

    protected override string GeneratePartialClass(ITypeSymbol symbol)
    {
        var @namespace = symbol.ContainingNamespace.ToString()!;
        var className = symbol.Name;

        var partialClass = Template.GetTemplate()
            .Replace("*namespace*", @namespace)
            .Replace("*class-name*", className);

        return partialClass;
    }
}