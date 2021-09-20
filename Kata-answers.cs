// Answer to Opposites Attract

using System;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    {
        return flower1 % 2 != flower2 % 2;
    }
}

// Answer to You only need one (had to comment the use clause otherwise we had an error.)

//using System.Linq;

public class Kata
{
    public static bool Check(object[] a, object v) => a.Contains(v);
}

// Answer to Sum of Positives 

//using System;
//using System.Linq;

public class Kata
{
    public static int PositiveSum(int[] arr)
    {
        return arr.Where(x => x > 0).Sum();
    }
}