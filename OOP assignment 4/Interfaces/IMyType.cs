using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_assignment_4.Interfaces
{
    internal interface IMyType
    {
        public int Id { get; set; }

        public void MyFun(int X);

        public void Print()
        {
            Console.WriteLine("Hello Defult Implement");

        }
    }
}
