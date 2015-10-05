# DoubleVSFloatBenchmark
Compare the performance between `double` and `float` in C#

## Test case

I tested the performance of `float` and `double` with five group test cases which shown below.
```csharp
...
private static void FloatMix()
{
    float x = 0.1234f, y = 4.321f;
    float a, b, c;
    a = x + y + x + y + x + y - x - y - x - y - x - y - x - y;
    b = x * x * x * x * x + y * y * y * y * y;
    c = x / y / x / y / x / y / x / y - y / x / y / x / y / x / y / x;
}

private static void DoubleMix()
{
    double x = 0.1234f, y = 4.321f;
    double a, b, c;
    a = x + y + x + y + x + y - x - y - x - y - x - y - x - y;
    b = x * x * x * x * x + y * y * y * y * y;
    c = x / y / x / y / x / y / x / y - y / x / y / x / y / x / y / x;
}
...
```

Run test 100 * 100 * 100 * 100 times:
```csharp
// Warm up
...
FloatMix();
...
DoubleMix();
 
// Start
CodeTimer.Initialize();

...
CodeTimer.Time("Float Mix", _iteration, FloatMix);
CodeTimer.Time("Double Mix", _iteration, DoubleMix);
...
```

## Test result

```
Float Add
        Time Elapsed:   1,652ms
        CPU Cycles:     3,953,733,218
        Gen 0:          0
        Gen 1:          0
        Gen 2:          0

Double Add
        Time Elapsed:   1,704ms
        CPU Cycles:     4,080,174,511
        Gen 0:          0
        Gen 1:          0
        Gen 2:          0

Float Sub
        Time Elapsed:   1,659ms
        CPU Cycles:     3,963,928,301
        Gen 0:          0
        Gen 1:          0
        Gen 2:          0

Double Sub
        Time Elapsed:   1,703ms
        CPU Cycles:     4,072,471,939
        Gen 0:          0
        Gen 1:          0
        Gen 2:          0

Float Mul
        Time Elapsed:   1,854ms
        CPU Cycles:     4,437,593,081
        Gen 0:          0
        Gen 1:          0
        Gen 2:          0

Double Mul
        Time Elapsed:   1,948ms
        CPU Cycles:     4,663,086,286
        Gen 0:          0
        Gen 1:          0
        Gen 2:          0

Float Div
        Time Elapsed:   4,507ms
        CPU Cycles:     10,785,544,619
        Gen 0:          0
        Gen 1:          0
        Gen 2:          0

Double Div
        Time Elapsed:   4,479ms
        CPU Cycles:     10,720,219,904
        Gen 0:          0
        Gen 1:          0
        Gen 2:          0

Float Mix
        Time Elapsed:   6,255ms
        CPU Cycles:     14,969,781,271
        Gen 0:          0
        Gen 1:          0
        Gen 2:          0

Double Mix
        Time Elapsed:   6,250ms
        CPU Cycles:     14,959,335,709
        Gen 0:          0
        Gen 1:          0
        Gen 2:          0
```
