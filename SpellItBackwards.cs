namespace CSharpDiscovery.Quest01
{
    public class SpellItBackwards_Exercice
    {
        public static string SpellItBackward(string str)
        {
           char[] charArray = str.ToCharArray();
           string reverse = string.Empty;
           for(int i = charArray.Length - 1; i >= 0; i--) {
             reverse += charArray[i];
           }
           return reverse;
        }
    }
}