using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DVectorClass
{
    struct _3DVector
    {
        public double X;
        public double Y;
        public double Z;
        public _3DVector(double X, double Y, double Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public _3DVector Sum(_3DVector vect1, _3DVector vect2)
        {
            _3DVector result = new _3DVector();

            result.X = vect1.X + vect2.X;
            result.Y = vect1.Y + vect2.Y;
            result.Z = vect1.Z + vect2.Z;

            return result;
        }
        public _3DVector Diff(_3DVector vect1, _3DVector vect2)
        {
            _3DVector result = new _3DVector();

            result.X = vect1.X - vect2.X;
            result.Y = vect1.Y - vect2.Y;
            result.Z = vect1.Z - vect2.Z;

            return result;
        }
        public static _3DVector operator *(_3DVector vect1, _3DVector vect2)
        {
            return new _3DVector(vect2.X * vect1.X, vect2.Y * vect1.Y, vect2.Z * vect1.Z);
        }
    }
}
