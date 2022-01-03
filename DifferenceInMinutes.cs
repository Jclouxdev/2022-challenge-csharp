using System;

namespace CSharpDiscovery.Quest02
{
    public class DifferenceInMinutes_Exercice
    {
        public static double DifferenceInMinutes(DateTime start, DateTime end)
        {
            return((end - start).TotalDays * 60 * 24);
        }
    }
}