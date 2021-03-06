﻿using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double cubeFace = GetCubeFace(n);
            double cubeSpace = GetCubeSpace(n);
            double cubeVolume = GetCubeVolume(n);
            double cubeSurface = GetCubeSurface(n);
            if (type == "face")
            {
                Console.WriteLine("{0:F2}", cubeFace);
            }
            else if (type == "space")
            {
                Console.WriteLine("{0:F2}", cubeSpace);
            }
            else if (type == "volume")
            {
                Console.WriteLine("{0:F2}", cubeVolume);
            }
            else
            {
                Console.WriteLine("{0:F2}", cubeSurface);
            }
        }
        static double GetCubeFace(double face)
        {
            double faceP = Math.Sqrt(Math.Pow(face, 2) * 2);
            return faceP;
        }
        static double GetCubeSpace(double space)
        {
            double spaceP = Math.Sqrt(Math.Pow(space, 2) * 3);
            return spaceP;
        }
        static double GetCubeVolume(double volume)
        {
            double volumeP = (Math.Pow(volume, 3));
            return volumeP;
        }
        static double GetCubeSurface(double surface)
        {
            double surfaceP = (Math.Pow(surface, 2) * 6);
            return surfaceP;
        }

    }
}
