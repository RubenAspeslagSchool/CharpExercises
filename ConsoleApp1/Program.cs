// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using static ConsoleApp1.FactorialA;

// warmups:

Console.WriteLine("Warm Up");

foreach (int i in Fibonacci(10))
{
    Console.WriteLine(i);
}



static IEnumerable<int> Fibonacci(int count)
{
    int a = 0,
    b = 1;

    for (int i = 0; i < count; i++)
    {
        yield return a;
        int temp = a;
        a = b;
        b = temp + b;
    }
}


// 1A
Console.WriteLine("---------------- 1A -------------");


FactorialA fac = new FactorialA(5);
Console.WriteLine(fac.Calculate());


//1B
Console.WriteLine("---------------- 1B -------------");

FactorialB fac2 = new FactorialB() { Value = 6 };
Console.WriteLine(fac2.Result);

//1C
Console.WriteLine("---------------- 1C -------------");
Console.WriteLine(FactorialC.Calculate(5));



Console.WriteLine("---------------- 1D -------------");

Console.WriteLine(new FactorialD(5).Calculate()); 

Console.WriteLine("---------------- 1E -------------");

FactorialE fac5 = new FactorialE(5);
Console.WriteLine(fac5.Result);
