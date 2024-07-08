using System;

namespace AbstractFactory
{
    // Abstract Product A
    public abstract class Chair
    {
        public abstract string SitOn();
    }

    // Abstract Product B
    public abstract class Sofa
    {
        public abstract string LieOn();
    }
}
