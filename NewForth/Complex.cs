using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace NewForth
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }


        // Why operators are static in c#? 
        // 

        // Operator Overloading
        public static Complex operator+(Complex x, Complex y)
        {
            Complex complex = new Complex();
            complex.Real = x.Real + y.Real; 
            complex.Img = x.Img + y.Img;
            return complex;
        }

        // Here we will comment this and errors will not appear, because we implement implicit function
        //public static Complex operator +(int x, Complex y)
        //{
        //    Complex complex = new Complex();
        //    complex.Real = x + y.Real;
        //    complex.Img = y.Img;
        //    return complex;
        //}

        // Function static equals => it compares reference to reference

        public static bool operator==(Complex x, Complex y)
        {
            return x.Real == y.Real && x.Img == y.Img;
        }

        // Compiler does not allow to you implement == without implementing not equal
        public static bool operator !=(Complex x, Complex y)
        {
            return x.Real != y.Real || x.Img != y.Img;
        }


        // implicit operator => (int => Complex)
        public static implicit operator Complex(int num)
        {
            return new Complex { Real = num, Img = 0 };
        }

        // explicit operator => (Complex => int)
        public static explicit operator int(Complex c)
        {
            return c.Real;
        }


        // Here Overriding Operator ++
        public static Complex operator ++(Complex a)
        {
            ++a.Real;
            return a;
        }

        public static Complex operator --(Complex a)
        {
            --a.Real;
            return a;
        }

        public override string ToString()
        {
            return $"Real = { Real } \t Imaginary = { Img }";
        }
    }
}
