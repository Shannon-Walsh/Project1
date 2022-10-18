// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

//Request input from user
//location, monthly expenses
//Calculate the cost of living
//factors + monthly expenses
//Output the amount of $ to live in city x

string location = "";
double expenses = 0;

Console.WriteLine("Please select your location: ");
Console.WriteLine();
Console.WriteLine("1 - Redmond, Washington");
Console.WriteLine();
Console.WriteLine("2 - Atlanta, Georgia");
location = Console.ReadLine();
Console.WriteLine(location);

Console.WriteLine("Please input your monthly expenses: ");
expenses = Double.Parse(Console.ReadLine());
Console.WriteLine(expenses);

SaveToFile(expenses);
CostOfLiving();

static void CostOfLiving()
{
    double stateTaxGA = 0.0575;
    //no state tax in WA
    double salesTaxATL = 0.089;
    double salesTaxRED = 0.10100;


    //housing, food, taxes, transportation, health care, entertainment, education
}

static void SaveToFile(double expenses)
{
    string fileName;
    string header;

    fileName = "Expenses.txt";
    header = "User estimated expenses:";
    WriteContents(header, fileName, expenses);

}

static void WriteContents(string header, string fileName, double expenses)
{
if (!File.Exists(fileName))
    {
        StreamWriter writer = new StreamWriter(fileName);
        writer.WriteLine(header);
        writer.Write(expenses);
        writer.Close();
    }
else
    {
        StreamWriter writer = File.AppendText(fileName);
        writer.WriteLine();
        writer.WriteLine(expenses);
        writer.Close();
    }
}
