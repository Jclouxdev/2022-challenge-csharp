namespace CSharpDiscovery.Quest01
{
    public class BeginsWithSpecificCharacter_Exercice
    {
        public static bool BeginsWithSpecificCharacter(string str, char begin)
        {
           if(str.IndexOf(begin) != 0) {
             return false;
           } else return true;
        }
    }
}