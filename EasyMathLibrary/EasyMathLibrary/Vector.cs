using System;
using System.Collections.Generic;
using System.Text;

namespace EasyMathLibrary
{
    public class Vector
    {
        #region 屬性的定義

        public double X { get; set; }

        public double Y { get; set; }

        public double Length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        #endregion 屬性的定義

        #region 建構式

        public Vector(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Vector() : this(0, 0)
        {
        }

        public Vector(Vector vector)
        {
            this.X = vector.X;
            this.Y = vector.Y;
        }

        #endregion 建構式
    }
}