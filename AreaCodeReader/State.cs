using System;

namespace AreaCodeReader
{
    public class State
    {
        public string StateName, AreaCode1, AreaCode2, AreaCode3, AreaCode4, AreaCode5, AreaCode6, AreaCode7, AreaCode8, AreaCode9, AreaCode10, AreaCode11, AreaCode12, AreaCode13, AreaCode14, AreaCode15, AreaCode16, AreaCode17, AreaCode18, AreaCode19, AreaCode20, AreaCode21, AreaCode22, AreaCode23, AreaCode24, AreaCode25, AreaCode26, AreaCode27, AreaCode28;
        
        
        
        public State(string rowData)
        {
            string[] data = rowData.Split(',');
            
            this.StateName = data[0];
            this.AreaCode1 = data[1];
            this.AreaCode2 = data[2];
            this.AreaCode3 = data[3];
            this.AreaCode4 = data[4];
            this.AreaCode5 = data[5];
            this.AreaCode6 = data[6];
            this.AreaCode7 = data[7];
            this.AreaCode8 = data[8];
            this.AreaCode9 = data[9];
            this.AreaCode10 = data[10];
            this.AreaCode11 = data[11];
            this.AreaCode12 = data[12];
            this.AreaCode13 = data[13];
            this.AreaCode14 = data[14];
            this.AreaCode15 = data[15];
            this.AreaCode16 = data[16];
            this.AreaCode17 = data[17];
            this.AreaCode18 = data[18];
            this.AreaCode19 = data[19];
            this.AreaCode20 = data[20];
            this.AreaCode21 = data[21];
            this.AreaCode22 = data[22];
            this.AreaCode23 = data[23];
            this.AreaCode24 = data[24];
            this.AreaCode25 = data[25];
            this.AreaCode26 = data[26];
            this.AreaCode27 = data[27];
            this.AreaCode28 = data[28];
        }

               
        public override string ToString()
        {
            string Full = $"Your area code is associated with {StateName}";
            return Full;
        }

        public bool Any(string value)
        {
            
            if (StateName == value || AreaCode1 == value || AreaCode2 == value || AreaCode3 == value || AreaCode4 == value || AreaCode5 == value || AreaCode6 == value || AreaCode7 == value || AreaCode8 == value || AreaCode9 == value || AreaCode10 == value || AreaCode11 == value || AreaCode12 == value || AreaCode13 == value || AreaCode14 == value || AreaCode15 == value || AreaCode16 == value || AreaCode17 == value || AreaCode18 == value || AreaCode19 == value || AreaCode20 == value || AreaCode21 == value || AreaCode22 == value || AreaCode23 == value || AreaCode24 == value || AreaCode25 == value || AreaCode26 == value || AreaCode27 == value || AreaCode28 == value)
            { 
                return true;
            } else
            {
                return false;
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
            if (AreaCode1 == value || AreaCode2 == value || AreaCode3 == value || AreaCode4 == value || AreaCode5 == value || AreaCode6 == value || AreaCode7 == value || AreaCode8 == value || AreaCode9 == value || AreaCode10 == value || AreaCode11 == value || AreaCode12 == value || AreaCode13 == value || AreaCode14 == value || AreaCode15 == value || AreaCode16 == value || AreaCode17 == value || AreaCode18 == value || AreaCode19 == value || AreaCode20 == value || AreaCode21 == value || AreaCode22 == value || AreaCode23 == value || AreaCode24 == value || AreaCode25 == value || AreaCode26 == value || AreaCode27 == value || AreaCode28 == value)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
    
    
}

    
