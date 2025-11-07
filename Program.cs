/*
AI Transparency Statement:
AI was used to shape parts of this assignment, including outlining ideas and improving the structure of the report.
All code and written content were developed independently by me. AI suggestions were refined and reviewed to meet the assignment requirements.
*/



using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;



namespace MyProject
{
    
    class MenuHelper{/* Grouped helper methods into a class*/
        public static void Menu(List<string> options){
                        for (int x=0; x<options.Count;x++)
            {
                    Console.WriteLine($"{x+1}) {options[x]}");

            }                               /* This method creates the menu and has parameters with data type
            of a list, which is called Options*/
        }
        public static int ValidChoice(string prompt, int min, int max){

                /* This method is used to validate the input given by the end user and uses parameters of min and max.*/
            while(true){
                
                Console.WriteLine(prompt);
                string? choice = Console.ReadLine();
                bool isValidInput = int.TryParse(choice, out int SelectedOption);
                if (isValidInput && SelectedOption >= min && SelectedOption <= max)
                {
                    return SelectedOption;
                }

                else
                {   
                    Console.WriteLine($"Invalid input! Choose a number from {min}-{max}");
                }
                
            }

        }
            public static decimal ValidChoice(string prompt, decimal min, decimal max){

                /* This method is used to validate the input given by the end user and uses parameters of min and max.*/
            while(true){
                
                Console.WriteLine(prompt);
                string? choice = Console.ReadLine(); 
                bool isValidInput = decimal.TryParse(choice, out decimal SelectedOption);
                if (isValidInput && SelectedOption >= min && SelectedOption <= max)
                {
                    return SelectedOption;
                }

                else
                {   
                    Console.WriteLine($"Invalid input! Choose a number from {min}-{max}");
                }
                
            }

        }
    }
 
