using System;
using System.Runtime.InteropServices;

namespace DotnetAndCPP
{
    class Program
    {
        static void Main(string[] args)
        {
	    var a = 54;
	    var b = 23;

	    var result = add(a, b);

	    Console.WriteLine($"a: {a} + b: {b} = {result}");
        }

	[DllImport("libTestExample.so")]
	public static extern int add(int a, int b);
    }
}
