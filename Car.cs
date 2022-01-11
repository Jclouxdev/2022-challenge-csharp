namespace CSharpDiscovery.Quest04 {
  public class Car : Vehicule {
      public string Model { get; set; }

        public Car() 
        { 
            Brand = "Unknown";
            Color = "Unknown";
            CurrentSpeed = 0;
            Model = "Unknown";
        }

        public Car(string m_model, string m_brand, string m_color,  int m_speed = 0) : base(m_brand, m_color, m_speed)
        {
            Model = m_model;
        }

        public override string ToString() {
            var str = Color + " " + Brand + " " + Model;
            return str;
        }

        public override void Accelerate(int number) {
            if(CurrentSpeed < 180) {
                /*if((CurrentSpeed + number) < 180) {
                    CurrentSpeed += number;
                } else CurrentSpeed = 180;*/
                CurrentSpeed = (CurrentSpeed + number) < 180 ? CurrentSpeed + number : 180;
            }
            else CurrentSpeed = 180;
        }

        public override void Brake(int number) {
            /*if((CurrentSpeed - number) > 0) {
                CurrentSpeed -= number;
            } else CurrentSpeed = 0;*/
            CurrentSpeed = (CurrentSpeed - number) > 0 ? CurrentSpeed - number : 0;
        }
    }
}