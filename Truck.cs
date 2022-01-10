namespace CSharpDiscovery.Quest04 {
    public class Truck : Vehicule {
        public int Tonnage { get; set; }

        public Truck() 
        { 
            Brand = "Unknown";
            Color = "Unknown";
            CurrentSpeed = 0;
            Tonnage = 0;
        }

        public Truck(int m_tonnage, string m_brand, string m_color,  int m_speed = 0) : base()
        {
            Tonnage = m_tonnage;
            Brand = m_brand;
            Color = m_color;
            CurrentSpeed = m_speed;
        }

        public override string ToString() {
            var str = Color + " " + Brand + " " + Tonnage +"T Truck";
            return str;
        }

        public override void Accelerate(int number) {
            if(CurrentSpeed < 100) {
                if((CurrentSpeed + number) < 100) {
                    CurrentSpeed += number;
                } else CurrentSpeed = 100;
            }
            else CurrentSpeed = 100;
        }

        public override void Brake(int number) {
            if((CurrentSpeed - number) > 0) {
                CurrentSpeed -= number;
            } else CurrentSpeed = 0;
        }
    }
}