using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle DONE
             * The vehicle class shall have three string properties Year, Make, and Model DONE
             * Set the defaults to something generic in the Vehicle class 
             * Vehicle shall have an abstract method called DriveAbstract with no implementation DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle DONE
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle DONE
             * Provide the implementations for the abstract methods DONE
             * Only in the Motorcycle class will you override the virtual drive method DONE
            */

            // Create a list of Vehicle called vehicles DONE

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class DONE
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list DONE
             * Using a foreach loop iterate over each of the properties DONE
             */
            List<Vehicle> vehicles = new List<Vehicle>();

            Car car1 = new Car() { HasTrunk = true, Make = "Toyota", Model = "Yaris", Year = 2008 };
            Motorcycle moto1 = new Motorcycle() { HasSidecar = false, Make = "Triumph", Model = "S", Year = 2011 };
            Vehicle vehicleCar = new Car() { HasTrunk = false, Make = "Mazda", Model = "626", Year = 2006 };
            Vehicle vehicleMoto = new Motorcycle() { HasSidecar = true, Make = "Suzuki", Model = "Intruder", Year = 2001 };
             
            vehicles.Add(car1);
            vehicles.Add(moto1);
            vehicles.Add(vehicleCar);
            vehicles.Add(vehicleMoto);

            foreach (Vehicle vehicle in vehicles) {
                Type vehicleType = vehicle.GetType();
                Console.WriteLine($"Year:{vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model}");
                if (vehicleType.Name == "Motorcycle") {
                    //"casting", assigning the vehicle getting processed to type Motorcyle instead of type Vehicle allows it to be read as a Motorcycle, unlocking its properties as a Motorcycle
                    Motorcycle newmoto = (Motorcycle)vehicle;
                    Console.WriteLine($"Does this motorcycle have a sidecar? {newmoto.HasSidecar}\n\n\n\n");
                }
                if (vehicleType.Name == "Car") {
                    Car newcar = (Car)vehicle;
                    Console.WriteLine($"Does this car have a trunk? {newcar.HasTrunk}\n\n\n\n");
                }
            }



            // Call each of the drive methods for one car and one motorcycle DONE
            car1.DriveAbstract();
            car1.DriveVirtual();
            moto1.DriveAbstract();
            moto1.DriveVirtual();


                #endregion
            Console.ReadLine();
        }
    }
}
