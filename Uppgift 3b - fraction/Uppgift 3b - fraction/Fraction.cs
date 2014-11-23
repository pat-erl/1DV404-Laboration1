using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3b___fraction
{
    class Fraction
    {
        private int _numerator;
        private int _denominator;

        // Lade till denna konstruktorn för att kunna skapa ett nytt object utan argument i Main.
        public Fraction()
        {
            
        }

        // Skapar ett nytt bråktal.
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        // Egenskaper.
        public int Numerator
        {
            get
            {
                return _numerator; 
            }
            private set
            {
                _numerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return _denominator;
            }
            private set
            {
               if (value != 0)
               {
                   _denominator = value;
               }
               else
               {
                   throw new ArgumentOutOfRangeException();
               }
            }
        }

        // Kollar om ett bråktal är negativt.
        static public bool IsNegative(Fraction F)
        {
            double check = (double)F.Numerator / F.Denominator;
            if(check < 0)
            {
                return true;
            }
            return false;
        }

        // Adderar två bråktal och returnerar ett nytt bråktal
        public Fraction Add(Fraction A, Fraction B)
        {
            Numerator = A.Numerator * B.Denominator + B.Numerator * A.Denominator;
            Denominator = A.Denominator * B.Denominator;
            return new Fraction(Numerator, Denominator);
        }

        // Multiplicerar två bråktal och returnerar ett nytt bråktal
        public Fraction Multiply(Fraction A, Fraction B)
        {
            Numerator = A.Numerator * B.Numerator;
            Denominator = A.Denominator * B.Denominator;
            return new Fraction(Numerator, Denominator);
        }

        // Jämför två fraction-instanser och ser om de representerar samma bråktal.
        static public bool IsEqualTo(Fraction A, Fraction B)
        {
            if(A.Denominator == B.Denominator && A.Numerator == B.Numerator)
            {
                return true;
            }
            return false;
        }

        // Returnerar strängrepresentation av bråktalet i formatet T/N
        public override string ToString()
        {
            string str;
            str = Numerator + "/" + Denominator;
            return str;
        }
    }
}
