using System;

namespace CarData {
    public class ElectricCar : ICarData {
        //
        // aca irian los atribitos del aut0
        //

        public ElectricCar() 
        {

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
    }

}
