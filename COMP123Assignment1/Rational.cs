
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123Assignment1
{
    public class Rational
    {
        //Auto implemented Properties
        public int Denominator { get; private set; }
        public int Numerator { get; private set; }

        //Constructor
        public Rational(int numerator=0,int denominator=1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        //ToString Method
        public override string ToString()
        {
            if(Denominator==1)
            {
                return $"{Numerator}";
            }
            else
            {
                return $"{Numerator}/{Denominator}";
            }
        }

        //IncreaseBy Method
        public void IncreaseBy(Rational other)
        {
            if(Denominator==other.Denominator)
            {
                Numerator = Numerator + other.Numerator;
            }
            else
            {
                Numerator = (Numerator * other.Denominator) + (other.Numerator * Denominator);
                Denominator = Denominator * other.Denominator;
            }
 
        }

        //DecreaseBy Method
        public void DecreaseBy(Rational other)
        {
            if(Denominator==other.Denominator)
            {
                Numerator = Numerator - other.Numerator;
            }
            else
            {
                Numerator = (Numerator * other.Denominator) - (other.Numerator * Denominator);
                Denominator = Denominator * other.Denominator;
            }
        }


    }
}
