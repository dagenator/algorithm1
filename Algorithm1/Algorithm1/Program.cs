using Algorithm1.AlgorithmsAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace Algorithm1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            IResercheable[] Algorithms = new IResercheable[]
            {
                //new BubbleSort(),
                //new FindMax(),
               // new FindCountOfElement(),
                //new DraftedFindMax(),
                new DraftedSort()
            };

            int[] dimensions = new[]
            {
                500,
                1000, 
                2000,
                3000,
                5000,
                7500,
                10000
            };
            //DO NOT ENTER VALUES MORE THAN ONE BILLION!!! THAT REQUIRES A LOT OF MACHINE RESOURCES!!!

            //General testing method, that exports Excel CSV file after test
            //Array with dimensions that describes how big arrays should be created
            //IResercheable instance that should be tested. Look the IResercheable definition first.

            bool SORTED = true;

            foreach (IResercheable algorithm in Algorithms)
            {
                Tools.ConductResearch(
                                dimensions,
                                algorithm,
                                SORTED);
            }
        }
    }
}
