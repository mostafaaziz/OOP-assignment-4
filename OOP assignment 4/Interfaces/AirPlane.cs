﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_assignment_4.Interfaces
{
    internal class AirPlane : Vehicle, IMovable , IFlyable  
    {
        public void Backward()
        {
            Console.WriteLine("AirPlane Move Backward");
        }

         void IMovable.Forward()
        {
            Console.WriteLine("AirPlane Move Backward On Ground");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("AirPlane Move Backward On Air");
        }

        void IMovable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMovable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