    class Calculator{
        public static void Calculations(string appliance, decimal dailyUsage, decimal waterPrice){
            decimal monthlyUsage=dailyUsage*30;
            decimal yearlyUsage=dailyUsage*365;
            decimal dailyCost=(dailyUsage/1000)*waterPrice;
            decimal monthlyCost=(monthlyUsage/1000)*waterPrice;
            decimal yearlyCost=(yearlyUsage/1000) * waterPrice;
            string receipt = $"{appliance}\n------------------\n" +
                     $"Daily usage (L): {dailyUsage:F2}\n" +
                     $"Monthly usage (L): {monthlyUsage:F2}\n" +
                     $"Yearly usage (L): {yearlyUsage:F2}\n" +
                     $"Estimated Daily Cost (£): £{dailyCost:F2}\n" +
                     $"Estimated Monthly Cost (£): £{monthlyCost:F2}\n" +
                     $"Estimated Yearly Cost (£): £{yearlyCost:F2}\n\n";
            Console.WriteLine(receipt);
            File.AppendAllText("WaterUsageReceipt.txt", receipt);
            Console.WriteLine(" Receipt has been created and saved to WaterUsageReceipt.txt\n");
        }
        public static void  CalcDailyUsage(string appliance, decimal flowRate, int minutes, decimal waterPrice){
            decimal dailyUsage=flowRate*minutes;
            Calculator.Calculations(appliance,dailyUsage,waterPrice);
        }
        public static void CalcDailyUsage(string appliance,decimal volume, decimal cycles, decimal waterPrice){
            decimal dailyUsage=volume*cycles;
            Calculator.Calculations(appliance,dailyUsage,waterPrice);
        }
        public static string GetValidApplianceName()
        {
            List<string> forbiddenSymbols;

            try
            {
                string csvPath = Path.Combine(AppContext.BaseDirectory, "ForbiddenSymbols.csv");

                if (File.Exists(csvPath))
                {
                    forbiddenSymbols = File.ReadAllLines(csvPath)
                                        .Where(line => !string.IsNullOrWhiteSpace(line))
                                        .ToList();
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            catch
            {
                //I did this if csv issues occur
                forbiddenSymbols = new List<string> { "<", ">", "|", "*", "\\", "/", "?", ":" };
                Console.WriteLine("ForbiddenSymbols.csv is not found. Using default forbidden symbols.\n");
            }

            string appName = "";

            while (true)
            {
                Console.WriteLine("Enter the name of Appliance:");
                appName = Console.ReadLine()?.Trim() ?? "";

                if (string.IsNullOrEmpty(appName))
                {
                    Console.WriteLine("Appliance name cannot be empty. Please enter a valid name.");
                    continue;
                }

                if (forbiddenSymbols.Any(symbol => appName.Contains(symbol)))
                {
                    Console.WriteLine("Appliance name contains forbidden symbols. Please enter a valid name, with numbers or letters only.");
                    continue;
                }

                break;
            }

            return appName;
        }


    
    public static void RunCalculator(){

        string appName=GetValidApplianceName();
        int SelectedOption=MenuHelper.ValidChoice("\nPick 1 or 2:\n1) For Time-Based Appliances \n2) For Cycle based appliances \n",1,2);
        if (SelectedOption==1){
            decimal flowRate=MenuHelper.ValidChoice("Enter the flow rate (Litres/Minute)",0m,999999999m);
            int minutes=MenuHelper.ValidChoice("Enter minutes used per day",0,999999999);
            decimal waterPrice=MenuHelper.ValidChoice("Enter water price per 1000L",0m,999999999m);
            Calculator.CalcDailyUsage(appName,flowRate, minutes, waterPrice);
            }
        else if (SelectedOption==2){
            decimal volume=MenuHelper.ValidChoice("Enter the volume in (Litres/cycle)",0m,999999999m);
            decimal cycles=MenuHelper.ValidChoice("Enter cycles per day",0m,999999999m);
            decimal waterPrice=MenuHelper.ValidChoice("Enter water price per 1000L",0m,999999999m);
            Calculator.CalcDailyUsage(appName,volume,cycles,waterPrice);
        }
    }

    class HexCalc {
    private static Dictionary<int, string> LoadHexMap()
    {
        string csvPath = Path.Combine(AppContext.BaseDirectory, "hexnumbers.csv");
        var hexMap = new Dictionary<int, string>();

        try
        {
            if (File.Exists(csvPath))
            {
                var lines = File.ReadAllLines(csvPath).Skip(1); // skip header
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[0], out int num))
                    {
                        hexMap[num] = parts[1].Trim();
                    }
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
        catch
        {
            // Default fallback if CSV not found or broken
            string[] defaultHex = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            for (int i = 0; i < 16; i++)
                hexMap[i] = defaultHex[i];
            Console.WriteLine("hexnumbers.csv not found. Using default hex mapping.\n");
        }

        return hexMap;
    }

    public static void RunHexCalc()
    {
        var hexMap = LoadHexMap();
        int denary = MenuHelper.ValidChoice("Enter the base 10 number you want to convert to Hexadecimal:", 0, 999999999);

        if (denary == 0)
        {
            Console.WriteLine("0x0");
            return;
        }

        var remainder = new List<string>();
        while (denary > 0)
        {
            int digit = denary % 16;
            remainder.Add(hexMap[digit]);
            denary /= 16;
        }

        remainder.Reverse();
        Console.WriteLine($"Hexadecimal: 0x{string.Join("", remainder)}\n");
    }
}
    
    class Program
    {
        
        static void Main(string[] args)
        { /* The main defines the list and uses boolean logic to repeat the menu after eaach method
        for the options in the menu finish running I will also use new lines for readability*/
            List<string> options = new List<string> { "Household Water Usage & Cost Calculator", "Library Catalogue", "Hexadecimal Converter", "End the Program" };
            bool menuState=false;
            while (menuState==false){
                    MenuHelper.Menu(options);
                    int SelectedOption=MenuHelper.ValidChoice("Choose an option: \n",1,4);
                    switch(SelectedOption)
                    {
                    case 1:
                        Console.WriteLine($"\nRunning {options[SelectedOption-1]}\n");
                        string endCalc;
                        do
                        {
                            Calculator.RunCalculator();

                            while (true)
                            {
                                Console.WriteLine("Do you want to perform another calculation? Y/N");
                                endCalc = Console.ReadLine().Trim().ToUpper();
                                if (endCalc == "Y" || endCalc == "YES" || endCalc == "N" || endCalc == "NO")
                                    break; 
                                Console.WriteLine("Invalid input! Enter Y/N");
                            }

                        } while (endCalc == "Y" || endCalc == "YES");

                        break;
                        case 2:
                        Console.WriteLine($"\nRunning {options[SelectedOption-1]} \n");
                        break;
                        case 3:
                        Console.WriteLine($"\nRunning {options[SelectedOption-1]} \n");
                        HexCalc.RunHexCalc();
                        break;
                        case 4:
                        Console.WriteLine("\nTerminated the Program. \n ");
                        menuState=true;
                        break;
                        
                    }
            }

            }
        }
}}