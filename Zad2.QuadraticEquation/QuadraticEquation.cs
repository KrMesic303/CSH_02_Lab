using Zad2_3.QuadraticEquation.Structs;

namespace Zad2.QuadraticEquation
{
    public class QuadraticEquation
    {
        #region Private fields
        private double m_a;
        private double m_b;
        private double m_c;
        #endregion

        #region Public Properties
        public double A
        {
            get { return m_a; }
            set { m_a = value; }
        }
        public double B
        {
            get { return m_b; }
            set { m_b = value; }
        }
        public double C
        {
            get { return m_c; }
            set { m_c = value; }
        }
        public double Discriminant
        {
            get { return m_b * m_b - 4 * m_a * m_c; }
        }

        //public double[] Roots
        //{
        //    get { return GetRoots(m_a, m_b, m_c); }
        //}

        public Complex[] Roots
        {
            get
            {
                Complex r1 = (-B + Complex.Sqrt(Discriminant)[0]) / (2 * A);
                Complex r2 = (-B + Complex.Sqrt(Discriminant)[1]) / (2 * A);
                return new Complex[] { r1, r2 };
            }
        }
        #endregion

        #region Constructors

        public QuadraticEquation()
        {
            this.m_a = 0.0;
            this.m_b = 0.0;
            this.m_c = 0.0;
        }

        public QuadraticEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        #endregion

        #region Methods

        public double Y(double x)
        {
            return (A * x * x) + (B * x) + C;
        }

        private double[] GetRoots(double a, double b, double c)
        {
            if (Discriminant < 0)
            {
                throw new NotRealRootsException();
            }

            double[] roots = new double[2];

            roots[0] = (-b + Math.Sqrt(b * b - (4 * a * c))) / (2 * a);
            roots[1] = (-b - Math.Sqrt(b * b - (4 * a * c))) / (2 * a);

            return roots;
        }

        #endregion
    }

    public class NotRealRootsException : ArithmeticException
    {
        public NotRealRootsException() : base("Can't get root of negative number21")
        {

        }

        public NotRealRootsException(string message) : base(message)
        {

        }
    }
}
