namespace CSharpDiscovery.Quest01
{
    public class DoubleArrayForEvenInteger_Exercice
    {
         public static int[] DoubleArrayForEvenInteger(int[] inputTab)
        {
          int[] array = new int[inputTab.Length];
          for( int i = 0; i < inputTab.Length; i++ ) {
            if( inputTab[i] % 2 != 0 ) {
              array[i] = (inputTab[i]*2);
            } else {
              array[i] = inputTab[i];
            }
          }
          return array;
        }
    }
}