namespace VehicleDomain  {
    public interface IVehicleData
     {
        float AutonomyKm(float distanceCovered);
        float CurrentSpeed(float elapsedTime);
    }

}
