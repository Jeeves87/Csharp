using System;
using System.Collections.Generic;
using System.Linq;

namespace AreaCodeReader
{
    public class State
    {
        public string StateName, AreaCode1, AreaCode2, AreaCode3, AreaCode4, AreaCode5, AreaCode6, AreaCode7, AreaCode8, AreaCode9, AreaCode10, AreaCode11, AreaCode12, AreaCode13, AreaCode14, AreaCode15, AreaCode16, AreaCode17, AreaCode18, AreaCode19, AreaCode20, AreaCode21, AreaCode22, AreaCode23, AreaCode24, AreaCode25, AreaCode26, AreaCode27, AreaCode28;
        //public List<string> areaCodes;
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
                       
        

        public bool Any(string value)
        {
            
            if (StateName == value || this.areaCodes.Contains(value))
            { 
                return true;
            } else
            {
                return false;
            }
            
        }

        public void CheckEm()
        {
            foreach (string i in areaCodes)
            {
                Console.WriteLine(i);
            }    
        }

        public bool Name(string value)
        {
            if (StateName == value)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool AreaCode(string value)
        {
            if (areaCodes.Contains(value))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
    
    
}

    
