using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System;
using CsvHelper.Configuration;




while (true)
{
    var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
    {
        HasHeaderRecord = false
    };

    using var streamReader = File.OpenText("AreaCodeRaw.csv");
    using var csvReader = new CsvReader(streamReader, csvConfig);
    //Console.ForegroundColor = ConsoleColor.White;
    //Console.BackgroundColor = ConsoleColor.Red;
    string value;

    Console.WriteLine("Please enter a valid 3 digit area code.");
    string UserNum = Console.ReadLine();
    

    while (csvReader.Read())
    {
        var stateName = csvReader.GetField(0);
        var areaCode1 = csvReader.GetField(1);
        var areaCode2 = csvReader.GetField(2);
        var areaCode3 = csvReader.GetField(3);
        var areaCode4 = csvReader.GetField(4);
        var areaCode5 = csvReader.GetField(5);
        var areaCode6 = csvReader.GetField(6);
        var areaCode7 = csvReader.GetField(7);
        var areaCode8 = csvReader.GetField(8);
        var areaCode9 = csvReader.GetField(9);
        var areaCode10 = csvReader.GetField(10);
        var areaCode11 = csvReader.GetField(11);
        var areaCode12 = csvReader.GetField(12);
        var areaCode13 = csvReader.GetField(13);
        var areaCode14 = csvReader.GetField(14);
        var areaCode15 = csvReader.GetField(15);
        var areaCode16 = csvReader.GetField(16);
        var areaCode17 = csvReader.GetField(17);
        var areaCode18 = csvReader.GetField(18);
        var areaCode19 = csvReader.GetField(19);
        var areaCode20 = csvReader.GetField(20);
        var areaCode21 = csvReader.GetField(21);
        var areaCode22 = csvReader.GetField(22);
        var areaCode23 = csvReader.GetField(23);
        var areaCode24 = csvReader.GetField(24);
        var areaCode25 = csvReader.GetField(25);
        var areaCode26 = csvReader.GetField(26);
        var areaCode27 = csvReader.GetField(27);
        var areaCode28 = csvReader.GetField(28);
        var areaCode29 = csvReader.GetField(29);
        for (int i = 0; csvReader.TryGetField<string>(i, out value); i++)
        {

            if (areaCode1 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName}");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode2 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode3 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode4 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode5 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode6 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode7 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode8 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode9 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode10 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode11 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode12 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode13 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode14 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode15 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode16 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode17 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName}");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode18 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode19 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode20 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode21 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode22 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode23 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode24 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode25 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode26 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode27 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode28 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            }
            else if (areaCode29 == UserNum)
            {
                Console.WriteLine($"Your number, {UserNum}, is associated with {stateName} ");
                Console.WriteLine("Try another number below or enter '5' to exit.");
                UserNum = Console.ReadLine();
                continue;
            };
            if (UserNum == "5")
            {
                return;
            }
            

        }

    }
   
}

