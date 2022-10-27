using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTopics
{
    public static class StaticMethods
    {
        public static int Sum(this int ourValue, params int[] values)
        {
            return ourValue + values.Sum(x => x); 
        }
    }
}
