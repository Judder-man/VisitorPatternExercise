using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternExample.Console.Interfaces;

namespace VisitorPatternExample.Console.Classes
{
    public class PostfixExpressionPrinter : IExpressionVisitor
    {
        StringBuilder sb;

        public PostfixExpressionPrinter(StringBuilder sb)
        {
            this.sb = sb;
        }

        public void Visit(Literal literal)
        {
            sb.Append(literal.Value);
        }

        public void Visit(Addition addition)
        {
            addition.Left.Accept(this);
            sb.Append(" ");
            addition.Right.Accept(this);
            sb.Append(" +");
        }

        public void Visit(Subtraction subtraction)
        {
            subtraction.Left.Accept(this);
            sb.Append(" ");
            subtraction.Right.Accept(this);
            sb.Append(" -");
        }

    }
}
