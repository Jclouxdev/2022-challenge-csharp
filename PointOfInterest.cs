using System;
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

        public int GetDistance(PointOfInterest other)
        {
            double latA = Latitude;
            double longA = Longitude;
            double latB = other.Latitude;
            double longB = other.Longitude;
            
            var baseRad = Math.PI * latA / 180;
            var targetRad = Math.PI * latB / 180;
            var theta = longA - longB;
            var thetaRad = Math.PI * theta / 180;

            var distance = Math.Sin(baseRad) * Math.Sin(targetRad) + Math.Cos(baseRad) *
            Math.Cos(targetRad) * Math.Cos(thetaRad);
            distance = Math.Acos(distance);

            distance = distance * 180 / Math.PI;
            distance = distance * 60 * 1.1515;

            double calc = Math.Round(distance * 1.609344);
            int cast;
            cast = (int)calc;
            return cast;
        }

        public static int GetDistance(PointOfInterest p1, PointOfInterest p2)
        {
            double latA = p1.Latitude;
            double longA = p1.Longitude;
            double latB = p2.Latitude;
            double longB = p2.Longitude;
            
            var baseRad = Math.PI * latA / 180;
            var targetRad = Math.PI * latB / 180;
            var theta = longA - longB;
            var thetaRad = Math.PI * theta / 180;

            var distance = Math.Sin(baseRad) * Math.Sin(targetRad) + Math.Cos(baseRad) *
            Math.Cos(targetRad) * Math.Cos(thetaRad);
            distance = Math.Acos(distance);

            distance = distance * 180 / Math.PI;
            distance = distance * 60 * 1.1515;

            double calc = Math.Round(distance * 1.609344);
            int cast;
            cast = (int)calc;
            return cast;
        }
    }
}