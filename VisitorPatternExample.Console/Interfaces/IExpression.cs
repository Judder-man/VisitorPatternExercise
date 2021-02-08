using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternExample.Console.Interfaces
{
    public interface IExpression
    {
        void Accept(IExpressionVisitor visitor);
    }
}
