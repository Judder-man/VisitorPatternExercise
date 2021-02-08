using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternExample.Console.Interfaces;

namespace VisitorPatternExample.Console.Classes
{
    public class PrefixExpressionPrinter : IExpressionVisitor
    {
        StringBuilder sb;

        public PrefixExpressionPrinter(StringBuilder sb)
        {
            this.sb = sb;
        }

        public void Visit(Literal literal)
        {
            sb.Append(literal.Value);
        }

        public void Visit(Addition addition)
        {
        }

        public void Visit(Subtraction subtraction)
        {

        }

    }
}
