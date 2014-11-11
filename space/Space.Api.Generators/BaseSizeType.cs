using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators
{
    public enum BaseSizeType : int
    {
        Basic = 1
    }

    public static class BaseSizeExtensions
    {
        public static int Value(this BaseSizeType type)
        {
            int value = 0;

            value = int.Parse(type.ToString());

            return value;
        }
    }
}