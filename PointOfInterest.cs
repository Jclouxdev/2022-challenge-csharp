using System;
using System.Windows;
namespace CSharpDiscovery.Quest03 {
    public class PointOfInterest {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public static string GoogleMapsUrlTemplate { get; } = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

        public PointOfInterest() {
            Name = "Bordeaux Ynov Campus";
            Latitude = 44.854186;
            Longitude = -0.5663056;
        }
        public PointOfInterest(string m_name, double m_latitude, double m_longitude) {
            Latitude = m_latitude;
            Longitude = m_longitude;
            Name = m_name;
        }

        public string GetGoogleMapsUrl() {
            var localisation = Name.Replace(" ", "+");
            var url = "https://www.google.com/maps/place/"+localisation+"/@"+Latitude+","+Longitude+",15z/";
            return url;
        }

        public override string ToString() {
            var str = Name+" (Lat="+Latitude+", Long="+Longitude+")";
            return str;
        }
    }
}