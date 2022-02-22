System.Console.WriteLine("Give me a number between 1 - 10");
int number1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Give me another number between 1 - 10");
int number2 = int.Parse(Console.ReadLine());

if(number1 < number2)
{
     System.Console.WriteLine($"{number1} is less then {number2}!");
}

else if(number1 > number2)
{
     System.Console.WriteLine($"{number1} is greater then {number2}!");
}
else 
{
    System.Console.WriteLine($"The two numbers ({number1} and {number2}) are equal!");
}




