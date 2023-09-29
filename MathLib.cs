using Calculator;
using System.Runtime.Serialization;

namespace CalculatorB2B
{
    public static class MathLib
    {
        public static float Add(MathRequest mathRequest)
        {
            return mathRequest.Op1() + mathRequest.Op2();
        }

        public static float Sub(MathRequest mathRequest)
        {
            return mathRequest.Op1() - mathRequest.Op2();
        }

        public static float Mul(MathRequest mathRequest) 
        {
            return mathRequest.Op1() * mathRequest.Op2();
        }

        public static float Div(MathRequest mathRequest)
        {
            return mathRequest.Op1() / mathRequest.Op2();
        }

        public class CalcException : Exception { };

        [Serializable]
        internal class BadOperatorException : Exception
        {
            public BadOperatorException()
            {
            }

            public BadOperatorException(string? message) : base(message)
            {
            }

            public BadOperatorException(string? message, Exception? innerException) : base(message, innerException)
            {
            }

            protected BadOperatorException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
}
