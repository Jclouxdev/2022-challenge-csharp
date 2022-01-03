using CSharpDiscovery.Models;

namespace CSharpDiscovery.Quest01
{
    public class NextTrafficLightColor_Exercice
    {
        public static TrafficLightColor GetNextTrafficLightColor(TrafficLightColor currentColor)
        {
            if (currentColor == TrafficLightColor.Red) {
              return (TrafficLightColor)1;
            } 
            if (currentColor == TrafficLightColor.Green) {
              return (TrafficLightColor)2;
            } 
            else if (currentColor == TrafficLightColor.Orange) {
              return (TrafficLightColor)3;
            }
            else {
              return TrafficLightColor.None;
            }
        }
    }
}