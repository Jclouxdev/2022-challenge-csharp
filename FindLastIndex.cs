using System;
namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
          if(tab == null) {
            return null;
          }
          var index = Array.LastIndexOf(tab, a);
          return index < 0 ? null : index;
        }
    }
}