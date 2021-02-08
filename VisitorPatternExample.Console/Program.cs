using System;
using System.Text;
using VisitorPatternExample.Console.Classes;

namespace VisitorPatternExample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Expected output
             *
             *  (5+6)
             *  (5-6)
             *  5 6 +
             *  + 5 6

             *  (((5-6)+20)+(1+3))
             *  5 6 - 20 + 1 3 + +
             *  + + -5 6 20 + 1 3
             */
            var addition1 = new Addition(
                new Literal(5.0), new Literal(6.0));
            var subtraction1 = new Subtraction(
                new Literal(5.0), new Literal(6.0));

            var sb = new StringBuilder();
            var expressionPrinter = new InfixExpressionPrinter(sb);
            var postfixExpressionPrinter = new PostfixExpressionPrinter(sb);
            var prefixExpressionPrinter = new PrefixExpressionPrinter(sb);

            addition1.Accept(expressionPrinter);
            System.Console.WriteLine(sb);

            sb.Clear();
            subtraction1.Accept(expressionPrinter);
            System.Console.WriteLine(sb);

            sb.Clear();
            addition1.Accept(postfixExpressionPrinter);
            System.Console.WriteLine(sb);

            sb.Clear();
            addition1.Accept(prefixExpressionPrinter);
            System.Console.WriteLine(sb);

            System.Console.WriteLine("");

            var complexAddition = new Addition(
                new Addition(
                    new Subtraction(
                        new Literal(5.0), new Literal(6.0)),
                    new Literal(20.0)),
                new Addition(
                    new Literal(1.0), new Literal(3.0)));

            sb.Clear();
            complexAddition.Accept(expressionPrinter);
            System.Console.WriteLine(sb);

            sb.Clear();
            complexAddition.Accept(postfixExpressionPrinter);
            System.Console.WriteLine(sb);

            sb.Clear();
            complexAddition.Accept(prefixExpressionPrinter);
            System.Console.WriteLine(sb);
        }
    }
}
