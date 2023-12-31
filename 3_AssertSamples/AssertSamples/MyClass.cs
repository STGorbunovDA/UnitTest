﻿namespace AssertSamples
{
    public class MyClass
    {
        public static double GetSqrt(double value)
        {
            return Math.Sqrt(value);
        }

        public string SayHello(string name)
        {
            if (name == null)
                throw new ArgumentNullException("Parametr name cannot be null");
            
            return "Hello " + name;
        }
    }
}