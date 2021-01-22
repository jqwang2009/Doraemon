using System;

namespace Tongyu.First.Utils
{
    public class MathHelper
    {
        public static bool IsEqual(double first,double second,double tolerance = 1e-5)
        {
            if (double.IsNaN(first) || double.IsNaN(second))
                return false;
            return Math.Abs(first - second) < tolerance;
        }
    }
}
