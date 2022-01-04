namespace CSharpDiscovery.Quest03 {
    public class HistoricalMonument : PointOfInterest {
        public int BuildYear { get; set; }

        public HistoricalMonument() 
        { }

        public HistoricalMonument(string m_name, double Latitude, double Longitude,  int m_buildYear) : base()
        {
            Name = m_name;
            BuildYear = m_buildYear;
        }

        public override string ToString() {
            var str = Name+" is a historical monument built in "+BuildYear;
            return str;
        }
    }
}