using System;

namespace BuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CombotBuilder constructionLine;
            AssemblyBay assembly = new AssemblyBay();

            constructionLine = new RimtechBuilder();
            assembly.Construct(constructionLine);
            constructionLine.Combot.Print();

            constructionLine = new MilagroBuilder();
            assembly.Construct(constructionLine);
            constructionLine.Combot.Print();

            constructionLine = new NeuropaBuilder();
            assembly.Construct(constructionLine);
            constructionLine.Combot.Print();

            Console.Read();
        }
    }
}