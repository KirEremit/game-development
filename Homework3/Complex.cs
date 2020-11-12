using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    struct Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x)
        {
            Complex y = new Complex();
            y.im = x.im + im;
            y.re = x.re + re;
            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y = new Complex();
            y.im = x.im - im;
            y.re = x.re - re;
            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex y = new Complex();
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
    }
}
