using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example00
{
    internal class Empolyee
    {
        private double baseSalary;
        private double salary;
        private double benefit;

        public double BaseSalary
        {
            get => baseSalary;
            set => baseSalary = value;
        }

        public double Benefit
        {
            get => benefit;
            set => benefit = value;
        }
    }
}