namespace VehicleDomain {
    public class GasolineCar : IVehicleData {
        //
        // aca irian los atribitos del aut0
        //
        private int _cylinders;
        
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
        

        public int Cylinders
        {
            get => _cylinders;
            set => _cylinders = value;
        }
    }

}
