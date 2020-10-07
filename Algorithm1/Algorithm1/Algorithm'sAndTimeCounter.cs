using Algorithm1.AlgorithmsAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;


namespace Algorithm1
{
    public class FindMax : IResercheable
    {
        public string Name => "Find max algorithm";

        public int Run(int[] array, int value)
        {
            var max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
                max = Math.Max(array[i], max);
            return max;
        }
    }

    public class BubbleSort : IResercheable
    {
        public string Name => "Bubble sort";

        public int Run(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        var t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
            return 0;
        }
    }


    public class FindCountOfElement : IResercheable
    {
        public string Name => "Counter of element in array";

        public int Run(int[] array, int value)
        {
            var count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    count++;
            }
            return count;
        }
    }


    public class DraftedFindMax : IResercheable
    {
        public string Name => "Drafted Founder of Max";

        public int Run(int[] array, int value)
        {
            return array.Max();
        }
    }

    public class DraftedSort : IResercheable
    {
        public string Name => "Drafted sort";

        public int Run(int[] array, int value)
        {
            Array.Sort(array);
            return 0;
        }
    }

}
