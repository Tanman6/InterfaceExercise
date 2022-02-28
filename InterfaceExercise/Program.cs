using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<IVehicle>();
            var companyList = new List<ICompany>();

            var car = new Car { IsSadan = true, IsConvertable = false, Has4Wheels = true, Noise = "vrrr vrrrrr", NumberOfDoors = 2, HasSunRoof = true, HasLogo = true, Motto = "Think Small" };

            var truck = new Truck { BedSizeInFeet = 8, HasToolBox = true, Has4Wheels = true, Noise = "burrrrrr", NumberOfDoors = 2, HasSunRoof = false, HasLogo = true, Motto = "Built Ford Tough" };

            var suv = new SUV { Has4WheelDrive = true, Has2PassengerRows = false, Has4Wheels = true, Noise = "Vroom", NumberOfDoors = 4, HasSunRoof = true, HasLogo = true, Motto = "Experience Amazing" };

            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(suv);

            companyList.Add(car);
            companyList.Add(truck);
            companyList.Add(suv);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Does this vehicle have four wheels?: {vehicle.Has4Wheels}");
                Console.WriteLine($"Noise: {vehicle.Noise}");
                Console.WriteLine($"Number of Doors: {vehicle.NumberOfDoors}");
                Console.WriteLine($"Does this vehicle have a sun roof?: {vehicle.HasSunRoof}");
                Console.WriteLine();

            }

            foreach (var v1 in companyList)
            {
                Console.WriteLine($"Company motto for this vehicle: {v1.Motto}");
                Console.WriteLine($"Does this company have a logo?: {v1.HasLogo}");
                Console.WriteLine();
            }

            Console.WriteLine($"Is the car a sadan?: {car.IsSadan}");
            Console.WriteLine($"Is the car a convertable?: {car.IsConvertable}");
            Console.WriteLine();

            Console.WriteLine($"The truck's bed size in feet is: {truck.BedSizeInFeet}");
            Console.WriteLine($"Does the truck have a tool box?: {truck.HasToolBox}");
            Console.WriteLine();

            Console.WriteLine($"Does the SUV have four wheel drive?: {suv.Has4WheelDrive}");
            Console.WriteLine($"Does the SUV have two passenger rows?: {suv.Has2PassengerRows}");

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
