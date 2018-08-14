using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            // While - prodyljava dokato ne sre6tne "print"
            while (true)
            {
                if (input == "print")
                {
                    break;
                }

                // izvlicha comandite ot input - consolata i gi vkarva v Array
                string[] commandArr = input.Split();

                // zalaga che imeto na komandata e na pyrva poziciq - spestqvame pisane
                string command = commandArr[0];

                if (command == "add")
                {

                    // zalaga che na 2-ra poziciq shte e indeksa a na 3-ta poziciq shte e cifrata koyato trqbva da se vyvede
                    int index = int.Parse(commandArr[1]);
                    int num = int.Parse(commandArr[2]);

                    // Insert / Add a number in List/Array
                    inputList.Insert(index, num);
                }
                else if (command == "addMany")
                {
                    int index = command[1];

                    // Syzdava nov list ot chisla
                    List<int> elementsToInsert = new List<int>();

                    
                    for (int i = 2; i < inputList.Count; i++)
                    {
                        elementsToInsert.Add(inputList[i]);
                    }

                    List<int> currentResult = new List<int>();
                    for (int i = 0; i < length; i++)
                    {

                    }
                }
            }


        }
    }
}
