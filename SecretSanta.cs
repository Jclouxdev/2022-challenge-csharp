using System;
using System.Collections.Generic;
namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        public static Dictionary<string,string> SecretSantaDraw(HashSet<string> people)
        {
            // On créer un clone de "people" car sinon on modifie l'objet source "people";
            var inerpoeple = new HashSet<string>(people);
            var dictionary = new Dictionary<string, string>();
            while (inerpoeple.Count > 0) {
                var random = new Random();
                var gifter = random.Next(inerpoeple.Count-1);
                var iterator = inerpoeple.GetEnumerator();
                var i = 0;
                while(iterator.MoveNext()) {
                    if(i == gifter) {
                        var gifterName = iterator.Current;
                        iterator.MoveNext();
                        var giftedName = iterator.Current;
                        inerpoeple.Remove(gifterName);
                        inerpoeple.Remove(giftedName);
                        dictionary.Add(gifterName, giftedName);
                        dictionary.Add(giftedName, gifterName);
                        break;
                    }
                    i++;
                }
            }
            //Console.WriteLine(dictionary.Count);
            return dictionary;
        }
    }
}