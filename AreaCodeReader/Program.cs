using System;
using System.Collections.Generic;

namespace AreaCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] csvLines = System.IO.File.ReadAllLines("AreaCodeRaw.csv");
            var country = new List<State>();          // Creates a list country of the type State

            for (int i = 0; i < csvLines.Length; i++) // For every line in the csv do:
            {
                State state = new State(csvLines[i]);// Make a new instance of State named state                
                country.Add(state);                   // Add state to list country                                               
            }
            

            while (true)
            {
                Console.WriteLine("***   Enter a US State or territory to receive its associated area code(s)   ***");
                Console.WriteLine("***   Or enter a valid US area code to find out its associate state          ***");
                Console.WriteLine("***   Or enter 'quit' to terminate the program                               ***");
                string UserNum = Console.ReadLine();

                for (int z = 0; z < country.Count; z++)  // Loops as many times as there are entries into country 
                {                                        // I think this is where I need to add a third loop 
                    if (country[z].Any(UserNum) == true) // UserNum is definitely a part of some state in country
                    {
                        if (country[z].Name(UserNum) == true)
                        {
                            Console.WriteLine($"{UserNum}'s area code(s) are: {country[z].AreaCode1}, {country[z].AreaCode2}, {country[z].AreaCode3}, {country[z].AreaCode4}, {country[z].AreaCode5}, {country[z].AreaCode6}, {country[z].AreaCode7}, {country[z].AreaCode8}, {country[z].AreaCode9}, {country[z].AreaCode10}, {country[z].AreaCode11}, {country[z].AreaCode12}, {country[z].AreaCode13}, {country[z].AreaCode14}, {country[z].AreaCode15}, {country[z].AreaCode16}, {country[z].AreaCode17}, {country[z].AreaCode18}, {country[z].AreaCode19}, {country[z].AreaCode20}, {country[z].AreaCode21}, {country[z].AreaCode22}, {country[z].AreaCode23}, {country[z].AreaCode24}, {country[z].AreaCode25}, {country[z].AreaCode26}, {country[z].AreaCode27}, {country[z].AreaCode28}");
                        };
                        if (country[z].AreaCode(UserNum) == true)
                        {
                            Console.WriteLine($"Your area code, {UserNum}, is associated with {country[z].StateName}");
                        }


                    }

                }
                if (UserNum == "quit")
                {
                    return;
                }
            }


        }

    }
    
}
