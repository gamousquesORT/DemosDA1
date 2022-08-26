using System;
using System.Net.Sockets;

namespace ejemplosClase
{
    public class Estudiante
    {
        private long _numeroEstudiante;
        private string _nombre;
        private DateTime _fechaIngreso;
        private static long _proximoNumeroEstudiante = 0;

        static Estudiante()
        {
            _proximoNumeroEstudiante = 1;
        }

        public Estudiante()
        {
            _numeroEstudiante = _proximoNumeroEstudiante++;
        }

        public long NumeroEstudiante
        {
            get { return _numeroEstudiante; }
        }

        public static long GetProximoEstudiante()
        {
            return _proximoNumeroEstudiante;
        }

        public DateTime FechaIngreso
        {
            set { _fechaIngreso = value; }
            get { return _fechaIngreso; }
        }
        public string Nombre
        {
            get => _nombre;
            set => _nombre = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}