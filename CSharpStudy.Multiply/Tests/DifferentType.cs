﻿using BenchmarkDotNet.Attributes;
using System;

namespace CSharpStudy.Multiply.Tests
{
    [MemoryDiagnoser]
    [SimpleJob(warmupCount: 25, targetCount: 100)]
    public class DifferentType
    {
        public struct Complex
        {
            public double Real;
            public double Imag;

            public Complex(double r, double i)
            {
                Real = r;
                Imag = i;
            }

            public static Complex operator *(double lhs, Complex rhs)
            {
                return new Complex(lhs * rhs.Real, lhs * rhs.Imag);
            }

            public static bool operator !=(Complex lhs, Complex rhs)
            {
                return !(lhs == rhs);
            }
            public static bool operator ==(Complex lhs, Complex rhs)
            {
                return lhs.Real == rhs.Real && lhs.Imag == rhs.Imag;
            }
            public override bool Equals(object obj)
            {
                return obj is Complex complex &&
                       Real == complex.Real &&
                       Imag == complex.Imag;
            }
            public override int GetHashCode()
            {
                return HashCode.Combine(Real, Imag);
            }
        }

        private Random rd;

        public DifferentType()
        {
            rd = new Random();
        }

        public void Setup()
        {
            Solution<Double, Complex, Complex>.Prepare();
        }

        [Benchmark]
        public void MainRoutine()
        {
            Double lhs = rd.NextDouble();
            Complex rhs = new Complex(rd.NextDouble(), rd.NextDouble());

            Complex expected = lhs * rhs;
            Complex actual = Solution<Double, Complex, Complex>.Multiply(lhs, rhs);

            if (expected != actual)
                throw new TestFailException(expected, actual);
        }
    }
}
