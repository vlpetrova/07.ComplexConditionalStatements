int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
int thirdNum = int.Parse(Console.ReadLine());
int biggestNum = 0;

if (firstNum >= secondNum && firstNum >= thirdNum)
{
    biggestNum = firstNum;
}
else if (secondNum >= firstNum && secondNum >= thirdNum)
{
    biggestNum = secondNum;
}
else
{
    biggestNum = thirdNum;
}
Console.WriteLine(biggestNum);
