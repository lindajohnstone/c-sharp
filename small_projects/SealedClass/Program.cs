using System;

namespace SealedClass
{

    // can be instantiated but not derived
    sealed class SealedClass
{
    public int x;
    public int y;
}

class SealedTest2
{
    static void Main()
    {
        var sc = new SealedClass();
        sc.x = 110;
        sc.y = 150;
        Console.WriteLine($"x = {sc.x}, y = {sc.y}");
        Console.WriteLine(sc.x + sc.y);
    }
}
// Output: x = 110, y = 150
}
