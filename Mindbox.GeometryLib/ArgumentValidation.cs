using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.GeometryLib
{
    internal static class ArgumentValidation
    {
        internal static bool IsGreaterThenZero(params double[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] <= 0)
                    return false;
            }
            return true;
        }
        internal static bool IsNan(params double[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (double.IsNaN(args[i]))
                    return true;
            }
            return false;
        }
        internal static bool IsInfinite(params double[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (double.IsInfinity(args[i]))
                    return true;
            }
            return false;
        }
    }
}
