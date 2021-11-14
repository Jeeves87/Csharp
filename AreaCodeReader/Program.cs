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


            Console.WriteLine("***   Enter a US State or territory to receive its associated area code(s)   ***");
            Console.WriteLine("***   Or enter a valid US area code to find out its associated state         ***");
            Console.WriteLine("***   Or enter 'quit' to terminate the program                               ***");
            


            while (true)
            {
                string UserNum = Console.ReadLine();


                for (int z = 0; z < country.Count; z++)  // Loops as many times as there are entries into country 
                {                                        // I think this is where I need to add a third loop 
                    
                        if (string.Equals(UserNum, country[z].StateName, StringComparison.OrdinalIgnoreCase))
                        {                            
                            Console.WriteLine(String.Join("; ", country[z].areaCodes));
                        };
                        if (country[z].AreaCode(UserNum) == true)
                        {
                            Console.WriteLine($"Your area code, {UserNum}, is associated with {country[z].StateName}");
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
