using OOP_assignment_4.Interfaces;

namespace OOP_assignment_4
{
    internal class Program
    {
        public static void Print10NumFromSeries(ISeries series)
        {
            if (series != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{series.Current}");
                    series.GetNext();

                }
            }
            series.Reset();


        }
        static void Main(string[] args)
        {
            #region Interface

            //IMyType myType;

            //MyType myType1 = new MyType();
            //myType1.Id = 10;
            //myType1.MyFun(100);
            //myType1.Print(); //invalid -> Defult implemented method

            //IMyType myType = new MyType();
            //myType.Id = 10;
            //myType.MyFun(600);
            //myType.Print();

            #endregion

            #region Interface Ex1
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumFromSeries(seriesByThree);

            #endregion

            #region Interface Ex2

            //Car car = new Car();
            //car.Backward();

            //AirPlane plane = new AirPlane();
            //plane.Backward();

            //IMovable movable = new AirPlane();
            //movable.Forward();

            //IFlyable movableFly = new AirPlane();
            //movableFly.Forward();

            #endregion

            #region Shallow Copy And Deep Copy
            #region Array Of Value Type
            //int[] Arr01 = { 1, 2, 3};
            //int[] Arr02 = new int[3];

            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC Of Arr01 = {Arr02.GetHashCode()}");

            #region Shallow Copy
            //Arr02 = Arr01;

            //Console.WriteLine("After Shallow Copy");

            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC Of Arr01 = {Arr02.GetHashCode()}");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");
            //Arr02[0] = 100;
            //Console.WriteLine("After Arr02[0] = 100;");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            #endregion

            #region Deep Copy
            //Arr02 = (int[]) Arr01.Clone();
            //Console.WriteLine("After Deep Copy");

            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC Of Arr01 = {Arr02.GetHashCode()}");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            //Arr01[0] = 100;

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");


            #endregion

            #endregion



            #endregion

            #region Array Of Reference Type
            #region Array Of String [Immutable Type] 
            string[] Names01 = { "Omar" };
            string[] Names02 = new string[1];

            Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}");
            Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}");

            #region Shallow Copy
            //Names02 = Names01;

            //Console.WriteLine("After Shallow Copy");

            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");

            //Names02[0] = "aya";

            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}"); 
            #endregion
            

            #endregion
            #endregion

        }
    }
}
    

