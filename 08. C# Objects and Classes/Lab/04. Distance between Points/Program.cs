using DistanceBetweenPoints;
using System;
using System.Linq;

namespace _04._Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstCoordInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] secondCoordInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point firstPoint = new Point(firstCoordInput[0], firstCoordInput[1]);

            Point secondPoint = new Point(secondCoordInput[0], secondCoordInput[1]);

        }
    }
}
