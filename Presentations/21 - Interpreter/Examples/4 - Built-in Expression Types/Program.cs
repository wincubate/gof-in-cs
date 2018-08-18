using System;
using System.Linq.Expressions;

namespace Wincubate.InterpreterExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Obj obj = new Obj
            {
                x = 8,
                y = 4
            };


            // obj.x - 6
            MemberExpression expressionX = Expression.Field(
               Expression.Constant(obj),
               "x");
            ConstantExpression expression6 = Expression.Constant(6);
            BinaryExpression expressionXminus6 = Expression.MakeBinary(
               ExpressionType.Subtract,
               expressionX,
               expression6
            );

            // (obj.x - 6 ) * y
            MemberExpression expressionY = Expression.Field(
               Expression.Constant(obj),
               "y");
            BinaryExpression expressionXminus6timesY = Expression.MakeBinary(
               ExpressionType.Multiply,
               expressionXminus6,
               expressionY
            );

            // 9 < (obj.x - 6 ) * y
            ConstantExpression expression9 = Expression.Constant(9);
            BinaryExpression expression = Expression.MakeBinary(
               ExpressionType.LessThan,
               expression9,
               expressionXminus6timesY
            );

            //Func<bool> lambda = Expression.Lambda<Func<bool>>(expression).Compile();
            //Console.WriteLine(lambda.Invoke());
        }
    }
}