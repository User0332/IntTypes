# IntTypes

A collection of more integral types for C# including `EventInt`, an integer than can only be even (but has a `uint`-like max and min value), and its `ref struct` equivalent, the `StackEvenInt`. Note that these types do not yet implement `INumber<T>`, so they cannot be used with generic math.