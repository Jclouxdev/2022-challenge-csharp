namespace CSharpDiscovery.Quest03 {
    public class HistoricalMonument : PointOfInterest {
        public int BuildYear { get; set; }

        public HistoricalMonument() 
        { }

        public HistoricalMonument(string m_name, double m_latitude, double m_longitude,  int m_buildYear) : base()
        {
            Name = m_name;
            Latitude = m_latitude;
            Longitude = m_longitude;
            BuildYear = m_buildYear;
        }

        public override string ToString() {
            var str = Name+" is a historical monument built in "+BuildYear;
            return str;
        }
    }
}