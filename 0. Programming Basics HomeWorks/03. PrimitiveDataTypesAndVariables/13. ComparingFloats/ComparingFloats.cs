using System;

class ComparingFloats
{
    static void Main()
    {
        float a = 5.00000001f;
        float b = 5.00000003f;
        double eps = 0.000001d;

        Console.WriteLine(AlmostEqualRelative2(a, b, eps));
    }

    public static bool AlmostEqualRelative2(float A, float B, double maxRelativeError)
    {
        if (A == B)
            return true;
        float relativeError;
        if (Math.Abs(B) > Math.Abs(A))
            relativeError = Math.Abs((A - B) / B);
        else
            relativeError = Math.Abs((A - B) / A);
        if (relativeError <= maxRelativeError)
            return true;
        return false;
    }
}
