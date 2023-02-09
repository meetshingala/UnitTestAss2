using System;

namespace CircleTest
{
    internal class Circle
    {
        private int v;

        public Circle()
        {
        }

        public Circle(int v)
        {
            this.v = v;
        }

        internal double GetArea()
        {
            throw new NotImplementedException();
        }

        internal double GetCircumference()
        {
            throw new NotImplementedException();
        }

        internal int GetRadius()
        {
            throw new NotImplementedException();
        }

        internal void SetRadius(int v)
        {
            throw new NotImplementedException();
        }
    }
}