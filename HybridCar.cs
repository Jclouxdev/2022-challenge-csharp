namespace CSharpDiscovery.Quest04 {
    public class HybridCar : Car, IThermalCar, IElectricCar {
        public int FuelLevel { get; set; } = 100;
        public int GetFuelLevel() {
            return FuelLevel;
        }

        public int BatteryLevel { get; set; } = 100;
        public int GetBatteryLevel() {
            return BatteryLevel;
        }

        public void FillUp() {
            FuelLevel = 100;
        }

        public void Recharge() {
            BatteryLevel = 100;
        }

        public HybridCar() 
        { 
            Brand = "Unknown";
            Color = "Unknown";
            CurrentSpeed = 0;
            Model = "Unknown";
        }

        public HybridCar(string m_model, string m_brand, string m_color,  int m_speed = 0) : base()
        {
            Model = m_model;
            Brand = m_brand;
            Color = m_color;
            CurrentSpeed = m_speed;
        }

        public override string ToString() {
            var str = Color + " " + Brand + " " + Model + ", Battery: " + BatteryLevel + "%, Fuel: " + FuelLevel + "%";
            return str;
        }
    }
}