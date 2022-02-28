using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool IsSadan { get; set; }

        public bool IsConvertable { get; set; }

        public bool Has4Wheels { get; set; }

        public string Noise { get; set; }

        public int NumberOfDoors { get; set; }

        public bool HasSunRoof { get; set; }

        public string Motto { get; set; }

        public bool HasLogo { get; set; }


        public Car()
        {
        }
    }
}
