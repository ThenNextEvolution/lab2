using System;
using UtilityLibraries;
Console.WriteLine("Enter first of 2 numbers,then press enter: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second of 2 numbers and press enter: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number and press enter: ");
int c = Convert.ToInt32(Console.ReadLine());


//Eyitayo Akinjinmi CPS_3330_TECH_4982_Lab2 ");

Console.WriteLine(product.mutiply(a,b));

Console.WriteLine(product.sum(a,b,c));
Console.WriteLine( String.Format("Provided intergers: {0} {2} and {1}, the total is {3}",a,b,c, (a+b+c)));