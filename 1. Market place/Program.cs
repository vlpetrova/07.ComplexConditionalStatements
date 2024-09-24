using System.ComponentModel.DataAnnotations;

string product = Console.ReadLine();
string dayType = Console.ReadLine();
double price = 0;

if (product == "Banana")
{
    if (dayType == "Weekday")
    {
        price = 2.50;
    }
    else if (dayType == "Weekend")
    {
        price = 2.70;
    }
}
if (product == "Apple")
{
    if (dayType == "Weekday")
    {
        price = 1.30;
    }
    else if (dayType == "Weekend")
    {
        price = 1.60;
    }
}
if ( product == "Kiwi")
{
    if (dayType == "Weekday")
    {
        price = 2.20;
    }
    else if (dayType == "Weekend")
    {
        price = 3.00;
    }
}
Console.WriteLine($"{price:F2}");
