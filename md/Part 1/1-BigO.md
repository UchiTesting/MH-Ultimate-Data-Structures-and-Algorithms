Big O Notation
==============

It is meant to describe the performance of an algorithm.

> We do not think in ms. This is machine dependant and even the same machine can perform differently across different runs.

## Constant time O(1)

No matter how big the data set is, executes always the same.

In th bellow code snippet, no matter if the table has 1 or 1 million elements, we always display one element only.

```csharp
void Log(int[] intArray){
    Console.WriteLine(intArray[0]); // O(1)
}
```

Should we double the operation we could note it O(2)

```csharp
void Log(int[] intArray){
    Console.WriteLine(intArray[0]); // O(1)
    Console.WriteLine(intArray[0]); // O(2)
}
```

But actually we don't care about the number of operations. Rather we want to know how it would slow down should the data grow bigger. 
So we can simplify it to O(1) which is constant time.

## Linear time O(n)

Grows linearly in direct correlation with the size of the input.

```csharp
void Log(int[] intArray){
    for (int i = 0;i < intArray.Length; i++) // O(n)
        Console.WriteLine(intArray[0]);
}
```

Same as before, when there are multiple operations, we can simplify.

In the example bellow, we add a read operation before and after the O(n) operation.

```csharp
void Log(int[] intArray){
    Console.WriteLine(intArray[0]); // O(1)

    for (int i = 0;i < intArray.Length; i++) // O(n)
        Console.WriteLine(intArray[0]);

    Console.WriteLine(intArray[0]); // O(1)
}
```

This would sum up as `O(1) + O(n) + O(1) => O(2+n) => O(n)`.  
Constant operations are just absorbed by the linear one.

Another Example.
We double the loop

```csharp
void Log(int[] intArray){
    for (int i = 0;i < intArray.Length; i++) // O(n)
        Console.WriteLine(intArray[0]); 

    for (int i = 0;i < intArray.Length; i++) // O(n)
        Console.WriteLine(intArray[0]);
}
```

It would sum up as `O(n) + O(n) => O(2n) => O(0)`

Should we have 2 different arrays

```csharp
void Log(int[] intArray, string stringArray){
    for (int i = 0;i < intArray.Length; i++) // O(n)
        Console.WriteLine(intArray[0]); 

    for (int i = 0;i < stringArray.Length; i++) // O(m)
        Console.WriteLine(intArray[0]);
}
```

It would sum up as `O(n) + O(m) => O(n+m) => O(n)`

Both array could have different sizes. But they are both linear. So the end result is also linear.

## Quadratic time O(n²)

```csharp
void Log(int[] intArray){
    for (int i = 0;i < intArray.Length; i++) // O(n)
        for (int i = 0;i < intArray.Length; i++) // O(n)
            Console.WriteLine(intArray[0]);
}
```

It would sum up as `O(n) × O(n)  => O(n × n) => O(n²)`

Another example

```csharp
void Log(int[] intArray){
    for (int i = 0;i < intArray.Length; i++) // O(n)
        Console.WriteLine(intArray[0]);

    for (int i = 0;i < intArray.Length; i++) // O(n)
        for (int i = 0;i < intArray.Length; i++) // O(n)
            Console.WriteLine(intArray[0]);
}
```

It would sum up as `O(n) + O(n) × O(n)  => O(n) + O(n × n) => O(n) + O(n²) => O(n²)`

The faster linear operation is absorbed into the quadratic one.

Other example

```csharp
void Log(int[] intArray){
    for (int i = 0;i < intArray.Length; i++) // O(n)
        for (int i = 0;i < intArray.Length; i++) // O(n)
            for (int i = 0;i < intArray.Length; i++) // O(n)
                Console.WriteLine(intArray[0]);
}
```

It would sum up as `O(n) × O(n) × O(n)  => O(n × n × n) => O(n³)` which is slower than `O(n²)`

## Logarithmic time O(log n)

Faster than Linear time with bigger data sets.

An example would be trying to find a value into an array.
Say we have a sequence from 1 to 10 in that array and it is indeed ordered.

Linear search would try each item from beginning until it finds the value.
So 10 operations.

Binary search would point at the middle value and try determining if the value is above or bellow it.
Every time it would half the  data set picking the one that is relevant.
So it would go to 5, pick the right half.
Then got to 8, pick the right half.
Then go to 10.
3 operations.

To get an idea, it takes 19 operations to do the same should the array have a million items.
19 (binary search) << 1 million (linear search)

## Exponential time O(2ⁿ)

Opposite to logarithmic curve. Grows very fast

From faster to slower

`O(1) ► O(log n) ► O(n) ► O(n²) ► O(2ⁿ)`

![](img/2024-08-22-21-08-14.png)

> There are more complexities but those 5 are the most common.

## Space complexity

Idealy we aim at using the least memory possible.
Unfortunately this is hardly ever possible.
There is always a trade off to make between saving time (fast code) and saving space (low memory usage)

When we have more space we can optimise for speed
When we don't we optimise for space.

space complexity along with runtime complexity both use Big O notation.

Example

```csharp
void Greet(string[] names){
    for (int i = 0;i < names.Length; i++) // O(1) space
        Console.WriteLine(names[i]);
}
```

The `i` variable is independent of the size of the data so it is `O(1)` space complexity.

Let initialize another array of the size of `names`.

```csharp
void Greet(string[] names){
    string[]  copy = new string[names.length] // O(n) space
    for (int i = 0;i < names.Length; i++) // O(1) space
        Console.WriteLine(names[i]);
}
```

The space complexity is the same as the input so it is `O(n)`

