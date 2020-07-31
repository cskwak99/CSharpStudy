namespace CSharpStudy.Multiply
{   
    /// <summary>
    /// 이번 과제는 Multiply 함수에서
    ///     - 최대한 빠르게 Generic variable의 곱셈을 수행하는 것
    /// 이 이번 목표입니다.
    /// 
    /// 다른 코드를 건드리지 않고 컴파일 되는 선에서 Solution.cs를 변경해서 최적화를 해보도록 합시다.
    /// </summary>
    public static class Solution<T1, T2, T3>
    {
        public static void Setup()
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

        public static void Cleanup()
        {
        }
    }
}
