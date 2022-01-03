namespace CSharpDiscovery.Quest01
{
    public class GetStringSize_Exercice
    {
        public static int GetStringSize(string str)
        {
          if(str != null) {
            if(str.Length != 0) {
              return(str.Length);
            } else return(0);
          }
          else return(0);
        }
    }
}