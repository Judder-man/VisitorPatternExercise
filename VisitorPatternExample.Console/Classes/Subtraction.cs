using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternExample.Console.Interfaces;

namespace VisitorPatternExample.Console.Classes
{
    public class Subtraction : IExpression
    {
        internal IExpression Left { get; set; }
        internal IExpression Right { get; set; }

        public Subtraction(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        public void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }

    }

}
