using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumberLab1
{
    public class RationalNumber
    {
        public int Numerator { get; }
        public int Denomirator { get; }


        private static int EvklidAlgorithm(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }


        public RationalNumber(int numerator, int denomirator)
        {
            if (denomirator == 0)
            {
                throw new ArgumentException("Делитель не может быть равен нулю");
            }

            if (denomirator < 0)
            {
                numerator = -numerator;
                denomirator = -denomirator;
            }

            int NOD = EvklidAlgorithm(numerator, denomirator);
            Numerator = numerator / NOD;
            Denomirator = denomirator / NOD;
        }

        public override string ToString()
        {
            if (this.Denomirator == 1)
            {
                return $"{this.Numerator}";
            }

            else
            {
                return $"{this.Numerator}/{this.Denomirator}";
            }

        }

        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            int newNumerator = a.Numerator * b.Denomirator + b.Numerator * a.Denomirator;
            int newDenomirator = a.Denomirator * b.Denomirator;
            return new RationalNumber(newNumerator, newDenomirator);
        }


        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            int newNumerator = (a.Numerator * b.Denomirator) - (b.Numerator * a.Denomirator);
            int newDenomirator = a.Denomirator * b.Denomirator;
            return new RationalNumber(newNumerator, newDenomirator);
        }


        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            int newNumerator = a.Numerator * b.Numerator;
            int newDenomirator = a.Denomirator * b.Denomirator;
            return new RationalNumber(newNumerator, newDenomirator);
        }

        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            if (b.Numerator == 0)
            {
                throw new DivideByZeroException("Деление на ноль запрещено");
            }
            int newNumerator = a.Numerator * b.Denomirator;
            int newDenomirator = a.Denomirator * b.Numerator;
            return new RationalNumber(newNumerator, newDenomirator);
        }


        public static RationalNumber operator -(RationalNumber a)
        {
            return new RationalNumber(-a.Numerator, a.Denomirator);
        }

        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return ((a.Numerator == b.Numerator) && (a.Denomirator == b.Denomirator));
        }

        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !((a.Numerator == b.Numerator) && (a.Denomirator == b.Denomirator));
        }


        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return (a.Numerator * b.Denomirator < b.Numerator * a.Denomirator);
        }

        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return !(a.Numerator * b.Denomirator < b.Numerator * a.Denomirator);
        }

        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return ((a.Numerator * b.Denomirator < b.Numerator * a.Denomirator) || (a.Numerator * b.Denomirator == b.Numerator * a.Denomirator));
        }

        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return !((a.Numerator * b.Denomirator < b.Numerator * a.Denomirator) || (a.Numerator * b.Denomirator == b.Numerator * a.Denomirator));
        }
    }

}
