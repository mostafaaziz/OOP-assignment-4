using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_assignment_4.Interfaces
{
    internal class MyType : IMyType
    {
        public int Id { get; set; } //Automatic Property

        //non static function [object member function]
        public void MyFun(int X)
        {
            Console.WriteLine($"Hello X = {X} , ID = {Id}");
        }
    }
}
