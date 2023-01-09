using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Design
{
    public class ParkingSystem {
        private int[] ParkingPlaces { get; set; }

        public ParkingSystem(int big, int medium, int small) {
            ParkingPlaces = new int[] { 0, big, medium, small };
        }
    
        public bool AddCar(int carType) {
            return --ParkingPlaces[carType] >= 0;
        }
    }

    public static class Program_1603
    {
        public static void Main_335(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
