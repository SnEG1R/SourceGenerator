﻿namespace SourceGenerate.Domain.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
[Partial]
[NotStatic]
public class SingletonAttribute : Attribute
{
    
}