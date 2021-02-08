using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternExample.Console.Interfaces;

namespace VisitorPatternExample.Console.Classes
{
    public class Addition : IExpression
    {
        internal IExpression Left { get; set; }
        internal IExpression Right { get; set; }

        public Addition(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        public void Accept(IExpressionVisitor visitor)
        {
        }
    }
}
