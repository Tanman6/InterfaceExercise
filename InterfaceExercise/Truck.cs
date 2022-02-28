using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int BedSizeInFeet { get; set; }

        public bool HasToolBox { get; set; }

        public bool Has4Wheels { get; set; }

        public string Noise { get; set; }

        public int NumberOfDoors { get; set; }

        public bool HasSunRoof { get; set; }

        public string Motto { get; set; }

        public bool HasLogo { get; set; }

        public Truck()
        {
        }
    }
}
