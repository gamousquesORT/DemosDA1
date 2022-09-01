using System;

namespace CarData {
    public class GasolineCar : ICarData {
        //
        // aca irian los atribitos del aut0
        //

        public GasolineCar() 
        {

        }

        public float AutonomyKm(float distanceCovered)
        {
            Random rnd = new Random();
            return rnd.Next(240) * distanceCovered *2;
        }

        public float CurrentSpeed(float elapsedTime)
        {
            Random rnd = new Random();
            return rnd.Next(240) * elapsedTime * 0.5f;
        }
    }

}
