namespace CSharpDiscovery.Quest02
{
    public class AreEquals_Exercice
    {
        public static bool AreEquals(int[] tab1, int[] tab2)
        {
            bool flag = true;
            if(tab1.Length == tab2.Length) {
                for(int i = 0; i < tab1.Length; i++) {
                    if(tab1[i] != tab2[i]) {
                        flag = false;
                    }
                }
            } else flag = false;
        return flag;
        }
    }
}