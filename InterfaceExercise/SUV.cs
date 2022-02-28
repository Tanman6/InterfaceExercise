using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool Has4WheelDrive { get; set; }

        public bool Has2PassengerRows { get; set; }

        public bool Has4Wheels { get; set; }

        public string Noise { get; set; }

        public int NumberOfDoors { get; set; }

        public bool HasSunRoof { get; set; }

        public string Motto { get; set; }

        public bool HasLogo { get; set; }

        public SUV()
        {
        }
    }
}
