using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataset = new Dataset("data.csv");

            foreach (var row in dataset.GetData())
            {
                Console.WriteLine(string.Join(' ', row));
            }

            var prototype = (Dataset)dataset.Clone();

            foreach (var row in prototype.GetData())
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}
