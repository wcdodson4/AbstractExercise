using System;

namespace AbstractExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            var myMotorcycle = new Motorcycle();

            myCar.Drive();
            myMotorcycle.Drive();
        }
    }
}
