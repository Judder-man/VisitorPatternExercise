using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternExample.Console.Classes;

namespace VisitorPatternExample.Console.Interfaces
{
    public interface IExpressionVisitor
    {
        void Visit(Literal literal);
    }
}
