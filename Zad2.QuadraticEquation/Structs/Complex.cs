using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_3.QuadraticEquation.Structs
{
    public struct Complex
    {
        #region Private fields

        private double m_real;
        private double m_imaginary;

        #endregion

        #region Public properties

        public double Re
        {
            get { return m_real; }
            set { m_real = value; }
        }

        public double Im
        {
            get { return m_imaginary; }
            set { m_imaginary = value; }
        }

        #endregion

        #region Constructors

        public Complex(double real, double imaginary)
        {
            Re = real;
            Im = imaginary;
        }

        public Complex(double real)
        {
            Re = real;
        }

        #endregion

        #region Overloading Arith. Operators

        public static Complex operator+ (Complex a, Complex b) => new Complex(a.Re + b.Re, a.Im + b.Im);
        public static Complex operator- (Complex a, Complex b) => new Complex(a.Re - b.Re, a.Im - b.Im);
        public static Complex operator* (Complex a, Complex b) => new Complex((a.Re*b.Re)-(a.Im*b.Im), (a.Re*b.Im)-(a.Im*b.Re));
        public static Complex operator/ (Complex a, Complex b) => new Complex(
            (a.Re * b.Re + a.Im * b.Im) / (b.Re * b.Re + b.Im * b.Im),
            (a.Im * b.Re - a.Re * b.Im) / (b.Re * b.Re + b.Im * b.Im));

        #endregion

        #region Convertions


    }
}
