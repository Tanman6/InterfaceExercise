using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool Has4Wheels { get; set; }

        public string Noise { get; set; }

        public int NumberOfDoors { get; set; }

        public bool HasSunRoof { get; set; }

    }
}
