using System;
using System.Collections.Generic;

namespace TestDelegateCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var lstA = new List<AddClassRoomTypeA>()
            {
                new AddClassRoomTypeA{ BuildingId ="A1",ClassRoom="Toa nha A1"},
                new AddClassRoomTypeA{ BuildingId ="A2",ClassRoom="Toa nha A2"},
            };
            var lstB = new List<AddClassRoomTypeB>()
            {
                new AddClassRoomTypeB{ BuildingName ="B1" ,ClassRoom="Toa nha B1"},
                new AddClassRoomTypeB{ BuildingName ="B2",ClassRoom="Toa nha B2"},
            };

            var builder = new RoomConstraints();
            builder.WithAddRoomTypeA(lstA);
            builder.BuildXml();


            //thuwr voi rooom B
            Console.WriteLine("\n \n Test voi rooomb!");
            builder.WithAddRoomTypeB(lstB);
            builder.BuildXml();
            Console.ReadLine();
        }
    }
}
