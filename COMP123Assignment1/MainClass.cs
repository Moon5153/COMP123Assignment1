using System;

namespace COMP123Assignment1
{
    class MainClass
    {
        static void Main(string[] args)
        {

            //Rational number created using default constructor values
            Rational r1 = new Rational();
            Console.WriteLine("The 1st Rational number is: "+r1.ToString());

            //Rational number created by setting only the numerator value
            Rational r2 = new Rational(2);
            Console.WriteLine("The 2nd Rational number is: "+r2.ToString());

            //Rational number created by setting both numerator and denominator value
            Rational r3 = new Rational(5, 8);
            Console.WriteLine("The 3rd Rational number is: "+r3.ToString());

            //Rational number created by setting both numerator and denominator value
            Rational r4 = new Rational(3, 7);
            Console.WriteLine("The 4th Rational number is: "+r4.ToString());


            //IncreaseBy Method call
            Console.WriteLine("\nAfter Increasing 1st rational number by the 2nd Rational number:");
            Console.Write(r1.ToString() + " + " + r2.ToString());
            r1.IncreaseBy(r2);
            Console.WriteLine(" = " + r1);

            //DecreaseBy Method call
            Console.WriteLine("\nAfter decreasing 3rd rational number by the 4th Rational number:");
            Console.Write(r3.ToString() + " - " + r4.ToString());
            r3.DecreaseBy(r4);
            Console.WriteLine(" = " + r3);

        }
    }
}
