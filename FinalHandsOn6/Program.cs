using System;

namespace FinalHandsOn6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a lowercase letter");
            string userletter = Console.ReadLine();
            switch (userletter)
            {
                case "a":
                    Console.WriteLine("a is for alpha");
                    break;
                case "b":
                    Console.WriteLine("b is for bravo");
                    break;
                case "c":
                    Console.WriteLine("c is for charlie");
                    break;
                case "d":
                    Console.WriteLine("d is for delta");
                    break;
                case "e":
                    Console.WriteLine("e is for echo");
                    break;
                case "f":
                    Console.WriteLine("f is for foxtrot");
                    break;
                case "g":
                    Console.WriteLine("g is for golf");
                    break;
                case "h":
                    Console.WriteLine("h is for hotel");
                    break;
                case "i":
                    Console.WriteLine("i is for india");
                    break;
                case "j":
                    Console.WriteLine("j is for juliet");
                    break;
                case "k":
                    Console.WriteLine("k is for kilo");
                    break;
                case "l":
                    Console.WriteLine("l is for lima");
                    break;
                case "m":
                    Console.WriteLine("m is for mike");
                    break;
                case "n":
                    Console.WriteLine("n is for november");
                    break;
                case "o":
                    Console.WriteLine("o is for oscar");
                    break;
                case "p":
                    Console.WriteLine("p is for papa");
                    break;
                case "q":
                    Console.WriteLine("q is for quebec");
                    break;
                case "r":
                    Console.WriteLine("r is for romeo");
                    break;
                case "s":
                    Console.WriteLine("s is for sierra");
                    break;
                case "t":
                    Console.WriteLine("t is for tango");
                    break;
                case "u":
                    Console.WriteLine("u is for uniform");
                    break;
                case "v":
                    Console.WriteLine("v is for victor");
                    break;
                case "w":
                    Console.WriteLine("w is for whiskey");
                    break;
                case "x":
                    Console.WriteLine("x is for x-ray");
                    break;
                case "y":
                    Console.WriteLine("y is for yankee");
                    break;
                case "z":
                    Console.WriteLine("z is for zulu");
                    break;
            }
            Console.WriteLine("Enter a number corisponding to a month(1-12)");
            int userNum = Convert.ToInt32(Console.ReadLine());
            switch (userNum)
            {
                case 1:
                    Console.WriteLine("winter");
                    break;
                case 2:
                    Console.WriteLine("winter");
                    break;
                case 3:
                    Console.WriteLine("spring");
                    break;
                case 4:
                    Console.WriteLine("spring");
                    break;
                case 5:
                    Console.WriteLine("spring");
                    break;
                case 6:
                    Console.WriteLine("summer");
                    break;
                case 7:
                    Console.WriteLine("summer");
                    break;
                case 8:
                    Console.WriteLine("summer");
                    break;
                case 9:
                    Console.WriteLine("autumn");
                    break;
                case 10:
                    Console.WriteLine("autumn");
                    break;
                case 11:
                    Console.WriteLine("autumn");
                    break;
                case 12:
                    Console.WriteLine("winter");
                    break;
            }
        }
    }
}
