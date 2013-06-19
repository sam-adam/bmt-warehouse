using System;

namespace Warehouse.Helper
{
    public static class MathHelper
    {
        public static bool IsAboutEqual(double x, double y)
        {
            var epsilon = Math.Max(Math.Abs(x), Math.Abs(y)) * 1E-15;
            
            return Math.Abs(x - y) <= epsilon;
        }
    }
}
