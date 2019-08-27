# IEnumerable.Append
An `IEnumerable` extension that allows a single item to be concatenated to an existing enumerable collection.
Microsoft added an `Append` method in the `System.Linq` namespace from .NET Framework 4.7.1. 
Use this package to get the same functionality in early versions.

## Example
```csharp
using System;
using System.Collections.Generic;
using IEnumerable.Append;

namespace Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<string> input = new [] { "Lorem", "ipsum", "dolor", "sit" };

            IEnumerable<string> output = input.Append("amet");

            Console.WriteLine(string.Join(" ", output));
        }
    }
}


```
