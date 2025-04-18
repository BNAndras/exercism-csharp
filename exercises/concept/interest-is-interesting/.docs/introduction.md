# Introduction

## Floating Point Numbers

A floating-point number is a number with zero or more digits behind the decimal separator. Examples are `-2.4`, `0.1`, `3.14`, `16.984025` and `1024.0`.

Different floating-point types can store different numbers of digits after the digit separator - this is referred to as its precision.

C# has three floating-point types:

- `float`: 4 bytes (~6-9 digits precision). Written as `2.45f`.
- `double`: 8 bytes (~15-17 digits precision). This is the most common type. Written as `2.45` or `2.45d`.
- `decimal`: 16 bytes (28-29 digits precision). Normally used when working with monetary data, as its precision reduces the chance of rounding errors. Written as `2.45m`.

As can be seen, each type can store a different number of digits. For example, trying to store PI in a `float` will only store the first 6 decimal places (with the last stored digit rounded).

## While Loops

In this exercise you may want to use a loop. There are several ways to write loops in C#, but the `while` loop is most appropriate here:

```csharp
int x = 23;

while (x > 10)
{
    // Execute logic if x > 10
    x = x - 2;
}
```

## Do While Loops

If the code in a loop should always be executed at least once, a `do`/`while` loop can be used:

```csharp
int x = 23;

do
{
    // Execute body, repeating only if x > 10
    x = x - 2;
} while (x > 10);
```
