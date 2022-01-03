using System;
namespace CSharpDiscovery.Quest02
{
    public class FromStringToDateTime_Exercice
    {
        public static DateTime FromStringToDateTime(string dateStr)
        {
            return(System.Convert.ToDateTime(dateStr));
        }
    }
}