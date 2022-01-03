namespace CSharpDiscovery.Quest02
{
    public class ContainsThisValue_Exercice
    {
        public static bool ContainsThisValue(int[] tab, int value)
        {
            bool flag = false;
            for(int i = 0; i < tab.Length; i++) {
                if(tab[i] == value) {
                  flag = true;
                  break;
                }
            }
            return flag;
        }
    }
}