﻿using System;
using System.Collections.Generic;

namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource) == false)
                {
                    resources.Add(resource, 0);
                }

                resources[resource] += quantity;
            }
            foreach (KeyValuePair<string, int> resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
