using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursDZ
{

    internal class Complex
    {
        public double realNum { get; set; }
        public double imaginaryNum { get; set; }
        public Complex(double realNum, double imaginaryNum)
        {
            this.realNum = realNum;
            this.imaginaryNum = imaginaryNum;
        }

        public Complex Plus(Complex second) => new Complex((this.realNum + second.realNum), (this.imaginaryNum + second.imaginaryNum));
        public Complex Minus(Complex second) => new Complex((this.realNum - second.realNum), (this.imaginaryNum - second.imaginaryNum));
    }
}
