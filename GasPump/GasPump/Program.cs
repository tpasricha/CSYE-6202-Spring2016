using System.IO;
using System;

public class Program
{
    public enum GasType
    {
        None,
        RegularGas,
        MidgradeGas,
        PremiumGas,
        DieselFuel
    }

    static void Main(string[] args)
    {

        string userInput = String.Empty;
        GasType gasType = GasType.None;
        double gasAmount = 0.0d;
        double totalCost=0.0d;
        while (true)
        {
            Console.WriteLine("Please enter purchased gas type, Q/q to quit:");
            userInput = Console.ReadLine();
            if (UserEnteredSentinelValue(userInput) || !UserEnteredValidGasType(userInput))
                break;
            gasType = GasTypeMapper(userInput[0]);

            Console.WriteLine("Please enter purchased gas amount, Q/q to quit:");
            userInput = Console.ReadLine();

            if (UserEnteredSentinelValue(userInput) && !UserEnteredValidAmount(userInput))
                break;
            gasAmount = Double.Parse(userInput);
            Console.WriteLine("You bought " + gasAmount + " gallons of " + gasType.ToString() + " at $" + GasPriceMapper(gasType));
            totalCost = GasPriceMapper(gasType);
            CalculateTotalCost(gasType, gasAmount, ref totalCost);
            Console.WriteLine("Your total cost for this purchase is: $" + totalCost);
        }
    }   

    // use this method to check and see if sentinel value is entered
    public static bool UserEnteredSentinelValue(string userInput)
    {
        var result = false;
        if(userInput == null)
            return false;
        else if (userInput == "Q" || userInput == "q")
        {
            result = true;
            Console.WriteLine("Application terminated");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();         

        }
        return result;
    }

    // use this method to parse and check the characters entered
    // this does not conform 
    public static bool UserEnteredValidGasType(string userInput)
    {
        var result = false;
        if (userInput != null)
        {
            if (userInput.Equals("p") || userInput.Equals("P"))
                return true;
            else if (userInput.Equals("m") || userInput.Equals("M"))
                return true;
            else if (userInput.Equals("r") || userInput.Equals("R"))
                return true;
            else if (userInput.Equals("d") || userInput.Equals("D"))
                return true;
            {
                return false;
            }
        }
            return result;
    }

    // use this method to parse and check the double type entered
    // please use Double.TryParse() method 
    public static bool UserEnteredValidAmount(string userInput)
    {
        var result = false;
        double i = 0;
            if (double.TryParse(userInput, out i))
                result = true;
        return result;
    }

    // use this method to map a valid char entry to its enum representation
    // e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
    // this mapping "must" be used within CalculateTotalCost() method later on
    public static GasType GasTypeMapper(char c)
    {
        GasType gasType = GasType.None;
        //c = Console.ReadLine(gasType);
        switch (c)
        {
            case 'r':
            case 'R':
                gasType = GasType.RegularGas;
                break;
            case 'm':
            case 'M':
                gasType = GasType.MidgradeGas;
                break;
            case 'p':
            case 'P':
                gasType = GasType.PremiumGas;
                break;
            case 'd':
            case 'D':
                gasType = GasType.DieselFuel;
                break;
        }

        return gasType;
    }

    public static double GasPriceMapper(GasType gasType)
    {
        var result = 0.0;

        // your implementation here
        switch (gasType)
        {
            case GasType.RegularGas:
                result = 1.94;
                break;
            case GasType.MidgradeGas:
                result = 2.00;
                break;
            case GasType.PremiumGas:
                result = 2.24;
                break;
            case GasType.DieselFuel:
                result = 2.17;
                break;
        }

        return result;
    }

    public static void CalculateTotalCost(GasType gasType, double gasAmount, ref double totalCost)
    {
        // your implementation here
        if((gasType == GasType.RegularGas) && (gasAmount>0))
        {
            totalCost = gasAmount * 1.94;
        }
        else if ((gasType == GasType.MidgradeGas) && (gasAmount > 0))
        {
            totalCost = gasAmount * 2.00;
        }
        else if ((gasType == GasType.PremiumGas) && (gasAmount > 0))
        {
            totalCost = gasAmount * 2.24;
        }
        else if ((gasType == GasType.DieselFuel) && (gasAmount > 0))
        {
            totalCost = gasAmount * 2.17;
        }
        else
        {
            totalCost = 0;
        }       
    }
}
