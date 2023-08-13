using System;

namespace properties_and_indexes
{
    internal class Program


    {
        class Car
        {
            string _CarType;
            public virtual string CarType {
                get { return CarType; }
                set { _CarType = value; }
            }
        }

        class Ferrari : Car
        {
            string _CarType;
            public override string CarType
            {
                get { return base.CarType; }
                set
                {
                    base.CarType = value;
                    _CarType = value;
                }
            }
            /* class Employee
             {
                 public string Name { get; set; }
                 public int Age { get; set; }
                 public string Designation { get; set; }*/
            static void Main(string[] args)
            {
                /* Employee emp1 = new Employee
                 {
                     Name = "John",
                     Age = 30,
                     Designation = "Escort"
                 };

                    Console.WriteLine("name: {0}, Age: {1}, Designation: {2}",emp1.Name,emp1.Age,emp1.Designation ); */
                Car objcar = new Car();
                objcar.CarType = "Utility vehicle";
                Ferrari objferrari = new Ferrari();
                objferrari.CarType = "Sports car";
                Console.WriteLine("Car type: " + objferrari.CarType);
                Console.WriteLine("Ferrari car type" + objferrari.CarType);
            }
        }
    }
}
