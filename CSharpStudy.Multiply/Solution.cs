using CSharpStudy.Multiply.Tests;
using Microsoft.Diagnostics.Tracing.Parsers.Clr;
using System;
using System.Numerics;

namespace CSharpStudy.Multiply
{
    public static class Solution<T1, T2, T3>
    {
        public static void Prepare()
        {
        }

        public static T3 Multiply(T1 lhs, T2 rhs)
        {
            if (lhs is Complex)
            {
                if (rhs is Complex)
                {
                    Complex newLHS = (Complex)(object)lhs;
                    Complex newRHS = (Complex)(object)rhs;
            
                    Complex ans = new Complex(
                    newLHS.Real * newRHS.Real - newLHS.Imaginary * newRHS.Imaginary,
                    newLHS.Real * newRHS.Imaginary + newLHS.Imaginary * newRHS.Real
                    );
            
                    return (T3)(object)ans;
                }
                else if (rhs is Int32)
                {
                    Complex newLHS = (Complex)(object)lhs;
                    Int32 newRHS = (Int32)(object)rhs;
            
                    Complex ans = new Complex(newLHS.Real * newRHS, newLHS.Imaginary * newRHS);
            
                    return (T3)(object)ans;
                }
                else if (rhs is Single)
                {
                    Complex newLHS = (Complex)(object)lhs;
                    Single newRHS = (Single)(object)rhs;
            
                    Complex ans = new Complex(newLHS.Real * newRHS, newLHS.Imaginary * newRHS);
            
                    return (T3)(object)ans;
                }
            }
            else if (lhs is Int32)
            {
                if (rhs is Complex)
                {
                    Int32 newLHS = (Int32)(object)lhs;
                    Complex newRHS = (Complex)(object)rhs;
            
                    Complex ans = new Complex(
                    newLHS * newRHS.Real,
                    newLHS* newRHS.Imaginary
                    );
            
                    return (T3)(object)ans;
                }
                else if (rhs is Int32)
                {
                    Int32 newLHS = (Int32)(object)lhs;
                    Int32 newRHS = (Int32)(object)rhs;
            
                    Int32 ans = newLHS * newRHS;
            
                    return (T3)(object)ans;
                }
                else if (rhs is Single)
                {
                    Int32 newLHS = (Int32)(object)lhs;
                    Single newRHS = (Single)(object)rhs;
            
                    Single ans = newLHS * newRHS;
            
                    return (T3)(object)ans;
                }
            }
            else if (lhs is Single)
            {
                if (rhs is Complex)
                {
                    Single newLHS = (Single)(object)lhs;
                    Complex newRHS = (Complex)(object)rhs;
            
                    Complex ans = new Complex(
                    newLHS * newRHS.Real,
                    newLHS * newRHS.Imaginary
                    );
            
                    return (T3)(object)ans;
                }
                else if (rhs is Int32)
                {
                    Single newLHS = (Single)(object)lhs;
                    Int32 newRHS = (Int32)(object)rhs;
            
                    Single ans = newLHS * newRHS;
            
                    return (T3)(object)ans;
                }
                else if (rhs is Single)
                {
                    Single newLHS = (Single)(object)lhs;
                    Single newRHS = (Single)(object)rhs;
            
                    Single ans = newLHS * newRHS;
            
                    return (T3)(object)ans;
                }
            }
            return (dynamic)lhs * (dynamic)rhs;
        }
    }
}
