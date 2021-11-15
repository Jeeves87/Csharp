using System;
using System.Collections.Generic;
using System.Linq;

namespace AreaCodeReader
{
    public class State
    {
        public string StateName;
        public List<string> areaCodes = new();


        public State(string rowData)
        {
            List<string> areaCodes = new();
            string[] data = rowData.Split(',');

            this.StateName = data[0];
            for (int i = 1; i < data.Count(x => x != ""); i++)
            {
                this.areaCodes.Add(data[i]);
            }           
           
        }

        public bool AreaCode(string value)
        {
            if (areaCodes.Contains(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
                
    }
        
}

    
