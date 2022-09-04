using System;

namespace CarData {
    public class ElectricCar : ICarData {
        //
        // aca irian los atribitos del autElectrico
        //
        private string _batteryType; 
        public ElectricCar()
        {
            _batteryType = "ni cad";
        }

        public float AutonomyKm(float distanceCovered)
        {
            Random rnd = new Random();
            return rnd.Next(140) * distanceCovered;
        }

        public float CurrentSpeed(float elapsedTime)
        {
            Random rnd = new Random(140);
            return rnd.Next(140) * elapsedTime;
        }

        public String BatteryType
        {
            set => _batteryType = value;
            get => _batteryType;
        }

    }

}
